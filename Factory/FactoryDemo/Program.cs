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
            IVehicles vehicles = null;

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
                // #REVIEW: Converting to strings should be implemented by encapsulation in the abstraction
                // of logger that you created. Console project should not have the responsibility to convert to strings
                // Converting to strings in the console project should only be done for specific cases when our 
                // abstraction(logger) is not able to convert to strings.
                var vehicle = vehicles.Create(wheels);
                
                // #REVIEW: This condition is contradictory. We already have defended against vehicle being null. How will vehicle then be null.
                // This condition is always false.
                // #REVIEW: Setting a flag in case the vehicle is not valid and checking the flag is a much elegant way to get the correct message.
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
                    SCW.Write(choice,wheels); // #REVIEW: This line is not formatted
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
