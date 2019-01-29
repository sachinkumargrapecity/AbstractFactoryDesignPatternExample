using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;
using AbstractFactoryImplementation.Factory;
using SingletonWriteLine;

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
            try
            {
                SCW.Write("Enter the number of wheels needed");
                wheels = Convert.ToInt32(Console.ReadLine().Trim());
            }
            catch (Exception)
            {
                Console.WriteLine("An Error Occurred");
            }

            switch(choice)
            {
                case 'm':
                case 'M': vehicles = new MotoredVehicleFactory();
                    break;
                case 'n':
                case 'N': vehicles = new NonMotoredVehicleFactory();
                    break;
                default: SCW.Write("Not A valid Vehicle Type");
                    break;
            }

            if (vehicles != null)
            {
                string vehicle = vehicles.Create(wheels).ToString();
                SCW.Write(vehicle);
                if(!vehicle.Contains("cannot be made in our factory"))
                    SCW.Write(choice,wheels);
            }

            Console.ReadKey();
        }
    }
}
