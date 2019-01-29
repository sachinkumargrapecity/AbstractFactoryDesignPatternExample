using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    class SingletonConsoleWrite
    {
        private static readonly Lazy<SingletonConsoleWrite> ConsoleWriter = new Lazy<SingletonConsoleWrite>(()=>new SingletonConsoleWrite(),true);

        private SingletonConsoleWrite() { }
        public static SingletonConsoleWrite GetConsoleWrite { get; } = ConsoleWriter.Value;

        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
