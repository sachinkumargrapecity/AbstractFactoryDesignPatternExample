using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation.Model.NonMotor
{
    class FourWheelCartModel : AbstractVehicleFactory.Model.Vehicle
    {
        public override string ToString()
        {
            return "Four Wheel cart is created";
        }
    }
}
