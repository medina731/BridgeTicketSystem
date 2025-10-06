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

    /// <summary>
    /// Unit test for VehicleBase Klassen.
    /// </summary>
    [TestClass]
    public class VehicleBaseTest
    {
        [TestMethod]

        public void VehicleBase_LicensePlate_SholdNotBeOver7Characters()
        {
            // Arrange
            var vehicle = new Car(); // Using Car as a concrete implementation of VehicleBase
            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => vehicle.LicensePlate = "ABCDEFGH");
            Assert.AreEqual("License plate cannot be longer than 7 characters.", exception.Message);
        }



    }
    /// <summary>
    /// test for at fjerne 10% hvis man har brobizz, og ellers fuldpris. 
    /// </summary>
    [TestClass]

    public class BroBizzTest
    {
        [TestMethod]
        public void ApplyDiscountForBroBizz_ShouldApply10PercentDiscount()
        {
            // Arrange
            var carWithBroBizz = new Car { Brobizz = true };
            var carWithoutBroBizz = new Car { Brobizz = false };
            // Act
            var priceWithBroBizz = carWithBroBizz.Price();
            var priceWithoutBroBizz = carWithoutBroBizz.Price();
            // Assert
            Assert.AreEqual(270.0, priceWithBroBizz , 0.01); // 300 * 0.9
            Assert.AreEqual(300.0, priceWithoutBroBizz , 0.01);
        }
    }

}