using BridgeStuffModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBroLibrary
{
    /// <summary>
    /// Det her er OresundMC klassen, som nedarver fra vehicleBase klassen.
    /// Det er samme system som med car klassen, det her er bare for motorcykler. 
    /// </summary>
    internal class OresundMC : VehicleBase
    {
        public OresundMC(string licensePlate) : base(licensePlate) { }

        public override double Price()
        {
            return Brobizz ? 92 : 235;
        }
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
