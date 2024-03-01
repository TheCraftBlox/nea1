using Microsoft.Data.Sqlite;
using NEA1.Forms.Setup.UserControls.Setup2;
using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media.Animation;

namespace NEA1.Forms.Setup.UserControls.SetupPg2
{
    internal class ModifyBtnClass : AddUser
    {
        public ModifyBtnClass(string _username, string[] _PageIDs) : base()
        {
            InitializeComponent();
            //set window title text
            this.Text = "Modify User";

            //set username box to username selected
            UsernameTxtBox.Text = _username;
            //disable as if you want to change the username, just create a new user
            UsernameTxtBox.Enabled = false;

            //set password fields to placedholder text that will display as •••••••••   
            //to easily indicate that its updating the password and it will reamin as is if left blank
            PasswordTxtBox.Text = "placeholder";
            PasswordTxtBox2.Text = "placeholder";

            //select all current pages the have access to 
            foreach (string name in _PageIDs)
            {
                //find index of the current page
                int index = PageListBox.FindStringExact(name);
                //set it to be checked
                PageListBox.SetItemCheckState(index, System.Windows.Forms.CheckState.Checked);
            }
           
            //get the admin status of the user
            string sql = $"SELECT AdminStatus FROM Users WHERE UserID ='{_username}'";
            
            //exeucte the sql 
            DB db = new();
            SqliteDataReader reader = db.ExecuteQuery(sql);

            //read the result 
            while(reader.Read())
            {   
                //get the value
                int AdminStatus = Convert.ToInt32(reader["AdminStatus"]);

                // if user is admin, checkbox and assign variable
                if (AdminStatus == 1) 
                {
                    adminCheckBox.Checked = true;
                    originalAdminStatus = true;
                }
                else
                {//otherwise
                    adminCheckBox.Checked = false;
                    originalAdminStatus = false;
                }
            }
            reader.Close();





            //declare variable so not null 
            passwordchanged = false;
        }

        //so that if password isnt changed wont hash the placeholder text
        public bool PasswordChanged { get { return passwordchanged; } }
        private bool passwordchanged;

        //so that if admin sataus isnt chaged, no need to uopdate it 
        public bool OriginalAdminStatus { get { return originalAdminStatus; } }
        private bool originalAdminStatus;


        //so that the checked item list can be compared to the inital one
        public string[] CheckedItemNames { get { return getCheckedItemNames(); } }

        //when either password box entered, remove placeholder text and set password changed true 
        protected override void PasswordTxtBox_Enter(object sender, EventArgs e)
        {
            if (!passwordchanged)
            {
                passwordchanged = true;
                PasswordTxtBox.Text = String.Empty;
            }

        }
        protected override void PasswordTxtBox2_Enter(object sender, EventArgs e)
        {
            if (!passwordchanged)
            {
                passwordchanged = true;
                PasswordTxtBox2.Text = String.Empty;
            }
        }

        protected string[] getCheckedItemNames()
        {
            //create list to iterate and add to 
            List<string> checkedItemsList = new List<string>();

            foreach (var item in PageListBox.CheckedItems)
            {
                //cast item as correcy type;
                NEA1.Forms.Setup.UserControls.Setup2.ListItem listItem = item as UserControls.Setup2.ListItem;
                //add name of item to list
                string name = listItem.Text;
                checkedItemsList.Add(name);
            }
            //convert to int[]
            return checkedItemsList.ToArray();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // ModifyBtnClass
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            ClientSize = new System.Drawing.Size(329, 399);
            Name = "ModifyBtnClass";
            Load += ModifyBtnClass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        //override the initial confirm click 
        protected override void ConfirmBtn_Click(object sender, EventArgs e)
        {

            if (PageListBox.CheckedItems.Count == 0)//check if user hasnt selcted a page
            {
                AddErrorBoxLbl.Text = "Selected Page(s) cannot be empty";
            }
            else if (passwordchanged)//if the passwords've changed, validate it 
            {
                //if passwords match
                if (PasswordTxtBox.Text == PasswordTxtBox2.Text)
                {
                    //assign variable to password
                    password = PasswordTxtBox.Text;
                    //remove user cant be empty / passwords dont match error box labl as both now valid
                    AddErrorBoxLbl.Text = string.Empty;

                    //set result to ok and close form
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                //nofity user that passwords dont match and make password variable null
                //if it was from a prev button click and it was valid but username wasnt 
                {
                    AddErrorBoxLbl.Text = "Passwords do not match!";
                    password = null;
                }
            }
            else
            {
                //page selected changed

                //set result to ok and close form
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void ModifyBtnClass_Load(object sender, EventArgs e)
        {

        }
    }
}
