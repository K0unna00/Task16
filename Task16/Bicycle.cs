using System;
using System.Collections.Generic;
using System.Text;

namespace Task16
{
    public class Bicycle:Vehicle
    {
        public void Drive(int mill)
        {
            Millage += mill;
        }
    }
}
