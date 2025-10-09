
using BridgeStuffModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OresundBroLibrary
{
    /// <summary>
    /// Det her er OresundCar klassen, som nedarver fra vehicleBase klassen.
    /// Her har vi lavet en klasse til Øresundsbroen, der viser at en  bil der har brobizz, kan få rabat på prisen.
    /// </summary>
    public class OresundCar : VehicleBase
    {

        public OresundCar(string licensePlate) : base(licensePlate) { }

        public override double Price()
        {
            return Brobizz ? 178 : 460;
        }

        public override string VehicleType()
        {
            return " Oresund car";
        }

    }
}
