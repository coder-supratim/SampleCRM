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
using static System.Convert;

namespace NWTraders.Views
{
    public partial class frmNWProducts : Form
    {

        public NorthwindEntities nwEntities = new NorthwindEntities();

        private Product selectedProduct;
        private Supplier selectedSupplier;



        public frmNWProducts()
        {
            InitializeComponent();
        }

        
        private void frmNWProducts_Load(object sender, EventArgs ev)
        {
           
        }

        public List<String> AllRegions()
        {
            // From the customers table, 
            // where the Region is not null or empty, 
            // select every Region
            // keep only the distinct ones 
            // then convert it to a list.
            List<String> allRegions = new List<string>();
            allRegions = nwEntities.Customers.
                Where(c => string.IsNullOrEmpty(c.Region) == false).
                Select(c => c.Region).
                Distinct().
                ToList();

            return allRegions;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            cmbSalesRegion.DataSource = AllRegions();

            // Load the DGV with all the products.
            LoadDGV(nwEntities.Products);
            LoadSupplierDGV(nwEntities.Suppliers);
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
            dgvProducts.Columns[2].Width = 300;
            dgvProducts.Columns[2].HeaderText = "Seller Employees";

            dgvProducts.Columns[3].Name = "TotalSales";
            dgvProducts.Columns[3].Width = 150;
            dgvProducts.Columns[3].HeaderText = "Total Sales";

            dgvProducts.Columns[4].Name = "Region";
            dgvProducts.Columns[4].Width = 200;
            dgvProducts.Columns[4].HeaderText = "Region of Sales";

            dgvProducts.Columns[5].Name = "Discontinued";
            dgvProducts.Columns[5].Width = 125;
            dgvProducts.Columns[5].HeaderText = "Discontinued";

           



        }

