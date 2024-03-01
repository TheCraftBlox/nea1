using Microsoft.Data.Sqlite;
using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NEA1.Forms.CreateOrder
{
    public partial class CreateOrder : UserControl
    {
        public CreateOrder()
        {
            InitializeComponent();
            //avoid Object reference not set to an instance of an object.'
            ProductAddOrders = new();
            //in :
            LoadProductsFlowPanel();

            basket = new();
        }

        //define variable
        private List<ProductAddOrder> ProductAddOrders;
        private int total;
        private HashSet<ProductAddOrder> basket;

        public void LoadProductsFlowPanel()
        {
            //reset prodoucts list to prevent duplicates.
            ProductAddOrders.Clear();

            //fetch ids of every product.
            string sql = " SELECT ProductID FROM Products;";
            //access databsae and execute query
            DB db = new();
            SqliteDataReader reader = db.ExecuteQuery(sql);

            //read results and create new instances of Product for each
            while (reader.Read())
            {
                int ID = Convert.ToInt32(reader["ProductID"]);
                ProductAddOrder product = new ProductAddOrder(ID);
                //assign event for adding to basket
                product.AddBtn += ProductAddOrder_AddBtn;
                ProductAddOrders.Add(product);
            }
            reader.Close();

            //reset flowpanel to prevent duplicates.
            ProductFlowPanel.Controls.Clear();


            //add usercontrol product to flowpanel 
            foreach (ProductAddOrder product in ProductAddOrders)
            {
                ProductFlowPanel.Controls.Add(product);
            }

        }
        private void ProductAddOrder_AddBtn(object sender, EventArgs e)
        {
            //cast to correct type
            ProductAddOrder product = sender as ProductAddOrder;

            //add item to basket
            basket.Add(product);

            //has atleast 1 itme now, enable button
            FinaliseBtn.Enabled = true;
            //update the total
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            //reset cost
            total = 0;
            //each item in basket
            foreach (ProductAddOrder product in basket)
            {   //add cost 
                total += product.Price * product.Quantity;
            }
            //update lbl 
            PriceLbl.Text = "£" + (total / 100m).ToString("0.00");
        }




        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FinaliseBtn_Click(object sender, EventArgs e)
        {
            //srtart string that will be used to display order
            string order = "Your order is:\n\n";
            //each item in basket
            foreach (ProductAddOrder item in basket)
            {
                //if didnt remove the item
                if (item.Quantity != 0)
                {
                    //add name £12.65 x 4 format
                    order += $"{item.Title} {(item.Price / 100m).ToString("0.00")}x{item.Quantity}\n";
                }
            }
            //display total cost at bottom 
            order += $"\nTotal cost £{(total / 100m).ToString("0.00")}\n";
            //and confirm message 
            order += "Do you want to confirm this order?";
            //show dislaog
            DialogResult result = MessageBox.Show(order, "Confirm Order?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //creat the order and reload the panel to update max vlaues
                CreateOrderInDB();
                MessageBox.Show("Success!");
                LoadProductsFlowPanel();
            }
        }

        private void CreateOrderInDB()
        {
            DB db = new();

            // insert a new order and get the last inserted orderID
            //strftie('%s', 'now') gives the unix timestamp in seconds of the curent time
            //SELECT last_insert_rowid(); gives the id of the new order 
            string sql = "INSERT INTO Orders (OrderTime) VALUES (strftime('%s', 'now')); SELECT last_insert_rowid();";
            //execute the query
            SqliteDataReader reader = db.ExecuteQuery(sql);
            
            //read thr result;
            //it will return a value so no if() and only 1 value so no while()
            reader.Read();

            //convert result to int 
            int orderID = Convert.ToInt32(reader["last_insert_rowid()"]);
      
            reader.Close();


            // insetrt each product in the basket into the OrderDetails table
            foreach (ProductAddOrder item in basket)
            {
                //insert values
                sql = $"INSERT INTO OrderDetails (OrderID, ProductID, Quantity) VALUES ({orderID}, {item.ProductID}, {item.Quantity});";
                db.ExecuteQuery(sql);

                //stock = stock - amount of order
                sql = $"UPDATE Products SET ProductStock = ProductStock - {item.Quantity} WHERE ProductID = {item.ProductID};";
                db.ExecuteQuery(sql);
            }


        }
    }
}
