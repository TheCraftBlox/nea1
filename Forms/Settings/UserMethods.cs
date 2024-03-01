using NEA1.Forms.Setup.UserControls.Setup2;
using NEA1.Forms.Setup.UserControls.SetupPg2;
using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace NEA1.Forms.Settings
{
    internal class UserMethods
    {
        public UserMethods(Button _RemoveBtn, Button _ModifyBtn, Button _AddBtn,ListBox _UsersListBox)
        { 
            //assign variables from parameters
            RemoveBtn = _RemoveBtn;
            ModifyBtn = _ModifyBtn;
            AddBtn = _AddBtn;
            UsersListBox = _UsersListBox;

            //no item is selected so disable those buttons
            ModifyBtn.Enabled = false;
            RemoveBtn.Enabled = false;
            LoadUserListbox();
        }
        private Button RemoveBtn;
        private Button ModifyBtn;
        private Button AddBtn;
        private ListBox UsersListBox;
        //dictionary of userID and lisat of the names of all the pages they have acces to 
        private Dictionary<string, List<string>> userPages;

        //add user
        public void Add()
        {
            //show popup box
            AddUser addUser = new AddUser();
            DialogResult dialogResult = addUser.ShowDialog();

            //if user didnt back out
            if (dialogResult == DialogResult.OK)
            {
                //define variables from dialog box results
                string username = addUser.Username;
                string hashedPassword = Logic.Logic.HashInput(addUser.Password);
                int AdminStatus = Convert.ToInt32(addUser.AdminStatus);
                int[] PageIDs = addUser.CheckedItemsIDs;
                //define sql statement
                string sql = $"INSERT INTO Users (UserID, PasswordHash, AdminStatus) VALUES ('{username}', '{hashedPassword}',{AdminStatus});";

                DB dB = new DB();
                dB.ExecuteQuery(sql);

                //each page they have access to, add to db
                foreach (int pageID in PageIDs)
                {
                    sql = $"INSERT INTO UserPageAcess (userID, pageID) VALUES ('{username}', {pageID});";
                    dB.ExecuteQuery(sql);
                }
                LoadUserListbox();
            }
        }

        //modify user
        public void Modify()
        {
            //get selected item
            object selected = UsersListBox.Items[UsersListBox.SelectedIndex];
            //cast to ListItem (for access to properties)
            ListItem selectedItem = selected as ListItem;

            //create form + pass through current values
            ModifyBtnClass modifyBtnForm = new ModifyBtnClass(selectedItem.Name, selectedItem.Pages);

            //show form and store result
            DialogResult dialogResult = modifyBtnForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                //create new instance of db for sql q  queiries
                DB db = new();

                //compare if the selected pages of the modfit form are equal to initial value 
                bool areEqual = (selectedItem.Pages as IStructuralEquatable).Equals(modifyBtnForm.CheckedItemNames, EqualityComparer<string>.Default);

                //if they have changed
                if (!areEqual)
                {
                    //delete all current pages they have access to
                    string sql = $"DELETE FROM UserPageAcess WHERE UserID = '{selectedItem.Name}';";
                    //execute the query
                    db.ExecuteQuery(sql);
                    

                    //loop thourgh all pages they should have acces to now
                    foreach (int pageID in modifyBtnForm.CheckedItemsIDs)
                    {
                        //add the new page into the db 
                        sql = $"INSERT INTO UserPageAcess (userID, pageID) VALUES ('{selectedItem.Name}', {pageID});";
                        db.ExecuteQuery(sql);
                    }
                }

                //if the password was modifiedA
                if (modifyBtnForm.PasswordChanged)
                {

                    //create hash of password
                    string passwordHash = Logic.Logic.HashInput(modifyBtnForm.Password);
                    //update it in db 
                    string sql = $"UPDATE Users SET PasswordHash = '{passwordHash}' WHERE UserID = '{selectedItem.Name}';";
                    db.ExecuteQuery(sql);
                }

                // if admin status updated 
                if(modifyBtnForm.AdminStatus != modifyBtnForm.OriginalAdminStatus)
                {
                    //update it in db 
                    string sql = $"UPDATE Users SET AdminStatus = '{Convert.ToInt32(modifyBtnForm.AdminStatus)}' WHERE UserID = '{selectedItem.Name}';";
                    db.ExecuteQuery(sql);
                }

            }

        }

        //remove user
        public void Remove()
        {
            //get selected item
            object selected = UsersListBox.Items[UsersListBox.SelectedIndex];
            //cast to ListItem (for access to .name property)
            ListItem selectedItem = selected as ListItem;

            //Show dialog box with ok and cancel buttons
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete user {selectedItem.Name}?",
                "Warning", MessageBoxButtons.OKCancel);

            //is user confirms to delete
            if (dialogResult == DialogResult.OK)
            {
                //create instance of db to create conection
                DB db = new();

                // SQL query to delete the user from the UserPageAccess table
                string sql = $"DELETE FROM UserPageAcess WHERE UserID = '{selectedItem.Name}';";
                //execute the query
                db.ExecuteQuery(sql);

                // SQL query to delete the user from the Users table
                sql = $"DELETE FROM Users WHERE UserID = '{selectedItem.Name}';";
                //execute the query
                db.ExecuteQuery(sql);

                //reload the list box with the item now removed 
                LoadUserListbox();

                //play sound to nofiy user of success
                System.Media.SystemSounds.Asterisk.Play();
            }

        }

        //reloads the userListBox 
        private void LoadUserListbox()
        {
            //resets dictionary as likely to be changes 
            //call method 
            userPages = new DB().GetUserPagesDictionary();

            //remove all items in listbox already so no double items 
            UsersListBox.Items.Clear();

            //loop through dictionary 
            foreach (var item in userPages)
            {
                string[] value = item.Value.ToArray();
                //add items to UsersListBox in readable form
                UsersListBox.Items.Add(new ListItem { Name = item.Key, Pages = value });
            }

            //FOCUs ON USER LIST BOX HAS BEEN LOST 
            //therefore selected item deselcted without call to function
            //so disable remofe and modify button 
            ModifyBtn.Enabled = false;
            RemoveBtn.Enabled = false;
        }

        public void UsersListBox_SelectedIndexChanged()
        {
            if (UsersListBox.SelectedIndex == -1)
            {
                ModifyBtn.Enabled = false;
                RemoveBtn.Enabled = false;
            }
            else
            {
                ModifyBtn.Enabled = true;
                RemoveBtn.Enabled = true;
            }
        }
    }

    class ListItem
    {
        public string Name { get; set; }
        public string[] Pages { get; set; }
        public override string ToString()
        {
            return $"{Name} ({string.Join(", ", Pages)})";
        }
    }
}
