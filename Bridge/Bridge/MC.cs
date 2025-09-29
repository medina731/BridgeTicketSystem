using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }
    

        public double Price()

        {
            return 120;
        }

        public string VehicleType()
        {
            return "MC";
        }

    }
}
    
