using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_A2_Chinook.Models
{
    public partial class Invoice 
    {   
        public string FormattedTotal { get {
                return "Order Date: " + InvoiceDate.ToString("yyyy-MM-dd") + " Order Total: $" + Total + " Order Quantity: " + InvoiceLines.Count().ToString(); } }

    }
}
