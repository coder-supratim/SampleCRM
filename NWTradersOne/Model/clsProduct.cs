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

        public int TotalSales
        {
            get {

                return this.Order_Details.Sum(od => od.Quantity);

            }
        }


      

        public string Product_Information
        {
            get
            {
                string decoratedProductInformation = "";

                decoratedProductInformation += "Product Details for the Product Id: " + this.ProductID + "\n";
                decoratedProductInformation += "------------------------***--------------------- \n";
                decoratedProductInformation += "Product Name: " + this.ProductName + "\n";
                decoratedProductInformation += "Unit Price: " + this.UnitPrice + "\n";
                decoratedProductInformation += "Unit in Stock: " + this.UnitsInStock + "\n";
                
                decoratedProductInformation += "Units on Order: " + this.UnitsOnOrder + "\n";
                decoratedProductInformation += "Supplier of this Product: " + this.Supplier.CompanyName + "\n";

                decoratedProductInformation += "-----------------------***---------------------- \n";
                decoratedProductInformation += "Total sales of this product: " + this.TotalSales;


                return decoratedProductInformation;
            }
        }




    }
}
