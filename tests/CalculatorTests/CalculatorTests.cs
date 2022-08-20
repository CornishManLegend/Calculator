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
            Assert.Equal(4.0, result);
        }

        [Fact]
        public void checkSubstraction()
        {
            LibraryCalculator calculator = new LibraryCalculator();
            double result = calculator.DoOperation(2, 2, "s");
            Assert.Equal(0, result);
        }

        [Fact]
        public void checkMultiplication()
        {
            LibraryCalculator calculator = new LibraryCalculator();
            double result = calculator.DoOperation(2, 2, "m");
            Assert.Equal(4, result);
        }

        [Fact]
        public void checkDivision()
        {
            LibraryCalculator calculator = new LibraryCalculator();
            double result = calculator.DoOperation(2, 2, "d");
            Assert.Equal(1, result);
        }

        [Fact]
        public void doNothing()
        {
            LibraryCalculator calculator = new LibraryCalculator();
            double result = calculator.DoOperation(2, 2, "ddd");
            Assert.Equal(double.NaN, result);
        }

        [Fact]
        public void shouldDoNothing()
        {
            LibraryCalculator calculator = new LibraryCalculator();
            double result = calculator.DoOperation(2, 2, "");
            Assert.Equal(double.NaN, result);
        }



    }
}