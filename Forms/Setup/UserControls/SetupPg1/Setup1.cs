using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
//using System.Data.SQLite;
using System.Windows.Shapes;
using System.Drawing.Text;

namespace NEA1.Forms.Setup.UserControls
{
    public partial class Setup1 : UserControl
    {
        public Setup1()
        {
            InitializeComponent();
            button1.Enabled = false;
            fileSelectedLabel.Text = string.Empty;
        }

        private void Setup1_Load(object sender, EventArgs e)
        {

        }

        private void noButton_CheckedChanged(object sender, EventArgs e)
        {
            //allow user to select file 
            button3.Enabled = true;
            label3.Text = "If No, Please choose a file location for the database to be stored";

        }

        private void yesbutton_CheckedChanged(object sender, EventArgs e)
        {
            //allow user to select file of where .sqllte file is
            button3.Enabled = true;
            label3.Text = "If yes, Please select the file location of the database ";

        }


        private bool DBexists
        {
            get { return yesbutton.Checked; }
            set { yesbutton.Checked = value; }
        }

        public event EventHandler BtnClicked;

        private void button1_Click(object sender, EventArgs e)
        {
            //create an event
            BtnClicked?.Invoke(this, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            if (DBexists)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.DefaultExt = ".sqlite";
                    ofd.AddExtension = true;
                    ofd.Filter = "SQLite Database|*.sqlite";
                    //if a file is selected after the dialog is shown (ie. they didnt click cancel)
                    if (ofd.ShowDialog() == DialogResult.OK)//todo check selected databse is valid befroe cont. 
                    {
                        //get the path of chosen file
                        filePath = ofd.FileName;
                        DB dB = new DB(filePath);
                        if (dB.ValidDB())
                        {
                            //notify user that success
                            System.Media.SystemSounds.Asterisk.Play();
                            button1.Enabled = true;
                            fileSelectedLabel.Text = "File at : " + filePath + ".";

                            //ensure that setup doesnt need to be completedn next lozad
                            NEA1.Properties.Settings.Default["SetupComplete"] = true;
                            NEA1.Properties.Settings.Default.Save();
                        }
                        else
                        {
                            //notify user of failure
                            MessageBox.Show("The file you selected is not in the correct form, please try again.",
                                "Wrong File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            button1.Enabled = false;
                            fileSelectedLabel.Text = string.Empty;
                        }


                    }
                }
            }
            else

            {
                using (saveFileDialog1 = new SaveFileDialog())
                {
                    saveFileDialog1.InitialDirectory = @"c:\";
                    saveFileDialog1.Filter = "SQLite Database|*.sqlite";
                    saveFileDialog1.DefaultExt = ".sqlite";

                    //if a file is selected after the dialog is shown (ie. they didnt click cancel)
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //get the path of chosen file
                        filePath = saveFileDialog1.FileName;
                        //create the database
                        DB.createDatabase(filePath);
                        //allow them to proceeed
                        button1.Enabled = true;
                        //tell them what file they have selected.
                        fileSelectedLabel.Text = "File at : " + filePath + ".";
                    }
                    else
                    {
                        button1.Enabled = false;
                        fileSelectedLabel.Text = string.Empty;
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
