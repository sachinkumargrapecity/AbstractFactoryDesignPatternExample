using System;

namespace AbstractFactoryImplementation.Exceptions
{
    public class NoVehicleFoundException : Exception
    {
        public NoVehicleFoundException(string message) : base (message)
        {}
    }
}
