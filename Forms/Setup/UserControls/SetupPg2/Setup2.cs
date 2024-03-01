using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.VisualBasic.ApplicationServices;
using NEA1.Forms.Settings;
using NEA1.Forms.Setup.UserControls;
using NEA1.Forms.Setup.UserControls.Setup2;
using NEA1.Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace NEA1.Forms.Setup.UserControls.SetupPg2
{
    public partial class Setup2 : UserControl
    {

        public Setup2() 
        {
            InitializeComponent();
            // create usermethods instance
            userMethods = new UserMethods(RemoveBtn, ModifyBtn,AddBtn, UsersListBox);
        }

        public event EventHandler BtnClicked;
        private UserMethods userMethods;
        private void NextBtn(object sender, EventArgs e)
        {
            //invoke the event to advance to next page
            BtnClicked?.Invoke(this, e);
        }

        //when the add button is clicked
        private void AddBtn_Click(object sender, EventArgs e)
        {
            //call usermethods 
            userMethods.Add();
        }
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            //call usermethods
            userMethods.Remove();
        }
        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //call usermethods
            userMethods.UsersListBox_SelectedIndexChanged();
        }
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            //call usermethods
            userMethods.Modify();
        }


        private void Setup2_Load(object sender, EventArgs e)
        {

        }

    }


}