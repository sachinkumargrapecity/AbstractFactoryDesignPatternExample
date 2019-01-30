using AbstractFactory.Factory;
using AbstractFactoryImplementation.Model.NonMotor;
using AbstractVehicleFactory.Model;

namespace AbstractFactoryImplementation.Factory
{
    public class NonMotoredVehicleFactory : IVehicle
    {
        public Vehicle Create(int wheels)
        {
            switch (wheels)
            {
                case 1: return new OneWheelCycleModel();
                case 2: return new BicycleModel();
                case 3: return new TricycleModel();
                case 4: return new FourWheelCartModel();
                case 5: return new FiveWheelNonMotorModel();
                case 6: return new SixWheelCycleModel();
                default: return null;
            }
        }
    }
}