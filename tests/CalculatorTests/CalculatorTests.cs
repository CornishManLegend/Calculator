using System;
using CalculatorLibrary;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTest1
    {


        [Fact]
        public void checkAddition()
        {
            LibraryCalculator calculator = new LibraryCalculator();
            double result = calculator.DoOperation(2.0, 2.0, "a");
            calculator.Finish();
            Assert.Equal(4.0, result);
        }

        [Fact]
        public void checkSubstraction()
        {
            LibraryCalculator calculator = new LibraryCalculator();
            double result = calculator.DoOperation(2, 2, "s");
            calculator.Finish();
            Assert.Equal(0, result);
        }

        [Fact]
        public void checkMultiplication()
        {
            LibraryCalculator calculator = new LibraryCalculator();
            double result = calculator.DoOperation(2, 2, "m");
            calculator.Finish();
            Assert.Equal(4, result);
        }

        [Fact]
        public void checkDivision()
        {
            LibraryCalculator calculator = new LibraryCalculator();
            double result = calculator.DoOperation(2, 2, "d");
            calculator.Finish();
            Assert.Equal(1, result);
        }

        [Fact]
        public void doNothing()
        {
            LibraryCalculator calculator = new LibraryCalculator();
            double result = calculator.DoOperation(2, 2, "ddd");
            calculator.Finish();
            Assert.Equal(double.NaN, result);
        }



    }
}