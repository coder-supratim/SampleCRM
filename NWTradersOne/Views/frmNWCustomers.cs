using NWTraders.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Convert;


namespace NWTraders.Views
{

    // declare the context to get access to the data class:

    public partial class frmNWCustomers : Form
    {


        /// <summary>
        /// This provides the context to all the data in the form of entities. 
        /// All our data access will be through the nwEntities object.
        /// nwEntities-is an instance of the NorthWindEntities class that we created when we built the data model.
        /// </summary>
        public NorthwindEntities nwEntities = new NorthwindEntities();

        private Customer selectedCustomer;

        public List<string> AllCountries()
        {
            List<string> allCountries = new List<string>();
            allCountries = nwEntities.Customers.Select(c => c.Country).Distinct().ToList();
            return allCountries;
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

        public List<String> AllTitles()
        {
            List<String> allTitles  = new List<string>();

            // From the customers table, 
            // where the contact title is not null or empty, 
            // select every contact title 
            // keep only the distinct ones 
            // then convert it to a list.
            allTitles = nwEntities.Customers.
                Where(c => string.IsNullOrEmpty(c.ContactTitle) == false).
                Select(c => c.ContactTitle).
                Distinct().
                ToList();

            return allTitles;
        }


        public void FormatDGV()
        {
            // First clear all the rows in the DGV.
            dgvCustomers.Rows.Clear();

            // This is the number of fields in the Customers table - we will create that many columns in the DGV.
            dgvCustomers.ColumnCount = 8;

            //The rest of the code will take each column and set up its display.
            dgvCustomers.Columns[0].Name = "CustomerID";
            dgvCustomers.Columns[0].Visible = false; /// The primary key is not made visible per best practice.

            dgvCustomers.Columns[1].Name = "CompanyName";
            dgvCustomers.Columns[1].Width = 225;
            dgvCustomers.Columns[1].HeaderText = "Company";

            dgvCustomers.Columns[2].Name = "Contact";
            dgvCustomers.Columns[2].Width = 150;
            dgvCustomers.Columns[2].HeaderText = "Contact";

            dgvCustomers.Columns[3].Name = "ContactTitle";
            dgvCustomers.Columns[3].Width = 150;
            dgvCustomers.Columns[3].HeaderText = "Title";

            dgvCustomers.Columns[4].Name = "City";
            dgvCustomers.Columns[4].Width = 125;
            dgvCustomers.Columns[4].HeaderText = "City";

            dgvCustomers.Columns[5].Name = "Country";
            dgvCustomers.Columns[5].Width = 100;
            dgvCustomers.Columns[5].HeaderText = "Country";

            dgvCustomers.Columns[6].Name = "Region";
            dgvCustomers.Columns[6].Width = 100;
            dgvCustomers.Columns[6].HeaderText = "Region";

            dgvCustomers.Columns[7].Name = "TotalSales";
            dgvCustomers.Columns[7].Width = 100;
            dgvCustomers.Columns[7].HeaderText = "TotalSales";


            // All .NET collections are numbered beginning from zero - so # 7 is the 8th column.

        }

        public void FormatOrderDetailsDGV()
        {
            // First clear all the rows in the DGV.
            dgvOrders.Rows.Clear();

            
            dgvOrders.ColumnCount = 4;


            dgvOrders.Columns[0].Name = "OrderID";
            dgvOrders.Columns[0].Width = 225;
            dgvOrders.Columns[0].HeaderText = "Order ID";

            dgvOrders.Columns[1].Name = "OrderDate";
            dgvOrders.Columns[1].Width = 150;
            dgvOrders.Columns[1].HeaderText = "Order Placed";

            dgvOrders.Columns[2].Name = "ShippedDate";
            dgvOrders.Columns[2].Width = 150;
            dgvOrders.Columns[2].HeaderText = "Shipped Date";

            dgvOrders.Columns[3].Name = "OrderTotal";
            dgvOrders.Columns[3].Width = 125;
            dgvOrders.Columns[3].HeaderText = "Order Total";


           
        }

        public void LoadDGV(IEnumerable<Customer> customers)
        {
            // If there are no customers, do nothing and return from the function.
            if (customers == null) return;

            // The following lines of code will run only if the list of customer objects is not null - in other words, if there are customers.

            // If there are no columns in the DGV, then it has not been initialized
            //  Initialize and format the DGV using the function we wrote, before adding anything.
            if (dgvCustomers.RowCount == 0)
                FormatDGV();


            // First we wil clear the DGV Rows if any exist.
            dgvCustomers.Rows.Clear();

            // Go through every customer in the customer collection and 
            // add it as a row in the dgv
            foreach (Customer cust in customers)
            {
                dgvCustomers.Rows.Add(
                    cust.CustomerID, // The ID will not actually be shown since it is given to a column that has the Visible property set to False.
                    cust.CompanyName,
                    cust.ContactName,
                    cust.ContactTitle,
                    cust.City,
                    cust.Country,
                    cust.Region,
                    cust.TotalSales.ToString("C")
                    );
            }

            // Clear any selections that may have been made.
            dgvCustomers.ClearSelection();

            // As a beginning default view, we can sort the dgv in alphabetical order of Company name (Field 1)
            dgvCustomers.Sort(dgvCustomers.Columns[1], ListSortDirection.Ascending);

        }

        public void LoadOrderDetails(IEnumerable<Order> orders)
        {
            // If there are no Orders, do nothing and return from the function.
            if (orders == null) return;

            // The following lines of code will run only if the list of orders objects is not null - in other words, if there are customers.

            // If there are no columns in the DGV, then it has not been initialized
            //  Initialize and format the DGV using the function we wrote, before adding anything.
            if (dgvOrders.RowCount == 0)
                FormatOrderDetailsDGV();


            // First we wil clear the DGV Rows if any exist.
            dgvOrders.Rows.Clear();

            // Go through every order in the order collection and 
            // add it as a row in the dgvOrders
            foreach (Order order in orders)
            {
                dgvOrders.Rows.Add(
                    order.OrderID, 
                    order.OrderDate,
                    order.ShippedDate,
                    order.orderTotal
                               );
            }

            // Clear any selections that may have been made.
            dgvOrders.ClearSelection();

            // As a beginning default view, we can sort the dgv in alphabetical order of Company name (Field 1)
            dgvOrders.Sort(dgvOrders.Columns[1], ListSortDirection.Ascending);

        }

        // The function returns all the customer objects who have the country supplied.
        public IEnumerable<Customer> SearchByCounty(string Country)
        {
            // If the Country string is nothing or empty, return all the customers.
            if (string.IsNullOrEmpty(Country))
                return nwEntities.Customers;

            IEnumerable<Customer> foundCustomers =
                nwEntities.Customers.
                Where(c => string.Compare(Country, c.Country) == 0).
                Select(c => c).
                OrderBy(c => c.CompanyName);

            return foundCustomers;
        }


        // The function returns all the customer objects who have the country supplied.
        public IEnumerable<Customer> SearchByCompanyName(string CompanyName)
        {
            // If the Country string is nothing or empty, return all the customers.
            if (string.IsNullOrEmpty(CompanyName))
                return nwEntities.Customers;

            IEnumerable<Customer> foundCustomers =
                nwEntities.Customers.
                Where(c => c.CompanyName.Contains(CompanyName)).
                Select(c => c).
                OrderBy(c => c.CompanyName);

            return foundCustomers;
        }


        // The function returns all the customer objects who have the Contact supplied.
        public IEnumerable<Customer> SearchByContact(string Contact)
        {
            // If the Contact string is nothing or empty, return all the customers.
            if (string.IsNullOrEmpty(Contact))
                return nwEntities.Customers;

            IEnumerable<Customer> foundCustomers =
                nwEntities.Customers.
                Where(c => c.ContactName.Contains(Contact)).
                Select(c => c).
                OrderBy(c => c.CompanyName);

            return foundCustomers;
        }

        // The function returns all the customer objects who have the Contact Title supplied.
        public IEnumerable<Customer> SearchByContactTitle(string ContactTitle)
        {
            // If the ContactTitle string is nothing or empty, return all the customers.
            if (string.IsNullOrEmpty(ContactTitle))
                return nwEntities.Customers;

            IEnumerable<Customer> foundCustomers =
                nwEntities.Customers.
                Where(c => string.Compare(ContactTitle, c.ContactTitle) == 0).
                Select(c => c).
                OrderBy(c => c.CompanyName);

            return foundCustomers;
        }

        // The function returns all the customer objects who have the City supplied.
        public IEnumerable<Customer> SearchByCity(string City)
        {
            // If the City string is nothing or empty, return all the customers.
            if (string.IsNullOrEmpty(City))
                return nwEntities.Customers;

            IEnumerable<Customer> foundCustomers =
                nwEntities.Customers.
                Where(c => c.City.Contains(City)).
                Select(c => c).
                OrderBy(c => c.CompanyName);

            return foundCustomers;
        }

        // The function returns all the customer objects who have the Region supplied.
        public IEnumerable<Customer> SearchByRegion(string Region)
        {
            // If the ContactTitle string is nothing or empty, return all the customers.
            if (string.IsNullOrEmpty(Region))
                return nwEntities.Customers;

            IEnumerable<Customer> foundCustomers =
                nwEntities.Customers.
                Where(c => string.Compare(Region, c.Region) == 0).
                Select(c => c).
                OrderBy(c => c.CompanyName);

            return foundCustomers;
        }


        public frmNWCustomers()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The first function that is called with the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Load the data for each combo-box.
            cmbCountry.DataSource = AllCountries();
            cmbRegion.DataSource = AllRegions();
            cmbContactTitle.DataSource = AllTitles();

            // Load the DGV with all the customers.
            LoadDGV(nwEntities.Customers);
        }