        public void FormatSupplierDGV()
        {
            // First clear all the rows in the DGV.
            dgvSuppliers.Rows.Clear();

            // This is the number of fields in the Products table - we will create that many columns in the DGV.
            dgvSuppliers.ColumnCount = 5;

            dgvSuppliers.Columns[0].Name = "SupplierID";
            dgvSuppliers.Columns[0].Visible = false; /// The primary key is not made visible per best practice.

            dgvSuppliers.Columns[1].Name = "SupplierName";
            dgvSuppliers.Columns[1].Width = 225;
            dgvSuppliers.Columns[1].HeaderText = "Supplier Name";

            dgvSuppliers.Columns[2].Name = "SupplierContact";
            dgvSuppliers.Columns[2].Width = 300;
            dgvSuppliers.Columns[2].HeaderText = "Seller Contact";

            dgvSuppliers.Columns[3].Name = "Region";
            dgvSuppliers.Columns[3].Width = 100;
            dgvSuppliers.Columns[3].HeaderText = "Region";

            dgvSuppliers.Columns[4].Name = "City";
            dgvSuppliers.Columns[4].Width = 200;
            dgvSuppliers.Columns[4].HeaderText = "City";

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
                    if (!string.IsNullOrEmpty(item.FullName))
                    {
                        sellerEmployee = string.Concat(sellerEmployee, item.FullName, " ,");
                    }
                }
            }
           // Debug.WriteLine($"Employee Names: {sellerEmployee}");
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
                    if (!string.IsNullOrEmpty(item.ShipRegion))
                    {
                        salesRegion = string.Concat(salesRegion, item.ShipRegion, " ,");
                    }
                    
                }
            }
            //Debug.WriteLine($"Regions: {salesRegion}");
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
                   prod.TotalSales.ToString("C"),
                    SalesRegions(prod.Order_Details),
                    prod.Discontinued
                    );
            }

            // Clear any selections that may have been made.
            dgvProducts.ClearSelection();

            // As a beginning default view, we can sort the dgv in alphabetical order of Company name (Field 1)
            dgvProducts.Sort(dgvProducts.Columns[1], ListSortDirection.Ascending);

        }


        public void LoadSupplierDGV(IEnumerable<Supplier> suppliers)
        {
            // If there are no suppliers, do nothing and return from the function.
            if (suppliers == null) return;

            // The following lines of code will run only if the list of customer objects is not null - in other words, if there are customers.

            // If there are no columns in the DGV, then it has not been initialized
            //  Initialize and format the DGV using the function we wrote, before adding anything.
            if (dgvSuppliers.RowCount == 0)
                FormatSupplierDGV();


            // First we wil clear the DGV Rows if any exist.
            dgvSuppliers.Rows.Clear();

            // Go through every customer in the customer collection and 
            // add it as a row in the dgv
            foreach (Supplier sup in suppliers)
            {
                dgvSuppliers.Rows.Add(
                    sup.SupplierID, // The ID will not actually be shown since it is given to a column that has the Visible property set to False.
                    sup.CompanyName,
                    sup.ContactName,
                    sup.Region,
                    sup.City
                   
                    );
            }

            // Clear any selections that may have been made.
            dgvSuppliers.ClearSelection();

            // As a beginning default view, we can sort the dgv in alphabetical order of Company name (Field 1)
            dgvSuppliers.Sort(dgvSuppliers.Columns[1], ListSortDirection.Ascending);

        }

        private void CmbSalesRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSalesRegion.SelectedIndex != -1)
            {
                IEnumerable<Product> productsToShow = SearchByRegion(cmbSalesRegion.SelectedItem.ToString().Trim());
                LoadDGV(productsToShow);

            }
        }
        public IEnumerable<Product> SearchByRegion(string regionName)

        {
            // If the City string is nothing or empty, return all the products.
            if (string.IsNullOrEmpty(regionName))
                return nwEntities.Products;

            IEnumerable<Product> foundProducts =
                nwEntities.Products.
                Where(p => p.Supplier.Region.Contains(regionName)).
                Select(p => p).
                OrderBy(p => p.ProductName);

            return foundProducts;
        }

        private void TxtProductName_TextChanged(object sender, EventArgs e)
        {
            // Get the search text the user types in:
            string productSearchString = txtProductName.Text.Trim();

            // pass the search string to the search function.
            IEnumerable<Product> foundProducts = SearchByProductName(productSearchString);
            LoadDGV(foundProducts);


        }

        private void TxtTotalSales_TextChanged(object sender, EventArgs e)
        {
            // Get the search text the user types in:
            string productSearchString = txtProductName.Text.Trim();

            // pass the search string to the search function.
            IEnumerable<Product> foundProducts = SearchByTotalSales(productSearchString);
            LoadDGV(foundProducts);


        }

        public IEnumerable<Product> SearchByProductName(string productName)
        {
            // If the City string is nothing or empty, return all the products.
            if (string.IsNullOrEmpty(productName))
                return nwEntities.Products;

            IEnumerable<Product> foundProducts =
                nwEntities.Products.
                Where(p => p.ProductName.Contains(productName)).
                Select(p => p).
                OrderBy(p => p.ProductName);

            return foundProducts;
        }
        public IEnumerable<Product> SearchByTotalSales(string totalSales)
        {
            // If the City string is nothing or empty, return all the products.
            if (string.IsNullOrEmpty(totalSales))
                return nwEntities.Products;

            IEnumerable<Product> foundProducts =
                nwEntities.Products.
                Where(p => p.TotalSales == ToInt32(totalSales)).
                Select(p => p).
                OrderBy(p => p.ProductName);

            return foundProducts;
        }

        private void chkDiscontinued_CheckedChanged(object sender, EventArgs e)
        {
            IEnumerable<Product> foundProducts =
               nwEntities.Products.
               Where(p => p.Discontinued == false).
               Select(p => p).
               OrderBy(p => p.ProductName);

            LoadDGV(foundProducts);
        }
        private void DgvProduct_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = -1;

            // When a row in the DGV is selected, you can find which row index is selected.
            // Generally, you can zero or select multiple rows in a dgv.
            // If a row is selected, then the SelectedRowsCollection has a count of > 0 
            //and we can get the index of the selected row[0] - which is the first (and in our case the only row) selected.
            if (dgvProducts.SelectedRows.Count > 0)
                selectedRowIndex = dgvProducts.SelectedRows[0].Index;

            // This code was having an issue in the assignment sample project, not selecting the first record of customer data. Fixed it. 
            if (selectedRowIndex > -1)
            {

                // Get the value of the ProductID field in the selected Row.
                int selectedProductID = ToInt32(dgvProducts.Rows[selectedRowIndex].Cells["ProductID"].Value.ToString());

                // Now I have the primary key - I can find the selected customer object.
                // Even though there will be only one product, 
                selectedProduct = nwEntities.Products.
                    Where(p => p.ProductID == selectedProductID).
                    Select(p => p).FirstOrDefault();

                if (selectedProduct != null)
                {
                    this.rtfProductDetail.Text = selectedProduct.Product_Information;
                }

            }

        }

        private void DgvSupplier_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = -1;

            // When a row in the DGV is selected, you can find which row index is selected.
            // Generally, you can zero or select multiple rows in a dgv.
            // If a row is selected, then the SelectedRowsCollection has a count of > 0 
            //and we can get the index of the selected row[0] - which is the first (and in our case the only row) selected.
            if (dgvSuppliers.SelectedRows.Count > 0)
                selectedRowIndex = dgvSuppliers.SelectedRows[0].Index;

            // This code was having an issue in the assignment sample project, not selecting the first record of customer data. Fixed it. 
            if (selectedRowIndex > -1)
            {

                // Get the value of the ProductID field in the selected Row.
                int selectedSupplierID = ToInt32(dgvSuppliers.Rows[selectedRowIndex].Cells["SupplierID"].Value.ToString());

                // Now I have the primary key - I can find the selected customer object.
                // Even though there will be only one product, 
                selectedSupplier = nwEntities.Suppliers.
                    Where(s => s.SupplierID == selectedSupplierID).
                    Select(s => s).FirstOrDefault();

                if (selectedSupplier != null)
                {
                    this.rtfSupplierDetail.Text = selectedSupplier.Supplier_Information;
                }

            }
        }
            private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            cmbSalesRegion.SelectedIndex = -1;
            chkDiscontinued.Checked = false;
            txtProductName.ResetText();
            txtSellerEmployee.ResetText();
            txtTotalSales.ResetText();

            // Load the DGV with all the products.
            LoadDGV(nwEntities.Products);
        }

    }
}



