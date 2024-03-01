using Microsoft.Data.Sqlite;
using NEA1.Forms.CreateOrder;
using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace NEA1.Forms.Stock
{
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
            //instantiate List
            ProductStocks = new();
            //to avoid null reference error here:
            LoadProductsFlowPanel();
        }

        //define variable
        private List<ProductStock> ProductStocks;
        private void LoadProductsFlowPanel()
        {
            //reset prodoucts list to prevent duplicates.
            ProductStocks.Clear();

            //fetch ids of every product.
            string sql = " SELECT ProductID FROM Products;";
            //access databsae and execute query
            DB db = new();
            SqliteDataReader reader = db.ExecuteQuery(sql);

            //read results and create new instances of Product for each
            while (reader.Read())
            {
                int ID = Convert.ToInt32(reader["ProductID"]);
                ProductStock product = new ProductStock(ID);
                //assign event for product deletion
                product.Reload += Product_Reload;
                ProductStocks.Add(product);
            }
            reader.Close();

            //reset flowpanel to prevent duplicates.
            StockFlowPanel.Controls.Clear();

            //loopc through productStocks and add each item to flow panel
            foreach(ProductStock product in ProductStocks)
            {
                StockFlowPanel.Controls.Add(product);
            }
        }
        private void Product_Reload(object sender, EventArgs e)
        {
            LoadProductsFlowPanel();
        }

    }
}
