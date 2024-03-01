using NEA1.Forms.ProductList;
using System;
using System.Windows.Forms;

namespace NEA1.Forms.Setup.UserControls.SetupPg3
{
    public partial class Setup3 : UserControl
    {
        public Setup3()
        {
            InitializeComponent();
            productMethods = new ProductMethods(ProductsFlowPanel);
            productMethods.LoadProductsFlowPanel();
        }
        private ProductMethods productMethods;


        //eventhandler for the if shte next button is clisked 
        public event EventHandler BtnClicked;

        private void nextBtn_Click(object sender, EventArgs e)
        {
            //signal to setup.cs that the next button has been pushed
            BtnClicked?.Invoke(this, e);
        }

        private void Setup3_Load(object sender, EventArgs e)
        {
        }


        private void backBtn_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            productMethods.Add(sender, e);
        }
    }
}
