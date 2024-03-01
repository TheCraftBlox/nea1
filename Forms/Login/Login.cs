using NEA1.Logic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NEA1.Forms.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string loggedInUser { get { return LoggedInUser; } }
        private string LoggedInUser;

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtbox.Text;
            string password = PasswordTxtbox.Text;

            //hash inputted password
            string passwordHash = Logic.Logic.HashInput(password);

            //find passwordhash in db for username
            DB db = new DB();
            Microsoft.Data.Sqlite.SqliteDataReader reader = db.ExecuteQuery($"SELECT PasswordHash FROM Users WHERE USERID ='{username}';");

            //issread indicates if SQL query returned anything (i.e was that username in the database)
            bool isRead = false;
            string CorrectPassHash = string.Empty;

            //read the value from the query
            while (reader.Read())
            {
                isRead = true;
                CorrectPassHash = (string)reader[0];
            }
            reader.Close();

            //if username was in database do they match?
            if (isRead && (CorrectPassHash == passwordHash))
            {
                //assign to username
              LoggedInUser = username;

                //correct user/pass combo so return ok + close dialogbox 
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            //notify user that usrename/password is invalid
            System.Media.SystemSounds.Hand.Play();
            LoginSuccessLbl.ForeColor = Color.Red;
            LoginSuccessLbl.Text = "Invalid username or password";

        }

        //called when the cancel button is clicked
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //exit the application
            this.Close();
        }
    }
}
