using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
   public abstract class Vehicle
   {
       public string licenseplate;
        public DateTime Date { get; set; }
        public bool  Brobizz { get; set; }
        public abstract string VehicleType();
        public double _price;

        public string LicensePlate
        {


            get { return licenseplate; }



            set
            {
                if (value.Length > 7)
                {
                    throw new Exception("License plate too long!");
                }
                else
                {
                    licenseplate = value;
                }

            }
        }

        public virtual double Price()
        {
return _price;
        }


   }

       




   
}
