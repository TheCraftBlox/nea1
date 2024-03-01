using Microsoft.Data.Sqlite;
using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static NEA1.Logic.Logic;

namespace NEA1.Forms.ProductList
{
    internal class ProductMethods
    {
        public ProductMethods(FlowLayoutPanel _ProductsFlowPanel)
        {
            //define variables
            products = new();
            ProductsFlowPanel = _ProductsFlowPanel;
        }

        private List<ProductDetails> products;
        private FlowLayoutPanel ProductsFlowPanel;

        public void Add(object sender, EventArgs e)
        {
            //create dialog
            AddProduct newProduct = new AddProduct();
            //show dialog and collect result
            DialogResult dialogResult = newProduct.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                //deinfe variables 
                string name = newProduct.ChosenProductName;
                int price = newProduct.ProductPrice;
                int stock = newProduct.ProductStock;
                int maxStock = newProduct.ProductMaxStock;
                string image = newProduct.Base64Image;
                string sql;
                //handle image being not selected
                if (image == null)
                {
                    // If image is null, omit it from the insert query
                    sql = $"INSERT INTO Products (ProductName, ProductPrice, ProductStock, ProductMaxStock) VALUES ('{name}', {price}, {stock}, {maxStock});";
                }
                else
                {
                    // If image is not null, include it in the insert query
                    sql = $"INSERT INTO Products (ProductName, ProductPrice, ProductImg, ProductStock, ProductMaxStock) VALUES ('{name}', {price}, '{image}', {stock}, {maxStock});";
                }

                //execute the query
                DB dB = new();
                dB.ExecuteQuery(sql);

                //reload panel
                LoadProductsFlowPanel();
            }
        }

        public void LoadProductsFlowPanel()
        {
            //reset prod8ucts list to prevent duplicates.
            products.Clear();

            //fetch ids of every product.
            string sql = " SELECT ProductID FROM Products;";
            //access databsae and execute query
            DB db = new();
            SqliteDataReader reader = db.ExecuteQuery(sql);

            //read results and create new instances of Product for each
            while (reader.Read())
            {
                int ID = Convert.ToInt32(reader["ProductID"]);
                ProductDetails product = new ProductDetails(ID);
                //assign event for product deletion
                product.Reload += Product_Reload;
                products.Add(product);
            }
            reader.Close();

            //reset flowpanel to prevent duplicates.
            ProductsFlowPanel.Controls.Clear();

            //add usercontrol product to flowpanel 
            foreach (ProductDetails product in products)
            {
                ProductsFlowPanel.Controls.Add(product);
            }
        }
        public void LoadProductsFlowPanel(int[] productIDs)
        {
            //reset prod8ucts list to prevent duplicates.
            products.Clear();

            //loop through productIDs and create new instances of Product for each
            foreach (int productID in productIDs)
            {
                ProductDetails product = new ProductDetails(productID);
                //assign event for product deletion
                product.Reload += Product_Reload;
                products.Add(product);
            }

            //reset flowpanel to prevent duplicates.
            ProductsFlowPanel.Controls.Clear();

            //add usercontrol product to flowpanel 
            foreach (ProductDetails product in products)
            {
                ProductsFlowPanel.Controls.Add(product);
            }
        }

        private void Product_Reload(object sender, EventArgs e)
        {
            //ifn producxt deleted then reload panel
            LoadProductsFlowPanel();
        }


        public static int[] ResultsRank(string query)
        {
            //get results from the database
            Dictionary<string, int> SearchResults = DBresults(query);

            //list to associate result with its score
            //using list as it has order which is useful 
            //key is productname value is score
            List<KeyValuePair<int, int>> rankings = new();

            //calculate its score

            for (int i = 0; i < SearchResults.Count; i++)
            {
                string result = SearchResults.ElementAt(i).Key;
                int resultID = SearchResults.ElementAt(i).Value;
                int score = 0;

                //if it starts with the query
                //want to prioritise results that it starts with as user most likely to start searching 
                //from the start of a productname
                if (result.StartsWith(query))
                {
                    score += 50;
                }
                //if word
                //user most likely to type a word and then hit enter,
                //rather than leaving the word half-typed
                if (result.Contains($" {query} ") || result.EndsWith($" {query}"))
                {
                    score += 50;
                }

                // amount of the query that is the result, 
                //prioritise results that are closest of final (eg. search"burger" prioritise hamburger over cheeseburger)
                int percentageWord = Convert.ToInt32(100m * ((decimal)query.Length / (decimal)result.Length));
                score += percentageWord;

                //add the final score to the list
                rankings.Add(new KeyValuePair<int, int>(resultID, score));
            }

            //sort rankings by score, descending
            rankings.SortDescending();


            //create string[] for returning the skkorted results
            int[] RankedResults = new int[SearchResults.Count];
            for (int i = 0; i < rankings.Count; i++)
            {
                //add name of the product to string[]
                RankedResults[i] = rankings[i].Key;
            }

            // Create a dictionary to store ProductName and ProductID
            Dictionary<string, int> productDict = new Dictionary<string, int>();
            DB db = new();

            //get all prodctname and prodctIds
            SqliteDataReader reader = db.ExecuteQuery("SELECT ProductName, ProductID FROM Products;");
            while (reader.Read())
            {
                if (reader["ProductName"] != DBNull.Value && reader["ProductID"] != DBNull.Value)
                {
                    //add them to dictionary
                    string productName = (string)reader["ProductName"];
                    int productID = Convert.ToInt32(reader["ProductID"]);
                    productDict[productName] = productID;
                }
            }



            return RankedResults;

        }


        private static Dictionary<string, int> DBresults(string query)
        {

            //define sql
            //using like as 
            string sql = $"SELECT ProductName,ProductID FROM Products WHERE ProductName LIKE '%{query}%';";

            //create new instance of DB 
            //and dict as order isnt needed so faster loookup time is benificial 
            Logic.DB db = new();
            Dictionary<string, int> resultsDict = new();
            //execute the query
            SqliteDataReader reader = db.ExecuteQuery(sql);




            //for each line in resutls
            while (reader.Read())
            {
                string resultValue = (string)reader["ProductName"];
                int resultKey = Convert.ToInt32(reader["ProductID"]);
                resultsDict.Add(resultValue, resultKey);
            }


            return resultsDict;
        }


    }


}

