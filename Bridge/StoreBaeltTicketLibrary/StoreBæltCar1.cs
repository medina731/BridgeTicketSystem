using BridgeStuffModel;

namespace StoreBaeltTicketLibrary
{
    internal class StoreBæltCar : VehicleBase
    {
        public StoreBæltCar(string licensePlate) : base(licensePlate)
        {
        }

        public bool Brobizz { get; set; }

        public override double Price()
        {
            throw new NotImplementedException();
        }

        public override string VehicleType()
        {
            throw new NotImplementedException();
        }
    }
}