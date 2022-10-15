using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.DataAccess.Model
{
    public class DealerCar:Base.Model
    {

        public int Qty { get; set; }

        public CarModel CarModel { get; set; }
        public Color Color { get; set; }
    }
}
