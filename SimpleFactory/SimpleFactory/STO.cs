using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public class STO : IShippingCourier
    {
        public string GetCourierTrackId(Address address)
        {
            return "STO-xxxxxxxxxxx";
        }
    }
}
