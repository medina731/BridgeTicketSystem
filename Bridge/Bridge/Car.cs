using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Det her er Car klassen, som nedarver fra vehicleBase klassen.
    /// Klassen representere hvordan at en bil bliver brugt i BroBizz systemet.
    /// </summary>
    public class Car : VehicleBase
    {
        /// <summary>
        /// Her er prisen for en bil, som er 300 kr.Metoden skal regne prisen ud for en bil.
        /// Hvis bilen har Brobizz, bliver der givet 10% rabat på deres billet over broen.
        /// Hvis det er weekend (lørdag eller søndag), får bilen 15% rabat på den oprindelige pris, før Brobizz rabatten bliver trukket fra.
        /// </summary> 
        /// <returns> baseprisen * 0.9 : Baseprisen hvis en bil har Brobizz </returns>

        public override double Price()
        {
            double basePrice = 300;
            if(Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                basePrice *= 0.85; // Weekend pris 15%
            }

            return Brobizz ? basePrice * 0.9 : basePrice; 
        }
        /// <summary>
        /// Her er VehicleType metoden, som returnere "Car", fordi det er en bil.
        /// </summary>
        /// <returns>Car</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
