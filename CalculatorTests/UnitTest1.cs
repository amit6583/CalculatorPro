using System;
using System.Collections.Generic;
using NUnit.Framework;
namespace CalcLibrary
{
    [TestFixture]
    public class CalculatorTests
    {
        double result, Sresult, Mresult, Dresult;
        
        [SetUp]
        public void SetUpMethod()
        {
            Sresult = 0;
            result=0;
            Mresult = 0;
            Dresult = 0;
            
        }

        //ADD


        [Test]
        public void CalculatorAddMethod()
        {
            Calculator add = new Calculator();
            result = add.Addition(40, 20);
            Assert.AreEqual(60, result);
        }
        [Test]
        [TestCase(20, 25, 45)]
        //[Repeat(3)]
        [MaxTime(200)]
        public void CalculatorAddMethod(int x, int y, int expected)
        {
            Calculator add = new Calculator();
            result = add.Addition(x, y);
            Assert.AreEqual(expected, result);
        }
        





        //SUBSTRACT
        [Test]
        public void Calculatesubstract()
        {
            Calculator sub = new Calculator();
            Sresult = sub.Subtraction(40, 60);
            Assert.AreEqual(20, Sresult);
        }
        [Test]
        [TestCase(80, 40, 40)]
        [TestCase(45, 55, 10)]
        public void CalculatorSubParameter(int x, int y, int expected)
        {
            Calculator sub = new Calculator();
            Sresult = sub.Subtraction(x, y);
            Assert.AreEqual(expected, Sresult);
        }

        //MULTIPLICATION


        [Test]
        public void CalculateMultiplication()
        {
            Calculator mul = new Calculator();
            Mresult = mul.Multiplication(4, 6);
            Assert.AreEqual(24, Mresult);
        }
        [Test]
        [TestCase(8, 2, 16)]
        [TestCase(5, 5, 25)]
        public void CalculatorMulParameter(int x, int y, int expected)
        {
            Calculator mul = new Calculator();
            Mresult = mul.Multiplication(x, y);
            Assert.AreEqual(expected, Mresult);
        }

        //DIVISION

        [Test]
        public void CalculateDivision()
        {
            Calculator div = new Calculator();
            Dresult = div.Division(24, 6);
            Assert.AreEqual(4, Dresult);
        }
        [Test]
        [TestCase(8, 2, 4)]
        [TestCase(5, 0, 0)]
        public void CalculatorDivParameter(int x, int y, int expected)
        {
            Calculator div = new Calculator();
            try
            {
                if (y == 0)
                {
                    Dresult = div.Division(x, y);
                    Assert.Fail("Division by zero");
                }
                else
                {
                    Dresult = div.Division(x, y);
                    Assert.AreEqual(expected, Dresult);
                }
            }
            catch (ArgumentException e)
            {
                List<string> messages = new List<string> { e.Message };
                Assert.Contains("Attempted to divide by zero.", messages);
            }
        }
        [TearDown]
        public void CleanUpMethod()
        {
            Sresult = 0;
            result = 0;
            Mresult = 0;
            Dresult = 0;
        }
    }
}