        /// <summary>
        /// The event is fired when the Data Grid View 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = -1;

            // When a row in the DGV is selected, you can find which row index is selected.
            // Generally, you can zero or select multiple rows in a dgv.
            // If a row is selected, then the SelectedRowsCollection has a count of > 0 
            //and we can get the index of the selected row[0] - which is the first (and in our case the only row) selected.
            if (dgvCustomers.SelectedRows.Count > 0)
                selectedRowIndex = dgvCustomers.SelectedRows[0].Index;

            // This code was having an issue in the assignment sample project, not selecting the first record of customer data. Fixed it. 
            if (selectedRowIndex > -1)
            {

                // Get the value of the CustomerID field in the selected Row.
                string selectedCustomerID = dgvCustomers.Rows[selectedRowIndex].Cells["CustomerID"].Value.ToString();

                // Now I have the primary key - I can find the selected customer object.
                // Even though there will be only one customer, 
                selectedCustomer = nwEntities.Customers.
                    Where(c => string.Equals(c.CustomerID, selectedCustomerID)).
                    Select(c => c).FirstOrDefault();

                if (selectedCustomer != null) {  
                    this.rtfCustomerInformation.Text = selectedCustomer.CustomerInformation;
                    IEnumerable<Order> selectedOrders = nwEntities.Orders.Where(o => o.CustomerID == selectedCustomer.CustomerID);
                    LoadOrderDetails(selectedOrders);
                }
                   
            }

        }


