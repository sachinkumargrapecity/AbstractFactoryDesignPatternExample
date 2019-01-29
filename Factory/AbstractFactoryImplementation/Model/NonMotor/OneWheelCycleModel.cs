using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation.Model.NonMotor
{
    class OneWheelCycleModel : AbstractVehicleFactory.Model.Vehicle
    {
        public override string ToString()
        {
            return "One Wheel Cycle Created";
        }
    }
}
