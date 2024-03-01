using Microsoft.Data.Sqlite;
using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA1.Forms.Stock
{
    public partial class StockUpdate : Form
    {
        public StockUpdate(int ProductID)
        {
            InitializeComponent();
            //get values have have in box by default
            string sql = $"SELECT ProductStock,ProductMaxStock FROM Products WHERE ProductID = {ProductID}";

            //new db and execute query
            DB dB = new DB();
            SqliteDataReader reader = dB.ExecuteQuery(sql);

            //get result
            while (reader.Read())
            {
                //assing properties to results
                StockNumUpDown.Value = Convert.ToDecimal(reader["ProductStock"]);
                MaxStockNumUpDown.Value = Convert.ToDecimal(reader["ProductMaxStock"]);
            }
            //close reader 
            reader.Close();

        }
        public int Stock { get { return Convert.ToInt32(StockNumUpDown.Value); } }
        public int MaxStock { get { return Convert.ToInt32(MaxStockNumUpDown.Value); } }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //cant have 0 maxstock else  div 0 error for percents 
            if (MaxStock == 0)
            {
                MessageBox.Show("MaxStock must be > 0", "Warning");
                System.Media.SystemSounds.Hand.Play();

            }
            else
            {
                //set result to ok and close form s
                DialogResult = DialogResult.OK; ;
                this.Close();
            }
        }
    }
}
