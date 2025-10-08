using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Det her er MC klassen, som nedarver fra vehicleBase klassen.
    /// Klassen MC står for Motorcykel , og representere hvordan at en motorcykel bliver brugt i BroBizz systemet.
    /// </summary>
    public class MC : VehicleBase
    {
        public MC(string licensePlate) : base(licensePlate)
        {
        }

        /// <summary>
        /// Her er prisen for en motorcykel, som er 120 kr.Metoden skal regne prisen ud for en motorcykel.
        /// </summary>
        /// <returns> Den returnere prisen for en MC</returns>

        public override double Price()

        {
            return 120;
        }
        /// <summary>
        /// Her er Vehicletype metoden, som returnere type for et vehicle som en string 
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }

    }
}
    
