

namespace AbstractFactory.Factory
{
    /// <summary>
    /// #REVIEW: A comment stating that non-motored vehicle specific contracts could go here in future.
    /// Otherwise an empty interface can also be made to solve DI complexities. A developer reading your 
    /// code may get confused.
    /// 
    /// #REVIEW: Naming could have been better. INonMotoredVehicle instead of INonMotored
    /// </summary>
    public interface INonMotored : IVehicles
    {
    }
}