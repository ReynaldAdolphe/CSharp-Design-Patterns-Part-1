using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    // ConcreteComponent
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }

        public override double GetCarPrice() => 10000.00;
        public override string GetDescription() => Description;
    }
}
