using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;
using AbstractFactoryImplementation.Model.Motor;
using AbstractVehicleFactory.Model;

namespace AbstractFactoryImplementation.Factory
{
    /// <summary>
    /// #REVIEW: Avoid unused namespaces. VS 2017 -> ctrl+R,G.
    /// </summary>
    public class MotoredVehicleFactory : IMotored
    {
        public Vehicle Create(int wheels)
        {
            switch (wheels)
            {
                case 2: return new BikeModel();
                case 3: return new AutoModel();
                case 4: return new CarModel();
                case 6: return new PickUpModel();
                default: return new NoVehicleOfThatWheelNumber(wheels);
            }
        }
    }
}
