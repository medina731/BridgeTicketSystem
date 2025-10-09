using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeStuffModel;

namespace StoreBaeltTicketLibrary
{
    public class StorebæltRepository : IStorebæltRepository

    {
        private  List<VehicleBase> _tickets = new();

        public void AddTicket(VehicleBase ticket)
        { 
          _tickets.Add(ticket);
        }

        public List<VehicleBase> GetAllTickets()
        { 
          return _tickets;
        }

        public List<VehicleBase>GetTicketsByLicensePlate(string licensePlate)
        {
            return _tickets
               .Where(t=>  t.LicensePlate.Equals(licensePlate, System.StringComparison.OrdinalIgnoreCase))
               .ToList();
        }
    }
}
