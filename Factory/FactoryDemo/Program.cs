using AbstractFactory.Factory;
using AbstractFactoryImplementation.Factory;
using SingletonWriteLine;
using System;

namespace FactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonWriter SCW = SingletonWriter.GetConsoleWrite;

            char choice = 'm';
            IVehicles vehicles = null; // #REVIEW: Use plural naming when you have a collection of items not for single item.

            SCW.Write("Enter m for motored vechicle and n for non motored vechile");
            try
            {
                choice = Console.ReadLine().Trim().ToCharArray()[0];
            }
            catch (Exception)
            {
                SCW.Write("An Error Occurred");
            }

            int wheels = 0;

            SCW.Write("Enter the number of wheels needed");
            try
            {
                wheels = Convert.ToInt32(Console.ReadLine().Trim()); // #REVIEW: +1 for using trim.
            }
            catch (Exception)
            {
                // #REVIEW: Use your version of logger. Do not write to console directly.
                Console.WriteLine("An Error Occurred");
            }

            switch (choice)
            {
                case 'm':
                case 'M':
                    vehicles = new MotoredVehicleFactory();
                    break;
                case 'n':
                case 'N':
                    vehicles = new NonMotoredVehicleFactory();
                    break;
                default:
                    SCW.Write("Not A valid Vehicle Type");
                    break;
            }

            // #REVIEW: +1 for Defensive programming (null check). Will save you lots of trouble. Highly encourage this.
            if (vehicles != null)
            {
                var vehicle = vehicles.Create(wheels);
                
                // #REVIEW: what if choice is 'N'?
                // #REVIEW: Not an elegant way to handle this scenario.
                /*
                 * Why can't both factories raise a custom exception when no.of wheels are not supported
                 * and the exception message can be logged in via the logger.
                 */
                if (vehicle == null && choice == 'n')
                {
                    SCW.Write($"Non-motored vehicles with {wheels} wheels cannot be made in our factory.");
                }
                else if (vehicle == null)
                {
                    SCW.Write($"Motored vehicles with {wheels} wheels cannot be made in our factory.");
                }
                else
                {
                    SCW.Write(vehicle);
                    SCW.Write(choice,wheels); // #REVIEW: This line is not formatted.
                }

            }

            Console.ReadKey();

            /* #REVIEW: Other comments: Really liked the way you have kept models internal.
             * Although in a full time real project you will need to keep it public since it has to be referenced elsewhere.
             * But in this specific project we are just using strings and no object parameter is used therefore
             * keeping them internal makes sense.
             * Minimum exposure to classes and their members is a good practice.
             * +1 for that.
            */
        }
    }
}
