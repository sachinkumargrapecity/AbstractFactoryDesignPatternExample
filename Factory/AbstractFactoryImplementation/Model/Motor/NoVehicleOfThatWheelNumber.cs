using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation.Model.Motor
{
    class NoVehicleOfThatWheelNumber : AbstractVehicleFactory.Model.Vehicle
    {
        private readonly int wheels;

        public NoVehicleOfThatWheelNumber(int wheels)
        {
            this.wheels = wheels;
        }
        public override string ToString()
        {
            return $"Motored vehicles with {wheels} wheels cannot be made in our factory.";
        }
    }
}
