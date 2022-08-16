using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Calculator
{
    public class ProgramTests
    {

        [Fact]
        public void ShouldReturnErrorOfZeroDivide()
        {

            MockConsole mockConsole = new MockConsole();
            Program program = new Program();
            program.MyConsole = mockConsole;

            StringBuilder _stringBuilder = new StringBuilder();

            mockConsole.Output.Enqueue("2");
            mockConsole.Output.Enqueue("0");
            mockConsole.Output.Enqueue("d");
            mockConsole.Output.Enqueue("n");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            program.RunCalculator();
            var expectedResult = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "Type another number, and then press Enter: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "This operation will result in a mathematical error." +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedResult, Regex.Replace(mockConsole.Inputs.ToString(), @"[\r\t\n]+", string.Empty));

        }


        [Fact]
        public void ShouldDoRunWithMockConsole()
        {
            MockConsole mockConsole = new MockConsole();
            Program program = new Program();
            program.MyConsole = mockConsole;
            mockConsole.Output.Enqueue("2");
            mockConsole.Output.Enqueue("2");
            mockConsole.Output.Enqueue("a");
            mockConsole.Output.Enqueue("n");

            program.RunCalculator();
            var expected =
                "Console Calculator in C#" +
                "------------------------" +
                "Type a number, and then press Enter: " +
                "Type another number, and then press Enter: " +
                "Choose an operator from the following list:" +
                "a - Add" +
                "s - Subtract" +
                "m - Multiply" +
                "d - Divide" +
                "Your option? " +
                "Your result: 4" +
                "------------------------" +
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expected, Regex.Replace(mockConsole.Inputs.ToString(), @"[\r\t\n]+", string.Empty));
        }

        [Fact]
        public void ShouldDoRunWithNotValidInputWithMockConsole()
        {
            MockConsole mockConsole = new();
            Program program = new();
            program.MyConsole = mockConsole;
            mockConsole.Output.Enqueue("a");
            mockConsole.Output.Enqueue("11");
            mockConsole.Output.Enqueue("s");
            mockConsole.Output.Enqueue("0");
            mockConsole.Output.Enqueue("d");
            mockConsole.Output.Enqueue("n");

            program.RunCalculator();
            var expected =
                "Console Calculator in C#" +
                "------------------------" +
                "Type a number, and then press Enter: " +
                "This is not valid input. Please enter an integer value: " +
                "Type another number, and then press Enter: " +
                "This is not valid input. Please enter an integer value: " +
                "Choose an operator from the following list:" +
                "a - Add" +
                "s - Subtract" +
                "m - Multiply" +
                "d - Divide" +
                "Your option? " +
                "This operation will result in a mathematical error." +
                "------------------------" +
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expected, Regex.Replace(mockConsole.Inputs.ToString(), @"[\r\t\n]+", string.Empty));
        }
    }
}