using AbstractFactory.Factory;
using AbstractFactoryImplementation.Exceptions;
using AbstractFactoryImplementation.Factory;
using LoggerSpace;
using System;

namespace FactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.GetConsoleWrite;

            char choice = 'm';
            IVehicle vehicle = null; 

            logger.Write("Enter m for motored vechicle and n for non motored vechile");
            try
            {
                choice = Console.ReadLine().Trim().ToCharArray()[0];
            }
            catch (Exception)
            {
                logger.Write("An Error Occurred");
            }

            int wheels = 0;

            logger.Write("Enter the number of wheels needed");
            try
            {
                wheels = Convert.ToInt32(Console.ReadLine().Trim()); // #REVIEW: +1 for using trim.
            }
            catch (Exception)
            {
                logger.Write("An Error Occurred");
            }

            switch (choice)
            {
                case 'm':
                case 'M':
                    vehicle = new MotoredVehicleFactory();
                    break;
                case 'n':
                case 'N':
                    vehicle = new NonMotoredVehicleFactory();
                    break;
                default:
                    logger.Write("Not A valid Vehicle Type");
                    break;
            }

            // #REVIEW: +1 for Defensive programming (null check). Will save you lots of trouble. Highly encourage this.
            if (vehicle != null)
            {
                try
                {
                    var vehicleCreated = vehicle.Create(wheels);
                    logger.Write((object)vehicleCreated);
                    logger.Write(choice, wheels);
                }
                catch(NoVehicleFoundException e)
                {
                    logger.Write(e.Message);
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
