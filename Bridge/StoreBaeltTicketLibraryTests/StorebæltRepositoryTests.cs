using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StorebæltRepositoryTests
    {
        [TestMethod()]
        public void AddTicketTest()
        {
            var repo = new StorebæltRepository();
            var ticket = new StoreBæltCar("ABC1234") { Brobizz = true };

            repo.AddTicket(ticket);
            var allTickets = repo.GetAllTickets();

            Assert.AreEqual(1, allTickets.Count);
            Assert.AreEqual("ABC1234", allTickets[0].LicensePlate);
        }

        [TestMethod()]
        public void GetAllTicketsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTicketsByLicensePlateTest()
        {
            Assert.Fail();
        }
    }
}