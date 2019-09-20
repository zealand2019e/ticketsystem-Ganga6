using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
   public class Mc:Vehicle
    {
        public override string VehicleType()
        {
            return "Mc";
        }

        public  double Price()
         {
             return 125;
         }

         //public string Vehicle()
         //{
         //    return "Mc";
         //}

    }
}
