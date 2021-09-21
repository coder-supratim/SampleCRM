using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 

namespace NWTraders.Controller
{
    public partial class Order
    {

        public decimal orderTotal
        {
            get {

                return this.Order_Details.Sum(od => od.Total);

            }
        }


        public string OrderInformation
        {
            get
            {
                string decoratedOrderInformation = "";

                decoratedOrderInformation += this.OrderID + "\n";
                decoratedOrderInformation += "--------------------------------------------- \n";
                decoratedOrderInformation += "Order Date: " + this.OrderDate + "\n";
                decoratedOrderInformation += "Customer Name: " + this.Customer.CompanyName + "\n";
                decoratedOrderInformation += "Shipping Address: " + this.ShipAddress + "\n";
                decoratedOrderInformation += this.ShipCity + ", " + this.ShipCountry + "\n";
                decoratedOrderInformation += "Shipping Date: " + this.ShippedDate + "\n";
                decoratedOrderInformation += "--------------------------------------------- \n";
                decoratedOrderInformation += this.Employee.FirstName + " " + this.Employee.LastName + "has placed this orders ";
                decoratedOrderInformation += "for a total of: " + this.orderTotal;


                return decoratedOrderInformation;
            }
        }




    }
}
