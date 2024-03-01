using Microsoft.Data.Sqlite;
using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NEA1.Forms.OrderList
{
    public partial class OrderList : UserControl
    {
        public OrderList()
        {
            InitializeComponent();
            //create instances of variables 
            Orders = new();
            ordersShown = 20;

            //so theat non null error here;:
            loadOrders();
        }

        List<Order> Orders;
        int ordersShown;


        private void loadOrders()
        {
            //reset list
            Orders.Clear();

            // get {limit} most recent active orders  
            string sql = "SELECT OrderID From Orders "
+ "WHERE OrderStatus = 0 "
+ " ORDER BY OrderTime DESC "
+ $" LIMIT {ordersShown};";

            //creaste instance of databse
            DB db = new();
            //execute query and store result
            SqliteDataReader reader = db.ExecuteQuery(sql);

            //loop through orders
            while (reader.Read())
            {
                int orderID = Convert.ToInt32(reader["OrderID"]);
                //create new Order Usercontrol
                Order order = new Order(orderID);
                //assign eventhandler
                order.Confirm += Order_Confirm;
                //add to list
                Orders.Add(order);
            }
            // close reader as done
            reader.Close();

            //clear all values from panel 
            OrdersFlowPanel.Controls.Clear();

            // add values to panel 
            foreach (Order order in Orders)
            {
                OrdersFlowPanel.Controls.Add(order);
            }

            //get amount of oders ot be done
            sql = "SELECT count() FROM Orders WHERE OrderStatus = 0;";

            //search the db
            reader = db.ExecuteQuery(sql);

            //wil always return 1 value so no ned to loop through or if 
            reader.Read();
            //assign value to variable
            int OrdersTotal = Convert.ToInt32(reader["count()"]);
            //close reader as done
            reader.Close();

            //if there is more unshown orders, load more btn
            if (ordersShown < OrdersTotal)
            {
                CreateLoadMoreBtn();
            }
          
                
            
            

        }
        private void CreateLoadMoreBtn()
        {
           //create new button and assign its properties
            Button LoadMoreBtn = new Button();
            LoadMoreBtn.Size = new System.Drawing.Size(212, 125);
            LoadMoreBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            LoadMoreBtn.Text = "Load 20 More";
            LoadMoreBtn.Click += LoadMoreBtn_Click;

            //add it to the form
            OrdersFlowPanel.Controls.Add(LoadMoreBtn);
        }

        private void LoadMoreBtn_Click(object sender, EventArgs e)
        {
            //increase the max amount shown
            ordersShown += 20;
            //reload panel
            loadOrders();
        }

        private void Order_Confirm(object sender, EventArgs e)
        {
            //cast to order
            Order order = sender as Order;

            string sql = $"UPDATE Orders SET OrderStatus = 1 WHERE OrderID = {order.OrderID};";


            DB db = new DB();
            db.ExecuteQuery(sql);

            loadOrders();

        }
    }
}
