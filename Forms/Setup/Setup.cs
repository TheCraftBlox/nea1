using NEA1.Forms.Setup.UserControls;
using NEA1.Forms.Setup.UserControls.SetupPg2;
using NEA1.Forms.Setup.UserControls.SetupPg3;
using System;
using System.Windows.Forms;

namespace NEA1.Forms.Setup
{
    public partial class Setup : Form
    {

        public Setup()
        {
            InitializeComponent();
        }
        //load setup page 
        public string LoggedInUser { get { return loggedInUser; } }
        private string loggedInUser;
        private void CreateUserControl(System.Windows.Forms.UserControl control)
        {
            //get what page is being loaded
            switch (control.GetType().Name)
            {
                case "Setup1":
                    //cast given control to correct type to access event 
                    Setup1 page1 = control as Setup1;

                    //assign event to method to handle it
                    page1.BtnClicked += child_DataAvailable;
                    break;
                case "Setup2":
                    //cast given control to correct type to access event 
                    Setup2 page2 = control as Setup2;

                    //assign event to method to handle it
                    page2.BtnClicked += child_DataAvailable;
                    break;
                case "Setup3":
                    //cast given control to correct type to access event
                    Setup3 page3 = control as Setup3;

                    //assign event to method to handle 
                    page3.BtnClicked += child_DataAvailable;
                    break;
            }

            //fill the screen
            control.Dock = DockStyle.Fill;
            //adds the Usercontrol to the form
            this.Controls.Add(control);
            //shows it 
            control.BringToFront();

        }

        //out with the old, in with the new (usercontrol)
        private void CreateUserControl(UserControl control, UserControl CurrentUserControl)
        {
            //end the current ucsercontrol
            this.Controls.Remove(CurrentUserControl);
            //create a new one
            CreateUserControl(control);
        }
        private void Setup_Load(object sender, EventArgs e)
        {

            // Add a child form
            UserControls.Setup1 child = new NEA1.Forms.Setup.UserControls.Setup1();

            //show formon screen
            CreateUserControl(child);

        }

        // when data is sent from setupX.cs to this
        void child_DataAvailable(object sender, EventArgs e)
        {
            //childform is a usercontrol 
            UserControl child = sender as UserControl;

            //get the name of the type fo the childform (setup1 setup2,setup3)

            switch (child.GetType().Name)
            {
                case "Setup1":
                    //if pre-made database selected
                    if (NEA1.Properties.Settings.Default.SetupComplete)
                    {
                        LoadMainForm();
                    }
                    else//otherwise
                    {
                        Setup2 setup2 = new Setup2();
                        //show the next setup screen
                        CreateUserControl(setup2, child);
                    }
                    break;
                case "Setup2":
                    CreateUserControl(new UserControls.SetupPg3.Setup3(), child);
                    break;
                case "Setup3":
                    NEA1.Properties.Settings.Default["SetupComplete"] = true;
                    NEA1.Properties.Settings.Default.Save();

                    LoadMainForm();
                    break;
                default:
                    MessageBox.Show(child.GetType().Name);
                    break;
            }
        }
        void LoadMainForm()
        {
            //create new login dialog
            Login.Login loginScreen = new Forms.Login.Login();

            //show it to user
            DialogResult dialogResult = loginScreen.ShowDialog();

            //if the user enteres a correct password
            if (dialogResult == DialogResult.OK)
            {
                //pass property through
                loggedInUser = loginScreen.loggedInUser;

                //close the setup form once dialog is closed 
                DialogResult = DialogResult.OK;
                this.Close();
            }

        }









    }

}
