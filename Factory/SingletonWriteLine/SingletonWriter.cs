using System;

namespace SingletonWriteLine
{
    /// <summary>
    /// REVIEW: There is no need to name it like this, simple 'Logger' would have sufficed.
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

        public void Write(Object message)
        {
            Console.WriteLine(message);
        }

        // #REVIEW: Good use of overloading above, would have liked if you could have come up 
        // with below method, since I explained that .ToString is a method from Object class
        // and all objects inherit from Object by default.
        // then in the console project: Just do this --> SCW.Write(vehicle);
        //public void Write(object message)
        //{
        //    Console.WriteLine(message);
        //}

        private string TypeOfVehicle(char type)
        {
            // #REVIEW: You could have used a switch statement instead of if/else-if, more elegant than this.
            // #REVIEW: When comparing strings string.Compare(type, 'm', StringComparison.OrdinalIgnoreCase) will be useful if case has to be ignored.
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
            //if (type == 'm') return "Motored";
            //else if (type == 'n') return "Non Motored";
            //else
            //{
            //    return string.Empty; // REVIEW: Never use "" for empty string, use string.Empty
            //}
        }
    }
}
