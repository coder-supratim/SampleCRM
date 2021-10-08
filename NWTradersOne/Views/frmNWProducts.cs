using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NWTraders.Controller;
using System.Diagnostics;

namespace NWTraders.Views
{
    public partial class frmNWProducts : Form
    {

        public NorthwindEntities nwEntities = new NorthwindEntities();

       

        public frmNWProducts()
        {
            InitializeComponent();
        }

        
        private void frmNWProducts_Load(object sender, EventArgs ev)
        {
           
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
          

            // Load the DGV with all the customers.
            LoadDGV(nwEntities.Products);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormatDGV()
        {
            // First clear all the rows in the DGV.
            dgvProducts.Rows.Clear();

            // This is the number of fields in the Products table - we will create that many columns in the DGV.
            dgvProducts.ColumnCount = 6;

            dgvProducts.Columns[0].Name = "ProductID";
            dgvProducts.Columns[0].Visible = false; /// The primary key is not made visible per best practice.

            dgvProducts.Columns[1].Name = "ProductName";
            dgvProducts.Columns[1].Width = 225;
            dgvProducts.Columns[1].HeaderText = "Product Name";

            dgvProducts.Columns[2].Name = "SellerEmployee";
            dgvProducts.Columns[2].Width = 500;
            dgvProducts.Columns[2].HeaderText = "Seller Employees";

            dgvProducts.Columns[3].Name = "TotalSales";
            dgvProducts.Columns[3].Width = 150;
            dgvProducts.Columns[3].HeaderText = "Total Sales";

            dgvProducts.Columns[4].Name = "Region";
            dgvProducts.Columns[4].Width = 400;
            dgvProducts.Columns[4].HeaderText = "Region of Sales";

            dgvProducts.Columns[5].Name = "Discontinued";
            dgvProducts.Columns[5].Width = 125;
            dgvProducts.Columns[5].HeaderText = "Discontinued";

           



        }

        private string SellerEmployee(ICollection<Order_Detail> Order_Details)
        {

            string sellerEmployee = "";
            foreach (Order_Detail od in Order_Details)
            {


                var queryResults =
                (from e in nwEntities.Employees
                 join o in nwEntities.Orders on e.EmployeeID equals o.EmployeeID
                 where o.OrderID == od.OrderID
                 select new { FullName = e.FirstName + " " + e.LastName }).Distinct();

                foreach (var item in queryResults)
                {
                    if (string.IsNullOrEmpty(item.FullName))
                    {
                        sellerEmployee = string.Concat(sellerEmployee, item.FullName, " ,");
                    }
                }
            }
            Debug.WriteLine($"Employee Names: {sellerEmployee}");
            return sellerEmployee;
        }

        private string SalesRegions(ICollection<Order_Detail> Order_Details)
        {

            string salesRegion = "";
            foreach (Order_Detail od in Order_Details)
            {
                var queryResults =
                (from o in nwEntities.Orders
                 where o.OrderID == od.OrderID
                 select new {o.ShipRegion}).Distinct();

                foreach (var item in queryResults)
                {
                    if (string.IsNullOrEmpty(item.ShipRegion))
                    {
                        salesRegion = string.Concat(salesRegion, item.ShipRegion, " ,");
                    }
                    
                }
            }
            Debug.WriteLine($"Regions: {salesRegion}");
            return salesRegion;
        }

        public void LoadDGV(IEnumerable<Product> products)
        {
            // If there are no customers, do nothing and return from the function.
            if (products == null) return;

            // The following lines of code will run only if the list of customer objects is not null - in other words, if there are customers.

            // If there are no columns in the DGV, then it has not been initialized
            //  Initialize and format the DGV using the function we wrote, before adding anything.
            if (dgvProducts.RowCount == 0)
                FormatDGV();


            // First we wil clear the DGV Rows if any exist.
            dgvProducts.Rows.Clear();

            // Go through every customer in the customer collection and 
            // add it as a row in the dgv
            foreach (Product prod in products)
            {
                dgvProducts.Rows.Add(
                    prod.ProductID, // The ID will not actually be shown since it is given to a column that has the Visible property set to False.
                    prod.ProductName,
                    SellerEmployee(prod.Order_Details),
                    prod.TotalSales,
                    SalesRegions(prod.Order_Details),
                    prod.Discontinued
                    );
            }

            // Clear any selections that may have been made.
            dgvProducts.ClearSelection();

            // As a beginning default view, we can sort the dgv in alphabetical order of Company name (Field 1)
            dgvProducts.Sort(dgvProducts.Columns[1], ListSortDirection.Ascending);

        }


       
    }
}
