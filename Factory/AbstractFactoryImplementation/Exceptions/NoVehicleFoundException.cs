using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation.Exceptions
{
    class NoVehicleFoundException : Exception
    {
        public NoVehicleFoundException(string message) : base (message)
        {}
    }
}
