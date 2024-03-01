/*using LiveCharts.Wpf.Charts.Base;
using LiveCharts.Wpf;*/
using Microsoft.Data.Sqlite;
using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NEA1.Forms.Sales
{
    public partial class Sales : UserControl
    {
        public Sales()
        {
            InitializeComponent();

            //create products combox box 
            LoadProducts();
        }


        private void LoadProducts()
        {
            string sql = "SELECT ProductName,ProductID FROM Products;";
            //execute query
            DB db = new();
            SqliteDataReader reader = db.ExecuteQuery(sql);
            //read results
            while (reader.Read())
            {
                //get values of product
                int ProductID = Convert.ToInt32(reader["ProductID"]);
                string ProductName = (string)reader["ProductName"];
                //add new instance of combobox item to combo box
                //using combobox item so that can retreive the ProductID
                ProductComboBox.Items.Add(new ComboBoxItem { ProductID = ProductID, ProductName = ProductName });
            }
            //disable load button as no item selected yet
            LoadBt2.Enabled = false;
        }

        private void LoadBt2_Click(object sender, EventArgs e)
        {
            if (ProductComboBox.SelectedItem == null)
            {
                LoadBt2.Enabled = false;
                return; 
            }

            //cast selcted value to combobox item
            ComboBoxItem comboBoxItem = ProductComboBox.SelectedItem as ComboBoxItem;
            //for acceesssot the property ProductID
            int ProductID = comboBoxItem.ProductID;

            //get data for ProductSales Graph
            List<KeyValuePair<long, int>> values = ProductSalesFetchData(ProductID);
            //create chart with values
            CreateProductOrderChart(values);
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadBtn1_Click(object sender, EventArgs e)
        {
            //get dataa for revenue graph
            List<KeyValuePair<long, int>> values = RevenueFetchData(fromDateTimePicker.Value, toDateTimePicker.Value);
            //create graph with values
            CreateRevenueChart(values);
        }

        private List<KeyValuePair<long, int>> RevenueFetchData(DateTime from, DateTime to)
        {
            //defie sql
            // calc revenue in sql with sum (price*quantity) as total cost
            //joing tables to access values
            //orders between from date to to data 
            //grouped by orderID (each order is one total)
            //order in time order
            string sql = "SELECT Orders.OrderTime, SUM(Products.ProductPrice * OrderDetails.Quantity) as TotalCost " +
    " FROM Orders " +
    " JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID " +
    " JOIN Products ON OrderDetails.ProductID = Products.ProductID " +
    $" WHERE Orders.OrderTime BETWEEN {new DateTimeOffset(from).ToUnixTimeSeconds()} AND {new DateTimeOffset(to).ToUnixTimeSeconds()}" +
    " GROUP BY Orders.OrderID " +
    " ORDER BY Orders.OrderTime ; ";

            //creater db + execute SQL
            DB db = new();
            SqliteDataReader reader = db.ExecuteQuery(sql);
            //List as need to iterate through in order
            List<KeyValuePair<long, int>> values = new List<KeyValuePair<long, int>>();

            //reader results
            while (reader.Read())
            {
                //aassgn values to variables
                long orderTime = Convert.ToInt64(reader["OrderTime"]);
                int orderCost = Convert.ToInt32(reader["TotalCost"]);
                //add to list
                values.Add(new KeyValuePair<long, int>(orderTime, orderCost));
            }

            return values;
        }

        private List<KeyValuePair<long, int>> ProductSalesFetchData(int ProductID)
        {    //define sql
            //returning all times product Id was orered, and how many was ordered 
            string sql = @"
    SELECT Orders.OrderTime, OrderDetails.Quantity
    FROM Orders
    JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID
    JOIN Products ON OrderDetails.ProductID = Products.ProductID" +
   $" WHERE Products.ProductID = {ProductID}" +
    @" GROUP BY Orders.OrderID
    ORDER BY Orders.OrderTime;";

            //create db  + execute SQL
            DB db = new();
            SqliteDataReader reader = db.ExecuteQuery(sql);
            //list as need to iterate through in order
            List<KeyValuePair<long, int>> values = new();

            //reader results
            while (reader.Read())
            {
                //assign variables
                long orderTime = Convert.ToInt64(reader["OrderTime"]);
                int quantity = Convert.ToInt32(reader["Quantity"]);
                //ass to list
                values.Add(new KeyValuePair<long, int>(orderTime, quantity));
            }
            return values;
        }

        private void CreateProductOrderChart(List<KeyValuePair<long, int>> values)
        {
            // Create a new chart
            Chart chart = new Chart();

            //clear any prev opened chart 
            ChartPanel2.Controls.Clear();
            //set to fill all available sapace
             chart.Dock = DockStyle.Fill;
            //add to panel
            ChartPanel2.Controls.Add(chart);

            //create the chart
            CreateBarChart(values, "Product Sakes", "#", chart);
        }
        private void CreateRevenueChart(List<KeyValuePair<long, int>> values)
        {
            // Create a new chart
            Chart chart = new Chart();

            //clear any previ opened chart
            ChartPanel.Controls.Clear();
            //set to fill all available space
            chart.Dock = DockStyle.Fill;
            //add to panel
            ChartPanel.Controls.Add(chart);
            //create the chart
            CreateBarChart(values, "Revenue", "£#", chart);
        }


        private void CreateBarChart(List<KeyValuePair<long, int>> values, string SeriesName, string YFormat, Chart chart)
        {
            //create a new series and add data points
            Series series = new Series(SeriesName);
            series.ChartType = SeriesChartType.Column;

            foreach (var kvp in values)
            {
                //convert unix timestamp to datetime
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTime = dateTime.AddSeconds(kvp.Key).ToLocalTime();
               
                //round to day
                //otherwise it'dc be all reaslly low at random times
                dateTime = dateTime.Date;

                //add data to graph 
                series.Points.AddXY(dateTime, kvp.Value);
            }

            chart.Series.Add(series);

            //create tje chars area
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            //formatting
            chartArea.AxisX.LabelStyle.Format = "dd-MM-yyyy";
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.LabelStyle.Format = YFormat;
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //is user has selecteed a combobox 
            //enable the button
            LoadBt2.Enabled = true;

        }
    }

    class ComboBoxItem
    {
        public string ProductName { get; set; }
        
        public int ProductID { get; set; }  
        public override string ToString()
        {
            return ProductName; 
        }
    }

}
