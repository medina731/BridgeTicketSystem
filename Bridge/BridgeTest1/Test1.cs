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

    [TestClass]
    /// <summary>
    /// Unit test for MC Klassen.
    /// </summary>
    public class MCTest
    {
        [TestMethod]
        public void VehicleType_ShouldReturnMC()
        {
            // Arrange 
            var mc = new MC();
            //Act
            var result = mc.VehicleType();
            //Assert
            Assert.AreEqual("MC", result);
        }

        [TestMethod]
        public void Price_ShouldReturnPrice120()
        {
            var mc = new MC();
            var result = mc.Price();
            Assert.AreEqual(120.0, result);
        }

      
    }



}