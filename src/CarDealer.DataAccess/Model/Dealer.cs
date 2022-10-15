using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.DataAccess.Model
{
    public class Dealer:Base.Model
    {
        public string SupplierName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
