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




    }
}
