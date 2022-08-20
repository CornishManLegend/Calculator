using System;

namespace Calculator
{
    public interface IConsole
    {
        string ReadLine();
        void Write(string input);
        void WriteLine(string input);
        void WriteLine(string input, params object[] args);
    }

    public class DefaultConsole : IConsole
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