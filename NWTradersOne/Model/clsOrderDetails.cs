using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWTraders.Controller
{
    public partial class Order_Detail
    {

        public decimal Total
        {
            get
            {
                return ((UnitPrice - (decimal) Discount) * Quantity);
            }
        }
    }
}
