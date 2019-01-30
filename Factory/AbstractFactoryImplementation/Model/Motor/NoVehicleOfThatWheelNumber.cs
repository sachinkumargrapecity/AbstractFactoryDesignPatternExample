using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// #REVIEW: Lots of unused using statements.
namespace AbstractFactoryImplementation.Model.Motor
{
    /// <summary>
    /// #REVIEW: You have created separate classes for invalid vehicle where you could have just made 1.
    /// Although I feel a class for an invalid vehicle is an overkill and highly unnessary because
    /// You just use the message in the end. A simple string in case of an invalid vehicle could have sufficed.
    /// </summary>
    class NoVehicleOfThatWheelNumber : AbstractVehicleFactory.Model.Vehicle
    {
        private readonly int wheels; // #REVIEW: +1 for using readonly.

        public NoVehicleOfThatWheelNumber(int wheels)
        {
            this.wheels = wheels;
        } // #REVIEW: No two methods should exist without a line break in a class. 
        public override string ToString()
        {
            return $"Motored vehicles with {wheels} wheels cannot be made in our factory.";
        }
    }
}
