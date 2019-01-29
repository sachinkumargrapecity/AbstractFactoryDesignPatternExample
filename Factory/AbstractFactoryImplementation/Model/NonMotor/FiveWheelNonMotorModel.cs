using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation.Model.NonMotor
{
    class FiveWheelNonMotorModel : AbstractVehicleFactory.Model.Vehicle
    {
        public override string ToString()
        {
            return "Five Wheel Vehicle Created";
        }
    }
}
