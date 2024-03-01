using System;
using System.Windows.Forms;

namespace NEA1.Forms.ProductList
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        public string ChosenProductName { get { return ProductNameTxtBox.Text; } }
        public int ProductPrice { get { return Convert.ToInt32(priceNumUpDown.Value * 100); } }
        public int ProductStock { get { return (int)stockNumUpDown.Value; } }
        public int ProductMaxStock { get { return (int)maxStockNumUpDown.Value; } }
        public string Base64Image { get { return base64Image; } }
        private string base64Image;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            //if no name entered or is only spces
            if (ChosenProductName == null || ChosenProductName.Trim().Length == 0)
            {
                //warn user 
                MessageBox.Show("Enter a product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //if name is valid, close form
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            //create file popup
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                //defult to png and add .png auto if not seleced
                ofd.DefaultExt = "png";
                ofd.AddExtension = true;
                //png and jpg are choseable
                ofd.Filter = "Image Files(*.png;*.jpg)|*.png;*.jpg";
                //if a file is selected after the dialog is shown (ie. they didnt click cancel)
                if (ofd.ShowDialog() == DialogResult.OK)//todo check selected databse is valid befroe cont. 
                {
                    //get the path of chosen file
                    string filePath = ofd.FileName;

                    //show the chosen image to user
                    SelectedImage.Image = System.Drawing.Image.FromFile(filePath);
                    SelectedImageLocationLbl.Text = ofd.FileName;

                    //convert to base64 to be stored in db
                    base64Image = Logic.Logic.ImageToBase64String(filePath);
                }
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
