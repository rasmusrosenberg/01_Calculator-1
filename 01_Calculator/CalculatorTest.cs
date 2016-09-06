using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(4, Calculator.Add(2, 2));
            Assert.AreEqual(8, Calculator.Add(2, 6));
        }
        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }
        [TestMethod]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[2];
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

        }
        [TestMethod]
        public void Multiply() {

            //It multiplies two 
            int[] numbers = new int[] { 7, 11 };
            Assert.AreEqual(77, Calculator.Multiply(numbers));

            //It multiplies several numbers
            int[] arguments = new int[] { 7, 11, 5, 8 };
            Assert.AreEqual(3080, Calculator.Multiply(arguments));
        }
        [TestMethod]
        public void Power()
        {
            //It raises one number to the power of another number
            Assert.AreEqual(216, Calculator.Power(6, 3));
        }
        [TestMethod]
        public void Factorial()
        {
            //# http://en.wikipedia.org/wiki/Factorial
            //  it "computes the factorial of 0"
            Assert.AreEqual(1, Calculator.Factorial(0));
            //  it "computes the factorial of 1"
            Assert.AreEqual(1, Calculator.Factorial(1));
            //  it "computes the factorial of 2"
            Assert.AreEqual(2, Calculator.Factorial(2));
            //  it "computes the factorial of 5"
            Assert.AreEqual(120, Calculator.Factorial(5));
            //  it "computes the factorial of 10"
            Assert.AreEqual(3628800, Calculator.Factorial(10));
        }
    }
}
