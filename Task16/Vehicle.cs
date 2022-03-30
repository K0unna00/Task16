using System;
using System.Collections.Generic;
using System.Text;

namespace Task16
{
    public class Vehicle
    {
        public string Color;
        public string Brand;
        public int Millage;
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand : {Brand} , Color : {Color} Millage : {Millage}");
        }
    }
}
