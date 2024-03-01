using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using NEA1.Forms.ProductList;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NEA1.Logic
{
    public static class Logic
    {

        public static string HashInput(string input)
        {
            //create instance of the hasher
            SHA256 sha256Hash = SHA256.Create();
            //hash the bytes of the input 
            byte[] HashBytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            //convert the hashed bytes to a string in hexidecimal 
            string Hash = Convert.ToHexString(HashBytes);
            return Hash;
        }
        
        public static string ImageToBase64String(string filepath)
        {
            //convert image to bytes[]
            byte[] imageBytes = System.IO.File.ReadAllBytes(filepath);
            //turn those bytes into a base 654 string
            string base64Image = Convert.ToBase64String(imageBytes);
            return base64Image;
        }

        //this in paramaters mean that is an extension method and can be referered to as rankings.SortDescending();
        //<t> for any type 
        public static List<KeyValuePair<T, int>> SortDescending<T>(this List<KeyValuePair<T, int>> rankings)
        {
            //bubble sort
            //sort the rankings list by value
            //for each result
            for (int i = 0; i < rankings.Count; i++)
            {
                //loop through current item to end (-i-1)
                for (int j = 0; j < rankings.Count - i - 1; j++)
                {
                    //if next value < current val
                    //to sort from high>low
                    if (rankings[j].Value < rankings[j + 1].Value)
                    {
                        //swap the values
                        KeyValuePair<T, int> temp = rankings[j];
                        rankings[j] = rankings[j + 1];
                        rankings[j + 1] = temp;
                    }
                }
            }

            return rankings;
        }

    }
    public class DB
    {
        private Microsoft.Data.Sqlite.SqliteConnection connection;

        //run on class instantiation, creates a connection with the database
        public DB()
        {
            connection = new SqliteConnection($"Data Source={NEA1.Properties.Settings.Default.DBlocation};");
        }
        public DB(string path)
        {
            NEA1.Properties.Settings.Default["DBLocation"] = path;
            NEA1.Properties.Settings.Default.Save();
            connection = new SqliteConnection($"Data Source={path};");
        }



        public SqliteDataReader ExecuteQuery(string query)
        {
            SqliteCommand command = new SqliteCommand(query, connection);
            int attempts = 0;

            //try 5 times to perform the action
            while (attempts < 5)
            {
                try
                {
                    //the connection will be closed when the reader is closed 
                    connection.Open();
                    SqliteDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                    return reader;
                }
                catch (Microsoft.Data.Sqlite.SqliteException e)
                {
                    if (e.SqliteErrorCode == 5 || e.SqliteErrorCode == 6) // busy(5) or Locked(6)
                    {
                        //rollback
                        command.Transaction.Rollback();
                        //wait 1s to ensure other transactions are complete
                        Thread.Sleep(1000);
                        //increase attempts counter 
                        attempts++;
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            //if all attempts fail
            MessageBox.Show("Database in use, please try again");
            return null;
        }
            public object ExecuteScalar(string query)
        {

            SqliteCommand command = new SqliteCommand(query, connection);
            connection.Open();
            object result = command.ExecuteScalar();
            return result;
        }


        //static so that can be called without instancing the class
        static public void createDatabase(string filePath)
        {
            //create file
            File.Create(filePath).Close();

            //runs the SQL query to create the database and stores the filepath so that it is persistent between loads
            using (SqliteConnection connection = new SqliteConnection($"Data Source={filePath};"))
            {
                connection.Open();
                string sql = @" CREATE TABLE ""Products"" (
	""ProductID""	INTEGER,
	""ProductName""	TEXT,
	""ProductPrice""	INTEGER,
	""ProductImg""	BLOB DEFAULT 'iVBORw0KGgoAAAANSUhEUgAAAGQAAABkCAYAAABw4pVUAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAALvSURBVHhe7ZxNTipBFEZRBMJAIYSAQVdlAI1x5sS1sA78IRLdiwswxgABIizAH+7zllQ/eHkLOGW+k5zQMKqb09XtxMp9Y6m6s7MT9OtWq2XX19cWWa1W6ys2X19f66ufNX/P8v9hU1BBYCoITAWBqSAwFQSmgsBUEJgKAlNBYCoITAWBqSAwFQSmgsBUEJgKAlNBYCoITAWBqSAwFQSmgsBUEJgKAlNBYCoITAWBqSAwFQSmgsBUEJgKAlNBYCoITAWBqSAwFQSmgsBUEJgKAlNBYCoITAWBqSAwFQSmggCNQY6Ojqzf769H+yGVKL7O9/f33xEkenh4aLe3t+sRf+68VIJskovbPkX39vYsn8+HIMfHx2GHxEeAf35+foYoVONN8/HxEXaIf+bOzs4sZU9OToKXl5fW6/VClPv7e3t4eLC7u7uwa6je3NzYYDAI6318fLThcGi52WxmKTqdTu3t7c2Wy6UtFgt7enqyq6srazQaVq1WrVKpWK1Ws2azGX4j6mvb39+3g4MDq9frwVzY3wnjW96Zz+fW6XSyd4o/0uI13d3d3b/fwzSJEmM4o9HI2u321oApRInvwGyt63mSxF+K8SX++vpqp6enW8PSg/j6PIh/Zn+ghGl+AePx2M7Pz7eG3Rye6ubjKqx5PU/yKAgMBYGhIDAUBIaCwFAQGAoCQ0FgKAgMBYGhIDAUBIaCwFAQGAoCQ0FgKAgMBYGhIDAUBIaCwFAQGAoCQ0FgKAgMBYGhIDAUBIaCwFAQGAoCQ0FgKAgMBYGhIDAUBIaCwFAQGM/Pz3ZxcbE1LN34P+p+nd1A8Z/vUzSeouP4SQ7x4AC/64rFYhjYr6l6hHK5bKVSKXwPQcI0ieJHa/gRTI6f5BCP1oh3XHbXgY27xIN4mJwPlapxlzgvLy/W7XazEIVCIehDx99ohqM0/gmT/DvEwzibh8/4YPGxEAcmGsP44zXE8N/DNAkTg0wmkyyIH+Tibg5PNoYpl8v2B3BBRz28syidAAAAAElFTkSuQmCC',
	""ProductStock""	INTEGER,
	""ProductMaxStock""	INTEGER,
	PRIMARY KEY(""ProductID"" AUTOINCREMENT)
);

CREATE TABLE ""Orders"" (
	""OrderID""	INTEGER,
	""OrderTime""	INTEGER,
	""OrderStatus""	INTEGER DEFAULT 0,
	PRIMARY KEY(""OrderID"" AUTOINCREMENT)
);


CREATE TABLE ""OrderDetails"" (
	""OrderID""	INTEGER,
	""ProductID""	INTEGER,    
	""Quantity""	INTEGER,
	FOREIGN KEY(""ProductID"") REFERENCES ""Products""(""ProductID""),
	FOREIGN KEY(""OrderID"") REFERENCES ""Orders""(""OrderID""),
	PRIMARY KEY(""OrderID"",""ProductID"")
);

CREATE TABLE ""Users"" (
	""UserID""	TEXT UNIQUE,
	""PasswordHash""	TEXT,
	""AdminStatus""	INTEGER DEFAULT 0,
	PRIMARY KEY(""UserID"")
);

CREATE TABLE ""Pages"" (
	""PageID""	INTEGER,
	""PageName""	TEXT,
	PRIMARY KEY(""PageID"" AUTOINCREMENT)
);

CREATE TABLE ""UserPageAcess"" (
	""UserID""	TEXT,
	""PageID""	INTEGER,
	FOREIGN KEY(""UserID"") REFERENCES ""Users""(""UserID""),
	FOREIGN KEY(""PageID"") REFERENCES ""Pages""(""PageID""),
	PRIMARY KEY(""UserID"",""PageID"")
); 

                

";
                //runs the command to create the tables 
                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }


                //insert the pages into the database;
                sql = @"INSERT INTO Pages (PageName) VALUES
    ('ProductPage'),
    ('CreateOrderPage'),
    ('OrderListPage'),
    ('SalesPage'),
    ('StockPage');
";
                //runs the command to insert the pages
                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }

                //stores the filepath in app setting so that it is persistent between loads.
                NEA1.Properties.Settings.Default["DBLocation"] = filePath;
                NEA1.Properties.Settings.Default.Save();
            }
        }



        public bool ValidDB()
        {
            //all expected tables
            List<string> ExpectedTables = new List<string>() 
            { "Products", "sqlite_sequence", "Orders", "OrderDetails", "Users", "Pages", "UserPageAcess" };

            List<string> ReturnedTables = new List<string>();
            //read returned SQL data

            //return all tables   select tbl_name from sqlite_schema WHERE type = \"table\";
            SqliteDataReader data = this.ExecuteQuery("SELECT name FROM sqlite_master WHERE type='table';");

            while (data.Read())
            {
                //loop through each returned field
                for (int i = 0; i < data.FieldCount; i++)
                {
                    //add tables in selected database to list
                    ReturnedTables.Add((string)data[i]);
                }
            }
            //sort both lists so they ca be compared
            ExpectedTables.Sort();
            ReturnedTables.Sort();
            //if lists are equal then all tables are in the database and therefore it is valid
            if (ReturnedTables.SequenceEqual(ExpectedTables))
            {
                data.Close();
                return true;
            }


            //else return false
            data.Close();
            return false;
        }

        public Dictionary<string, List<string>>  GetUserPagesDictionary()
        {
            Dictionary<string, List<string>> userPages = new Dictionary<string, List<string>>();
            //run the query to return the userid and pages tehy have access too
            string sql = "SELECT Users.userID, Pages.PageName"
                        + " FROM Users"
                        + " JOIN UserPageAcess ON Users.userID = UserPageAcess.UserID"
                        + " JOIN Pages ON UserPageAcess.PageID = Pages.PageID;";
            SqliteDataReader reader = ExecuteQuery(sql);


            //read the data
            while (reader.Read())
            {
                //get Selected records UserID and PageName
                string userID = reader.GetString(0);
                string pageName = reader.GetString(1);

                //if UserID in dictionary, add pagename to dictionarys list of pagenames
                if (userPages.ContainsKey(userID))
                {
                    userPages[userID].Add(pageName);
                }
                else//otherwise 
                { //creatennew list of pagenames for the USerID and add current 
                    userPages[userID] = new List<string> { pageName };
                }
            }
            reader.Close();

            return userPages;
        }
   }
}