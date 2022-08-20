namespace Calculator
{
    public interface IConsole
    {
        string ReadLine();
        void Write(string input);
        void WriteLine(string input);
        void WriteLine(string input, params object[] args);
    }
}