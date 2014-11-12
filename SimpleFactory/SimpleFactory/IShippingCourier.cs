using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public interface IShippingCourier
    {
        string GetCourierTrackId(Address address);
    }
}
