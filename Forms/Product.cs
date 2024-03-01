using Microsoft.Data.Sqlite;
using NEA1.Logic;
using System;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;

namespace NEA1.Forms
{
    public partial class Product : UserControl
    {
        public Product(int productID)
        {
            InitializeComponent();
            //asssign ID for loaddata() 
            this.productID = productID;
            //assign other variables and loag image/name
            LoadData();
        }
        public Product() {}

        //variables 
        public int ProductID { get { return productID; } }
        protected int productID;
        public string Title { get { return title; } }
        protected string title;
        protected byte[] ImageBytes;
        protected string Base64String;
        public int Price { get { return price; } }
        protected int price;
        public int Stock { get { return stock; } }
        protected int stock;
        public int MaxStock { get { return maxStock; } }
        protected int maxStock;

        private void AssignImage()
        {
            //asssign imageBytes
            ImageBytes = Convert.FromBase64String(Base64String);

            //creaste a memoreystream for the bytearray
            using (var ms = new MemoryStream(ImageBytes))
            {
                //load the image data from ther memeory stream into the box
                productImg.Image = Image.FromStream(ms);
            }
        }

        protected void LoadData()
        {
            //define SQL query
            string sql = $"SELECT * FROM Products WHERE ProductID = '{productID}'";

            //create connection to databse and execute query
            DB dB = new();
            SqliteDataReader reader = dB.ExecuteQuery(sql);

            //read resutls from query
            while (reader.Read())
            {
                //assign variables 
                title = (string)reader["ProductName"];
                price = Convert.ToInt32(reader["ProductPrice"]);
                stock = Convert.ToInt32(reader["ProductStock"]);
                maxStock = Convert.ToInt32(reader["ProductMaxStock"]);
                Base64String = (string)reader["ProductImg"];
            }

            //put data in controls 
            AssignImage();
            NameLbl.Text = Title;
        }
    }
}
