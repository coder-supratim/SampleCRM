using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 

namespace NWTraders.Controller
{
    public partial class Supplier
    {

       


      

        public string Supplier_Information
        {
            get
            {
                string decoratedSupplierInformation = "";

                decoratedSupplierInformation += "-------------Supplier Information------------ \n";
                decoratedSupplierInformation += "Supplier Company Name: " + this.CompanyName + "\n";
                decoratedSupplierInformation += "Supplier Contact Name: " + this.ContactName + "\n";
                decoratedSupplierInformation += this.ContactTitle + "\n";
                decoratedSupplierInformation += this.Address + "\n";
                decoratedSupplierInformation += this.City + ", " + this.Country + "\n";
                decoratedSupplierInformation += "-----------------------***---------------------- \n";
                decoratedSupplierInformation += "Supplied Products: \n";
                foreach (Product p in this.Products)
                {

                    decoratedSupplierInformation += p.ProductName + "\tDiscontinued: " + p.Discontinued + "\n";
                }
              
                decoratedSupplierInformation += "-----------------------***---------------------- \n";


                return decoratedSupplierInformation;
            }
        }




    }
}
