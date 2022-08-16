namespace Calculator
{
    public interface IConsole
    {
        void WriteLine(string input);
        void WriteLine(string input, params object[] args);
        void Write(string input);
        string ReadLine();
    }
}