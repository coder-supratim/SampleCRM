using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWTraders.Controller
{
    public partial class Customer
    {

        public string CustomerInformation
        {
            get
            {
                string decoratedCustomerInformation = "";

                decoratedCustomerInformation += this.CompanyName + "\n";
                decoratedCustomerInformation += "--------------------------------------------- \n";
                decoratedCustomerInformation += "Contact Information: " + this.ContactName + "\n";
                decoratedCustomerInformation += this.ContactTitle + "\n";
                decoratedCustomerInformation += this.Address + "\n";
                decoratedCustomerInformation += this.City + ", " + this.Country + "\n";

                decoratedCustomerInformation += "--------------------------------------------- \n";
                decoratedCustomerInformation += this.CompanyName + "has placed " + NumberOfOrdersPlaced + " Orders " ;
                decoratedCustomerInformation += "for a total of: " + TotalSales.ToString("C") + "\n";
                decoratedCustomerInformation += "The Last Order was placed on:  " + LastOrderOn.ToString("MMM, dd yyyy");


                return decoratedCustomerInformation;
            }
        }

        public DateTime LastOrderOn
        {
            get
            {
                return this.Orders.OrderBy(o => o.OrderDate).FirstOrDefault().OrderDate.Value;
            }
        }
        public decimal TotalSales
        {
            get {
                return this.Orders.Sum(o => o.orderTotal);
            }

        }
        public int NumberOfOrdersPlaced
        { get
            {
                return this.Orders.Count();
            } }

    }
}
