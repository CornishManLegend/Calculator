using System.Text;

namespace Calculator
{
    internal class MockConsole : IConsole
    {
        public StringBuilder Inputs { get; set; } = new StringBuilder();
        public Queue<string> Output { get; set; } = new Queue<string>();

        public string ReadLine()
        {
            return Output.Dequeue();
        }

        public void Write(string input)
        {
            Inputs.Append(input);
        }

        public void WriteLine(string input)
        {
            Inputs.AppendLine(input);
        }

        public void WriteLine(string input, params object[] args)
        {
            Inputs.AppendLine(string.Format(input, args));
        }
    }
}