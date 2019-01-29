using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation.Model.Motor
{
    class AutoModel : AbstractVehicleFactory.Model.Vehicle
    {
        public override string ToString()
        {
            return "Auto Created";
        }
    }
}
