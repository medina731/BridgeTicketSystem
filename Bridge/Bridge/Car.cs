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
            return 230;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
