using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Query.Internal;
using NEA1.Forms.CreateOrder;
using NEA1.Forms.OrderList;
using NEA1.Forms.ProductList;
using NEA1.Forms.Sales;
using NEA1.Forms.Settings;
using NEA1.Forms.Stock;
using NEA1.Logic;
using System;
using System.Windows.Forms;

namespace NEA1
{
    public partial class MainMenu : Form
    {
        public MainMenu(string _user)
        {
            InitializeComponent();

            //assign value
            user = _user;


            //get pagename that is accessible for user
            string sql = $"SELECT PageName FROM Pages WHERE PageID IN (SELECT PageID FROM UserPageAcess WHERE UserID = '{_user}');";

            //open daatabase and execute query
            DB dB = new DB();
            SqliteDataReader reader = dB.ExecuteQuery(sql);

            //loop through records in db
            while (reader.Read())
            {
                //get the record value for pagename in the results
                string pageName = (string)reader["PageName"];

                //for the current page, add a toolstrip menu icon 
                //assign its click event to the event previously created
                //the add it to display on the menustrip itself
                switch (pageName)
                {
                    case "ProductPage":
                        productListToolStripMenuItem = new ToolStripMenuItem("&Products");
                        productListToolStripMenuItem.Click += productListToolStripMenuItem_Click;
                        menuStrip.Items.Add(productListToolStripMenuItem);
                        break;
                    case "CreateOrderPage":
                        createOrderToolStripMenuItem = new ToolStripMenuItem("&Create Order");
                        createOrderToolStripMenuItem.Click += createOrderToolStripMenuItem_Click;
                        menuStrip.Items.Add(createOrderToolStripMenuItem);
                        break;
                    case "OrderListPage":
                        OrderListToolStripMenuItem = new ToolStripMenuItem("View &Orders");
                        OrderListToolStripMenuItem.Click += OrderListToolStripMenuItem_Click;
                        menuStrip.Items.Add(OrderListToolStripMenuItem);
                        break;
                    case "SalesPage":
                        salesToolStripMenuItem = new ToolStripMenuItem("Sa&les");
                        salesToolStripMenuItem.Click += salesToolStripMenuItem_Click;
                        menuStrip.Items.Add(salesToolStripMenuItem);
                        break;
                    case "StockPage":
                        stockToolStripMenuItem = new ToolStripMenuItem("S&tock");
                        stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
                        menuStrip.Items.Add(stockToolStripMenuItem);
                        break;
                }
            }

            //create the settting stoolstrip Menu Icon no matter what it is     
            settingsToolStripMenuItem = new ToolStripMenuItem("&Settings");
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            menuStrip.Items.Add(settingsToolStripMenuItem);
            settingsToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;

        }
        //define variables.
        private UserControl currentUserControl;
        private ToolStripMenuItem productListToolStripMenuItem;
        private ToolStripMenuItem createOrderToolStripMenuItem;
        private ToolStripMenuItem OrderListToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private string user;


        private void CreateUserControl(System.Windows.Forms.UserControl control)
        {
            //if there is already a page on the screen
            if (currentUserControl != null)
            {
                //get rid of it
                this.Controls.Remove(currentUserControl);

                //remove its selection from the toolStrip;
                UncheckToolStripMenuItem();
            }

            //make it fill the screen
            control.Dock = DockStyle.Fill;
            //add the usercontrol to the mainmemu form
            this.Controls.Add(control);
            control.BringToFront();

            //set the current usercontrol so it can be removede later
            currentUserControl = control;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Create a new instance of the CreateOrder user control
            CreateUserControl(new CreateOrder());

            //make the item selected in the menuBar
            createOrderToolStripMenuItem.Checked = true;
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // Create a new instance of the ProductList user control
            CreateUserControl(new ProductList());

            //make the item selected in the menuBar
            productListToolStripMenuItem.Checked = true;
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Create a new instance of the Sales user control
            CreateUserControl(new Sales());

            //make the item selected in the menuBar
            salesToolStripMenuItem.Checked = true;
        }


        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            // Create a new instance of the Stock user control
            CreateUserControl(new Stock());

            //make the item selected in the menuBar
            stockToolStripMenuItem.Checked = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

            // Create a new instance of the Settings user control
            CreateUserControl(new Settings(user));

            //make the item selected in the menuBar
            settingsToolStripMenuItem.Checked = true;
        }

        private void OrderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            // Create a new instance of the OrderList user control
            CreateUserControl(new OrderList());

            //make the item selected in the menuBar
            OrderListToolStripMenuItem.Checked = true;
        }
        

        private void UncheckToolStripMenuItem()
        {

            //loop through each toolstrip menu item
            foreach (ToolStripMenuItem menuItem in menuStrip.Items)
            {
                //uncheck it
                //this prevents a situation where multiple could be selected at once 
                //as a simple toolstripMenuItem currentToolStripMenuItem could be broken.
                menuItem.Checked = false;
            }
        }

    }
}
