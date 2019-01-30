
using AbstractVehicleFactory.Model;

namespace AbstractFactory.Factory
{
    /// <summary>
    /// #REVIEW: I Really like keeping only one contract called 'Create' and the switch statement. +1 for that.
    /// Later if you are interested you can even remove that switch statement by 'Strategy Pattern'.
    /// This is optional read it if interested.
    /// </summary>
    public interface IVehicleFactory
    {
        VehicleModel Create(int wheels);
    }
}