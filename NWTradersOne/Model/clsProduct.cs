using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 

namespace NWTraders.Controller
{
    public partial class Product
    {

        public int totalSales
        {
            get {

                return this.Order_Details.Sum(od => od.Quantity);

            }
        }

      

        public string Product_Information
        {
            get
            {
                string decoratedOrderInformation = "";

                decoratedOrderInformation += "Product Details Details for the Product Id: " + this.ProductID + "\n";
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
