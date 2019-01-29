using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation.Model.Motor
{
    class PickUpModel : AbstractVehicleFactory.Model.Vehicle
    {
        public override string ToString()
        {
            return "Pickup Created";
        }
    }
}
