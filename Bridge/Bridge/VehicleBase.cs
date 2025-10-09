using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeStuffModel
{
    /// <summary>
    /// Det her er VehicleBase klassen, som er en abstrakt klasse.
    /// Baseklassen indeholder shared properties og logik for alle vehicle typer, såsom Licenseplate, Date og Brobizz.
    /// </summary>
    public abstract class VehicleBase
    {
      
        
        /// <summary>
        /// Her er Licenseplate property, som er en string.
        /// </summary>
        public string Licenseplate { get; set; } = string.Empty;
        /// <summary>
        /// Her er Date property, som er en DateTime.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Her er Brobizz property, som er en bool.
        /// </summary>
        public bool Brobizz {  get; set; }

        /// <summary>
        /// Her er Price metoden, som er en abstrakt metode.
        /// </summary>
        /// <returns></returns>
        public abstract double Price();
        /// <summary>
        /// Her er VehicleType metoden, som er en abstrakt metode.
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();

        /// <summary>
        /// Her er LicensePlate, som bruges af licensePLate-Property til validering og adgang.
        /// </summary>
        private string _licenseplate = string.Empty;

        /// <summary>
        /// konstruktor for vehiclebase, som kun tager 1 parameter, som er licenseplate.
        /// </summary>
        /// <param name="licensePlate"></param>
        public VehicleBase(string licensePlate)
        {
            LicensePlate = licensePlate;
         
        }


        /// <summary>
        /// Her er min licenseplate property med en validering, som sikrer at licenseplaten mindst er 7 karakter lang.
        /// </summary>
        public string LicensePlate
        {
            get { return _licenseplate; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("License plate cannot be longer than 7 characters.");
                }
                _licenseplate = value;
            }
        }
        /// <summary>
        /// Her er ApplyDiscountForBroBizz metoden, som tjekker om et vehicle har brobizz, og hvis det har, bliver der givet 10% rabat på prisen.
        /// </summary>
        /// <param name="price"> Den oprindelig pris før discount</param>
        /// <returns> Den nedsatte pris</returns>
        protected double ApplyDiscountForBroBizz (double price)
        {
            return Brobizz ? price * 0.9 : price;
        }



    }    
    
}
