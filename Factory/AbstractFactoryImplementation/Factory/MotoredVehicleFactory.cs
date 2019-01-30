using AbstractFactory.Factory;
using AbstractFactoryImplementation.Exceptions;
using AbstractFactoryImplementation.Model.Motor;
using AbstractVehicleFactory.Model;

namespace AbstractFactoryImplementation.Factory
{
    public class MotoredVehicleFactory : IVehicleFactory
    {
        public VehicleModel Create(int wheels)
        {
            switch (wheels)
            {
                case 2: return new BikeModel();
                case 3: return new AutoModel();
                case 4: return new CarModel();
                case 6: return new PickUpModel();
                default: throw new NoVehicleFoundException($"Motored vehicles with {wheels} wheels cannot be made in our factory.");
            }
        }
    }
}
