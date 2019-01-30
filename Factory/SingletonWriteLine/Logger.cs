using System;

namespace LoggerSpace
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> ConsoleWriter = new Lazy<Logger>(() => new Logger(), true);

        private Logger() { }

        public static Logger GetConsoleWrite { get; } = ConsoleWriter.Value;

        public void Write(char type, int wheels)
        {
            Console.WriteLine("Type Of Vehicle: " + TypeOfVehicle(type));
            Console.WriteLine("Number of wheels: " + wheels);
        }

        public void Write(object message)
        {
            Console.WriteLine(message);
        }

        private string TypeOfVehicle(char type)
        {
            switch (type)
            {
                case 'm':
                case 'M':
                    return "Motored";
                case 'n':
                case 'N':
                    return "Non Motored";
                default:
                    return string.Empty;
            }
        }
    }
}
