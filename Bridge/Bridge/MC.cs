using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeStuffModel
{
    /// <summary>
    /// Det her er MC klassen, som nedarver fra vehicleBase klassen.
    /// Klassen MC står for Motorcykel , og representere hvordan at en motorcykel bliver brugt i BroBizz systemet.
    /// </summary>
    public class MC : VehicleBase
    {
       
        /// <summary>
        /// konstruktor for MC, som kun tager 1 parameter, som er licenseplate.
        /// </summary>
        /// <param name="licensePlate"></param>
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
    
