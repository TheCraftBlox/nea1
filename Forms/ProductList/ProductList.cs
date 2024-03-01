using Microsoft.Data.Sqlite;
using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NEA1.Forms.ProductList
{
    public partial class ProductList : UserControl
    {
        public ProductList()
        {
            InitializeComponent();

            //clear search button only visible after a search
            clearSearchBtn.Visible = false;


            //define sql
            string sql = "SELECT ProductName,ProductID FROM Products;";

            //create instances of objects
            DB db = new();
            List<string> prodcuctNameList = new();
            productIDList = new();
            productMethods = new ProductMethods(ProductsFlowPanel);


            //execute query
            SqliteDataReader reader = db.ExecuteQuery(sql);

            //loop through results and add each record to lists
            while (reader.Read())
            {
                string productName = reader["ProductName"].ToString();
                prodcuctNameList.Add(productName);

                int ProductID = Convert.ToInt32(reader["ProductID"]);
                productIDList.Add(ProductID);
            }
            reader.Close();

            ;

            //create auto complete collection and assign it to textbox
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(prodcuctNameList.ToArray());
            searchTxtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchTxtBox.AutoCompleteCustomSource = autoCompleteStringCollection;
            //suggest is dropdown 
            searchTxtBox.AutoCompleteMode = AutoCompleteMode.Suggest;


            productMethods.LoadProductsFlowPanel();
        }

        ProductMethods productMethods;
        List<int> productIDList;

        private void ProductList_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            //create ranked resutls from query
            int[] rankedProductIDs = ProductMethods.ResultsRank(searchTxtBox.Text);

            //reload flow panel with IDs of rankled results
            productMethods.LoadProductsFlowPanel(rankedProductIDs);
            // if user searched for ""
            if (searchTxtBox.Text == string.Empty)
            {
                //thyere actually clearing search results
                CurrentSelectionLbl.Text = "All Products:";
                clearSearchBtn.Visible = false;

            }
            else
            {

                //notify user and give buttton to clear the search
                CurrentSelectionLbl.Text = "Search :" + searchTxtBox.Text;
                clearSearchBtn.Visible = true;
            }
        }



        private void Add_Click(object sender, EventArgs e)
        {
            productMethods.Add(sender, e);
        }

        private void searchTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if therer is an enter on 
            if (e.KeyCode == Keys.Return)
            {
                SearchButton_Click(sender, e);
            }
        }

        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            productMethods.LoadProductsFlowPanel();
            CurrentSelectionLbl.Text = "All Products:";
            clearSearchBtn.Visible=false;
        }
    }
}
