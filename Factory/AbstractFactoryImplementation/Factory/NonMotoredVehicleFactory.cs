using AbstractFactory.Factory;
using AbstractFactoryImplementation.Exceptions;
using AbstractFactoryImplementation.Model.NonMotor;
using AbstractVehicleFactory.Model;

namespace AbstractFactoryImplementation.Factory
{
    public class NonMotoredVehicleFactory : IVehicleFactory
    {
        public VehicleModel Create(int wheels)
        {
            switch (wheels)
            {
                case 1: return new OneWheelCycleModel();
                case 2: return new BicycleModel();
                case 3: return new TricycleModel();
                case 4: return new FourWheelCartModel();
                case 5: return new FiveWheelNonMotorModel();
                case 6: return new SixWheelCycleModel();
                default: throw new NoVehicleFoundException($"Non-motored vehicles with {wheels} wheels cannot be made in our factory.");
            }
        }
    }
}