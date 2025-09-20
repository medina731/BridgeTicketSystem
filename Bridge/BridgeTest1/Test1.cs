using Bridge;


namespace BridgeTest
{
    /// <summary>
    /// Unit test for Car Klassen. 
    /// </summary>
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void VehicleType_ShouldReturnCar()
        {
            // Arrange 
            var car = new Car();

            //Act
            var result = car.VehicleType();

            //Assert
            Assert.AreEqual("Car", result);
        }
    }
}