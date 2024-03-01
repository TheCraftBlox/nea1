using Microsoft.Data.Sqlite;
using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA1.Forms.Settings
{
    public partial class Settings : UserControl
    {
        public Settings(string _user)
        {
            user = _user;

            InitializeComponent();

            //find out if the user has access to admin controls.
            string sql = $"SELECT AdminStatus FROM Users WHERE UserID = '{user}';";

            // execute command
            DB db = new();
            SqliteDataReader reader = db.ExecuteQuery(sql);
            //assume adminStatus false;
            int AdminStatus = 0;
            while (reader.Read())
            {
                //get correct value
                AdminStatus = Convert.ToInt32(reader["AdminStatus"]);
            }
            reader.Close();


            //if user admin, show the user editing controls
            if (AdminStatus == 1)
            {
                AdminPanel.Enabled = true;
                AdminPanel.Visible = true;
            }

            //create instance of usercontrol passing through the controls
            userMethods = new(RemoveBtn, ModifyBtn, AddBtn, UsersListBox);


            //MODIFY PASSWORD

            //declare variable so not null 
            passwordChanged = false;

            //set password fields to placedholder text that will display as •••••••••   
            //to easily indicate that its updating the password and it will reamin as is if left blank
            PasswordTxtBox.Text = "placeholder";
            PasswordTxtBox2.Text = "placeholder";


            //update password button only enabled once user is 
            UpdatePasswordBtn.Enabled = false;
        }
        private string user;
        private bool passwordChanged;
        private UserMethods userMethods;
        private void ModiftBtn_Click(object sender, EventArgs e)
        {
            //call usermethods
            userMethods.Modify();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            //call  usermethods
            userMethods.Remove();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //call  usermethods
            userMethods.Add();
        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userMethods.UsersListBox_SelectedIndexChanged();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTxtBox2_TextChanged(object sender, EventArgs e)
        {
            //if  password is being retyped then notify the user if the password does not meet criteria (8chars)
            if (PasswordTxtBox.Text.Length > 7 && PasswordTxtBox2.Text.Length > 7)
            {
                //if password long enough, enable confirm button and reset error label 
                UpdatePasswordBtn.Enabled = true;
                PasswordUpdateErrorLbl.Text = string.Empty;
            }
            else
            {
                //otherwise, disable confirm button and notify user that it needs to be atleast 8 chars
                UpdatePasswordBtn.Enabled = false;
                PasswordUpdateErrorLbl.Text = "Password must be atleast 8 characters";
            }
        }

        private void PasswordTxtBox_Enter(object sender, EventArgs e)
        {
            //if passsword is still placeholder when user focuses on the box, clear its value
            PlaceholderPassword();
        }

        private void PasswordTxtBox2_Enter(object sender, EventArgs e)
        {
            //if passsword is still placeholder when user focuses on the box, clear its value
            PlaceholderPassword();
        }
        private void PlaceholderPassword()
        {
            //if password hasnt eben changed
            if (!passwordChanged)
            {
                //set variable and clear the placeholder text of both
                passwordChanged = true;
                PasswordTxtBox.Text = String.Empty;
                PasswordTxtBox2.Text = String.Empty;
            }
        }

        private void UpdatePasswordBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxtBox.Text == PasswordTxtBox2.Text)
            {
                //remove any previous errors
                PasswordUpdateErrorLbl.Text = String.Empty;

                //new instance of DB
                DB db = new();

                //create hash of password
                string passwordHash = Logic.Logic.HashInput(PasswordTxtBox.Text);

                //update it in db 
                string sql = $"UPDATE Users SET PasswordHash = '{passwordHash}' WHERE UserID = '{user}';";
                db.ExecuteQuery(sql);

                //notify user of success
                MessageBox.Show("Updated!");

                //expected behaviour to clear inputs aftter confirm
                //also so that bad faith actors cant obtain value
                PasswordTxtBox.Text = string.Empty;
                    PasswordTxtBox2.Text = string.Empty;

                //clear error after passwords cleared
                PasswordUpdateErrorLbl.Text = String.Empty;

            }
            else
            //nofity user that passwords dont match 
            //if it was from a prev button click and it was valid but username wasnt 
            {
                PasswordUpdateErrorLbl.Text = "Passwords do not match!";
            }
        }
    }
}
