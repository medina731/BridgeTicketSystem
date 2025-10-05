using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Car : VehicleBase
    {


        public override double Price()
        {
            double basePrice = 300;
            return Brobizz ? basePrice * 0.9 : basePrice; 
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
