using System;
using System.Collections.Generic;
using System.Text;

namespace Task16
{
    public class Car : Vehicle
    {
        public int FuelCapacity;
        public int CurrentFuel;
        public int FuelFor1km;

        public void Drive(int mill)
        {
            int temp = mill * FuelFor1km;
            if (temp <= CurrentFuel)
            {
                CurrentFuel -= temp;
                Millage += mill;
            }
        }
    }
}
