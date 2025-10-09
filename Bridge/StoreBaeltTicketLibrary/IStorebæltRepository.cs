using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeStuffModel;

namespace StoreBaeltTicketLibrary
{
    internal interface IStorebæltRepository
    {
        public interface IStoreBaeltRepository
        {
            void AddTicket(VehicleBase ticket);
            List<VehicleBase> GetAllTickets();
            List<VehicleBase> GetTicketsByLicensePlate(string licensePlate);
        }





    }
}
