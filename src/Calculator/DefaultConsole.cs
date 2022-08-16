using System;

namespace Calculator
{
    class DefaultConsole : IConsole
    {
        string IConsole.ReadLine()
        {
            return Console.ReadLine();
        }

        void IConsole.WriteLine(string input)
        {
            Console.WriteLine(input);
        }

        void IConsole.WriteLine(string input, params object[] args)
        {
            Console.WriteLine(input, args);
        }

        void IConsole.Write(string input)
        {
            Console.WriteLine(input);
        }
    }
}