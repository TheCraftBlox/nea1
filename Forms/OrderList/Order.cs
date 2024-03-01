using Microsoft.Data.Sqlite;
using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NEA1.Forms.OrderList
{
    public partial class Order : UserControl
    {
        public Order(int OrderID)
        {
            InitializeComponent();

            //join product orders and orderdetails to get the product name and quantity of the orderID
            //also ordertime 
            string sql = "SELECT  Orders.OrderTime, Products.ProductName, OrderDetails.Quantity " +
                " FROM Orders" +
                " JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID" +
                " JOIN Products ON OrderDetails.ProductID = Products.ProductID" +
                $" WHERE Orders.OrderStatus = 0 AND Orders.OrderID = {OrderID};";

            //new instance of database
            DB dB = new();
            //execute the command
            SqliteDataReader reader = dB.ExecuteQuery(sql);

            // Create a List to hold the results
            //not dict as productname is not unique and bc easy looping 
            List<KeyValuePair<string, int>> OrderedProducts = new();

            //long to avoid y2k38;
            long OrderTime = 0;

            //loop through results
            while (reader.Read())
            {
                OrderTime = Convert.ToInt64(reader["OrderTime"]);//is reassigned everytime be always equal 
                string productName = (string)reader["ProductName"];
                int quantity = Convert.ToInt32(reader["Quantity"]);

                //add to list
                OrderedProducts.Add(new KeyValuePair<string, int>(productName, quantity));
            }
            // Close the reader when done
            reader.Close();

            //CONVERT unix timestamp to string & diplay it 
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(OrderTime);
            string dateTimeString = dateTimeOffset.ToString("HH:mm:ss dd-MM-yy ");
            TimeLbl.Text = dateTimeString;


            //start to define list
            string order = string.Empty;

            //Show Products ordered and add name + quantity to string
            foreach(var item in OrderedProducts)
            {
                order += $"{item.Value}x{item.Key}\n";
            }
            //assign it to list
            OrderLbl.Text = order;

            //pass paramater for access outside of form (eventhandler)
            orderID = OrderID;
        }

        public event EventHandler Confirm;
        private int orderID;
        public int OrderID { get { return orderID; }  }
        private void Order_Load(object sender, EventArgs e)
        {

        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Confirm.Invoke(this, e);
        }
    }
}