        private void DgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = -1;

            // When a row in the DGV is selected, you can find which row index is selected.
            // Generally, you can zero or select multiple rows in a dgv.
            // If a row is selected, then the SelectedRowsCollection has a count of > 0 
            //and we can get the index of the selected row[0] - which is the first (and in our case the only row) selected.
            if (dgvOrders.SelectedRows.Count > 0)
                selectedRowIndex = dgvOrders.SelectedRows[0].Index;

            // Just to double check, make sure that the value of the index is greater than zero.
            if (selectedRowIndex > -1)
            {

                // Get the value of the OrderID field in the selected Row.
                int selectedOrderID = ToInt32(dgvOrders.Rows[selectedRowIndex].Cells["OrderID"].Value.ToString());

                 Order selectedOrder = nwEntities.Orders.
                    Where(o => o.OrderID == selectedOrderID).
                    Select(o => o).FirstOrDefault();

                if (selectedCustomer != null)
                    this.rtfOrderInformation.Text = selectedOrder.OrderInformation;
            }

        }
        /// <summary>
        /// The event handler for a change in the selection for a country 
        /// The funciton calls the Search By Country method and passes the selected value in the comboBox.
        /// The Search by Country returns the list of customer objects with the country property that matches the selected value in the combo box.
        /// The list of customers is then given to the LoadDGV function to display in the DGV.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCountry.SelectedIndex != -1)
            {
                IEnumerable<Customer> customersToShow = SearchByCounty(cmbCountry.SelectedItem.ToString().Trim());
                LoadDGV(customersToShow);

            }
        }

        /// <summary>
        /// This event handler is called whenever the selection in the txtCompany changes.
        /// The search function - Search by Company is called and the user's typed search parameter is supplied.
        /// The search function returns the list of customers that matches the company name search parameter 
        /// The list of customers is given to the load DGV function for display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtCompany_TextChanged(object sender, EventArgs e)
        {
            // Get the search text the user types in:
            string companySearchString = txtCompany.Text.Trim();

            // pass the search string to the search function.
            IEnumerable<Customer> customersToShow = SearchByCompanyName(companySearchString);
            LoadDGV(customersToShow);


        }

        /// <summary>
        /// This event handler is called whenever the selection in the txtCompany changes.
        /// The search function - Search by Contact is called and the user's typed search parameter is supplied.
        /// The search function returns the list of customers that matches the contact name search parameter 
        /// The list of customers is given to the load DGV function for display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtContact_TextChanged(object sender, EventArgs e)
        {
            // Get the search text the user types in:
            string contactSearchString = txtContact.Text.Trim();

            // pass the search string to the search function.
            IEnumerable<Customer> customersToShow = SearchByContact(contactSearchString);
            LoadDGV(customersToShow);


        }

        /// <summary>
        /// This event handler is called whenever the selection in the txtCity changes.
        /// The search function - Search by Company is called and the user's typed search parameter is supplied.
        /// The search function returns the list of customers that matches the city search parameter 
        /// The list of customers is given to the load DGV function for display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtCity_TextChanged(object sender, EventArgs e)
        {
            // Get the search text the user types in:
            string citySearchString = txtCity.Text.Trim();

            // pass the search string to the search function.
            IEnumerable<Customer> customersToShow = SearchByCity(citySearchString);
            LoadDGV(customersToShow);


        }

        /// <summary>
        /// The event handler for a change in the selection for a ContactTitle 
        /// The funciton calls the Search By ContactTitle method and passes the selected value in the comboBox.
        /// The Search by ContactTitle returns the list of customer objects with the ContactTitle property that matches the selected value in the combo box.
        /// The list of customers is then given to the LoadDGV function to display in the DGV.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbContactTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbContactTitle.SelectedIndex != -1)
            {
                IEnumerable<Customer> customersToShow = SearchByContactTitle(cmbContactTitle.SelectedItem.ToString().Trim());
                LoadDGV(customersToShow);

            }
        }

        /// <summary>
        /// The event handler for a change in the selection for a Region 
        /// The funciton calls the Search By Region method and passes the selected value in the comboBox.
        /// The Search by Region returns the list of customer objects with the region property that matches the selected value in the combo box.
        /// The list of customers is then given to the LoadDGV function to display in the DGV.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegion.SelectedIndex != -1)
            {
                IEnumerable<Customer> customersToShow = SearchByRegion(cmbRegion.SelectedItem.ToString().Trim());
                LoadDGV(customersToShow);

            }
        }

        /// <summary>
        /// The cleanest way to exit any application is by calling the Application.Exit() method from the System's application class.
        /// </summary>
        /// <param name="sender"> The sender is the btn Exit since it is clicked.</param>
        /// <param name="e"> No parameters are passed</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            cmbRegion.SelectedIndex = -1;
            cmbContactTitle.SelectedIndex = -1;
            cmbCountry.SelectedIndex = -1;
            txtContact.ResetText();
            txtCity.ResetText();
            txtCompany.ResetText();
            // Load the DGV with all the customers.
            LoadDGV(nwEntities.Customers);
        }

    }
}
