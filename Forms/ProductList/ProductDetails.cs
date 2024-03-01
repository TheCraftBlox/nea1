using Microsoft.Data.Sqlite;
using NEA1.Logic;
using System;
using System.Windows.Forms;

namespace NEA1.Forms.ProductList
{
    public partial class ProductDetails : Product
    {
        public ProductDetails(int productID) : base(productID)
        {
            InitializeComponent();
            LoadUsercontrolData();
        }





        public event EventHandler Reload;

        private void productImg_Click(object sender, EventArgs e)
        {

        }
        private void LoadUsercontrolData()
        { 

            //assign rest of the controls to the variables
            //converting to correct format
            PriceLbl.Text = "£" + (Price / 100m).ToString("0.00");
            StockLbl.Text = Stock.ToString();
            MaxStockLbl.Text = MaxStock.ToString();
            StockPercentLbl.Text = (100 * Stock / MaxStock).ToString("0") + "%";
        }


        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            //create instance of ModifyProduct
            ModifyProduct modifyProduct = new ModifyProduct(productImg.Image, this);

            DialogResult dialogResult = modifyProduct.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                //define variables 
                string sql;
                DB dB = new DB();

                // Detect what changed and update database as necessary.

                //if the current title displayed is diff from the one in th4e form
                //must've changed
                if (title != modifyProduct.ChosenProductName)
                {
                    //set sql statement & ewxecute the command
                    sql = $"UPDATE Products SET ProductName = '{modifyProduct.ChosenProductName}' WHERE ProductID = {productID};";
                    dB.ExecuteQuery(sql);
                }

                //if the current price displayed is diff from the one in th4e form
                //must've changed
                if (price != modifyProduct.ProductPrice)
                {
                    //set sql statement & ewxecute the command
                    sql = $"UPDATE Products SET ProductPrice = {modifyProduct.ProductPrice} WHERE ProductID = {productID};";
                    dB.ExecuteQuery(sql);

                }

                //if the current stock displayed is diff from the one in th4e form
                //must've changed
                if (stock != modifyProduct.ProductStock)
                {
                    //set sql statement & ewxecute the command
                    sql = $"UPDATE Products SET ProductStock = {modifyProduct.ProductStock} WHERE ProductID = {productID};";
                    dB.ExecuteQuery(sql);

                }
                //if the current max Stock displayed is diff from the one in th4e form
                //must've changed
                if (maxStock != modifyProduct.ProductMaxStock)
                {
                    //set sql statement & ewxecute the command
                    sql = $"UPDATE Products SET ProductMaxStock = {modifyProduct.ProductMaxStock} WHERE ProductID = {productID};";
                    dB.ExecuteQuery(sql);

                }

                //if the stringBase64image is null then a new image wasn't selected 
                //so if not null
                //must've changed
                if (modifyProduct.Base64Image != null)
                {
                    //set sql statement & ewxecute the command
                    sql = $"UPDATE Products SET ProductImg = '{modifyProduct.Base64Image}' WHERE ProductID = {productID};";
                    dB.ExecuteQuery(sql);
                }

                //call event to reload flowlayoutpanel 
                Reload?.Invoke(this, e);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Show dialog box with ok and cancel buttons
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete product {Title}?",
                "Warning", MessageBoxButtons.OKCancel);

            //is user confirms to delete
            if (dialogResult == DialogResult.OK)
            {
                //create instance of db to create conection
                DB db = new();

                // SQL query to check if the ProductID exists in the OrderDetails table
                string sql = $"SELECT COUNT(*) FROM OrderDetails WHERE ProductID = '{productID}';";
                //execute the query
                SqliteDataReader reader = db.ExecuteQuery(sql);

                int count = 0;
                if (reader.Read())
                {
                    count = reader.GetInt32(0);
                }

                if (count > 0)
                {
                    // ProductID exists in the OrderDetails table, so we can delete it
                    sql = $"DELETE FROM OrderDetails WHERE ProductID = '{productID}';";
                    db.ExecuteQuery(sql);
                }

                // SQL query to delete the user from the products table
                sql = $"DELETE FROM Products WHERE ProductID = '{productID}';";
                //execute the query
                db.ExecuteQuery(sql);

                //play sound to nofiy user of success
                System.Media.SystemSounds.Asterisk.Play();

                //call event to reload flowlayoutpanel 
                Reload?.Invoke(this, e);

            }
        }
    }
}
