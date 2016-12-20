using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    // ConcreteComponent
    public class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "FullSize Car";
        }

        public override double GetCarPrice() => 30000.00;
        public override string GetDescription() => Description;
    }
}
