using System;

namespace TicketLibrary
{
    public class Car:Vehicle


    {
        /// <summary>
        /// this is returning the price of car
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            if (Brobizz == true)
            {
                return 240 * 0.95;
            }
                return 240;
            
        } 

        public override string VehicleType()
        {
            return "car";
        }
    }
}

