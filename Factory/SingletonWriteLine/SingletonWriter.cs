using System;

namespace SingletonWriteLine
{
    public class SingletonWriter
    {
        private static readonly Lazy<SingletonWriter> ConsoleWriter = new Lazy<SingletonWriter>(() => new SingletonWriter(), true);

        private SingletonWriter() { }
        public static SingletonWriter GetConsoleWrite { get; } = ConsoleWriter.Value;

        public void Write(char type, int wheels)
        {
            Console.WriteLine("Type Of Vehicle: " + TypeOfVehicle(type));
            Console.WriteLine("Number of wheels: " + wheels);
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }

        private string TypeOfVehicle(char type)
        {
            if (type == 'm') return "Motored";
            else if (type == 'n') return "Non Motored";
            else
            {
                return "";
            }
        }
    }
}
