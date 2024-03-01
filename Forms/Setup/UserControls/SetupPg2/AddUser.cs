using Microsoft.Data.Sqlite;
using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace NEA1.Forms.Setup.UserControls.Setup2
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            //load the listbox with all the pages on the forms load;
            LoadPageListBox();

        }

        //declare public and private varibles 
        //public versions of username/password/checkeditemIDs do not need to have setters 
        public string Username { get { return username; } }
        protected string username;
        public string Password { get { return password; } }
        protected string password;

        public bool AdminStatus { get { return adminCheckBox.Checked; } }

        //does not need a private variable as it has the method to return the values 
        public int[] CheckedItemsIDs { get { return getCheckedItemIDs(); } }

        //adds all pagenames to the listbox with data of their ID's 
        protected void LoadPageListBox()
        {
            //create the sql query
            string sql = "SELECT * FROM Pages;";
            DB db = new DB();
            //execute the query
            SqliteDataReader reader = db.ExecuteQuery(sql);

            //read the returned data
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                //add to listbox as new instance of listitem class with the properties assigned
                PageListBox.Items.Add(new ListItem { Text = name, ID = id });
            }
            reader.Close();
        }


        protected void label1_Click(object sender, EventArgs e)
        {

        }

        protected void AddUser_Load(object sender, EventArgs e)
        {

        }

        protected void PageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void UsernameTxtBox_TextChanged(object sender, EventArgs e)
        {
            //if the username text box is modified, update the variable 
            //so that instead of sernameTxtBox.Text; i can use username instead for ease 
            username = UsernameTxtBox.Text;
        }

        protected void PasswordTxtBox2_TextChanged(object sender, EventArgs e)
        {
            //if  password is being retyped then notify the user if the password does not meet criteria (8chars)
            if (PasswordTxtBox.Text.Length > 7 && PasswordTxtBox2.Text.Length > 7)
            {
                //if password long enough, enable confirm button and reset error label 
                ConfirmBtn.Enabled = true;
                AddErrorBoxLbl.Text = string.Empty;
            }
            else
            {
                //otherwise, disable confirm button and notify user that it needs to be atleast 8 chars
                ConfirmBtn.Enabled = false;
                AddErrorBoxLbl.Text = "Password must be atleast 8 characters";
            }
        }

        virtual protected void ConfirmBtn_Click(object sender, EventArgs e)
        {

            //check for empty username as invalid.
            if (username == null)
            {
                AddErrorBoxLbl.Text = "Username cannot be empty";
            }
            else if (username.Trim().Length == 0)//check empty username if username is only whitespace
            {
                AddErrorBoxLbl.Text = "Username cannot be empty";
            }
            else if (PageListBox.CheckedItems.Count == 0)//check if user hasnt selcted a page
            {
                AddErrorBoxLbl.Text = "Selected Page(s) cannot be empty";
            }
            else
            {
                //if passwords match
                if (PasswordTxtBox.Text == PasswordTxtBox2.Text)
                {
                    //assign variable to password
                    password = PasswordTxtBox.Text;
                    //remove user cant be empty / passwords dont match error box labl as both now valid
                    AddErrorBoxLbl.Text = string.Empty;

                    //if username isnt taken
                    if (!isUsernameTaken(username))
                    {
                        //set result to ok and close form
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {//notify user that username is used
                        AddErrorBoxLbl.Text = "Username already taken!";
                    }
                }
                else
                //nofity user that passwords dont match and make password variable null
                //if it was from a prev button click and it was valid but username wasnt 
                {
                    AddErrorBoxLbl.Text = "Passwords do not match!";
                    password = null;
                }
            }
        }

        //checks if the username is already in use by the database
        protected bool isUsernameTaken(string username)
        {
            //create SQL statement
            string sql = $"select UserID From Users Where UserID = '{username}';";
            DB dB = new DB();
            //execute the query
            SqliteDataReader reader = dB.ExecuteQuery(sql);
            //if the query returned results 
            if (reader.Read())
            {
                //then that username is in the db threfore stop reading and true
                reader.Close();
                return true;
            }
            //else no results so not in database
            return false;
        }


        //gets the ID's of the selected pages
        protected int[] getCheckedItemIDs()
        {
            //create list to iterate and add to 
            List<int> checkedItemsList = new List<int>();

            foreach (var item in PageListBox.CheckedItems)
            {
                //cast item as correcy type;
                ListItem listItem = item as ListItem;
                //add id of item to list
                int id = listItem.ID;
                checkedItemsList.Add(id);
            }
            //convert to int[]
            return checkedItemsList.ToArray();
        }

        virtual protected void PasswordTxtBox2_Enter(object sender, EventArgs e)
        {

        }
        virtual protected void PasswordTxtBox_Enter(object sender, EventArgs e)
        {

        }
    }
    //class to store id and name of each page together 
    public class ListItem
    {
        public string Text { get; set; }
        public int ID { get; set; }

        //override the ToString method to return the name of the item when is assigned in lisbox
        public override string ToString()
        {
            return Text;
        }
    }
}
