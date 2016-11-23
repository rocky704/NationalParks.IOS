using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace NationalParks.IOS
{
    public class NationalPark
    {
        public NationalPark()
        {
            Id = Guid.NewGuid().ToString();
            Name = "New Park";
        }

    }
}