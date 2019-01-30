using System;

namespace SingletonWriteLine
{
    /// <summary>
    /// #REVIEW: There is no need to name it like this, simple 'Logger' would have sufficed.
    /// </summary>
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
