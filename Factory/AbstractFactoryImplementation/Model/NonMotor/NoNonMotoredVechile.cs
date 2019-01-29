using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation.Model.NonMotor
{
    class NoNonMotoredVechile : AbstractVehicleFactory.Model.Vehicle
    {
        private readonly int wheels;
        public NoNonMotoredVechile(int wheel)
        {
            wheels = wheel;
        }
        public override string ToString()
        {
            return $"Non-motored vehicles with {wheels} wheels cannot be made in our factory.";
        }
    }
}
