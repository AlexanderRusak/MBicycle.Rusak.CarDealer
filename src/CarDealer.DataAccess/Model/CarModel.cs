using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.DataAccess.Model
{
    public class CarModel:Base.Model
    {
        public string Model { get; set; }
        public CarModelName CarModelName { get; set; }
        public Dealer Dealer { get; set; }
    }
}
