using AbstractFactory.Factory;
using AbstractFactoryImplementation.Factory;
using LoggerSpace;
using System;

namespace FactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger SCW = Logger.GetConsoleWrite;

            char choice = 'm';
            IVehicle vehicles = null; // #REVIEW: Use plural naming when you have a collection of items not for single item.

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
                SCW.Write("An Error Occurred");
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
                try
                {
                    var vehicle = vehicles.Create(wheels);
                    SCW.Write(vehicle);
                    SCW.Write(choice, wheels);
                }
                catch(Exception e)
                {
                    SCW.Write(e.Message);
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
