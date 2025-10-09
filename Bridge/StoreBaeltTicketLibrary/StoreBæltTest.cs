using BridgeStuffModel;

namespace StoreBaeltTicketLibrary;

public class StoreBæltTest
{
    [TestClass]
    public class StoreBaeltRepositoryTests
    {
        [TestMethod]
        public void AddTicket_StoresTicketCorrectly()
        {
            var repo = new StorebæltRepository();
            var ticket = new StoreBæltCar("ABC1234") { Brobizz = true };

            repo.AddTicket(ticket);
            var allTickets = repo.GetAllTickets();

            Assert.AreEqual(1, allTickets.Count);
            Assert.AreEqual("ABC1234", allTickets[0].LicensePlate);
        }
    }
}
