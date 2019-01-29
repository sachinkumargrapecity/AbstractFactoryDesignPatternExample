
using AbstractVehicleFactory.Model;

namespace AbstractFactory.Factory
{
    public interface IVehicles
    {
        Vehicle Create(int wheels);
    }
}