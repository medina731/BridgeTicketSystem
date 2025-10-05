using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class VehicleBase
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }
        public bool Brobizz {  get; set; }
       

       public abstract double Price();
        public abstract string VehicleType();


        private string _licenseplate;
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

        protected double ApplyDiscountForBroBizz (double price)
        {
            return Brobizz ? price * 0.9 : price;
        }



    }    
    
}
