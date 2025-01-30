using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryTest.Nunit
{
    [TestFixture]
    internal class CalculatorTest_Nunit
    {
        [Test]
        public void Calculator_Add_Positive()
        {
            //Arrange
            Calculator c = new Calculator();
            int a = 10, b = 10;
            int expectedResult = 20;
            //Act
            int actualResult = c.Add(a, b);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Calculator_Add_Negative()
        {
            //Arrange
            Calculator c = new Calculator();
            int a = 10, b = 10;
            int expectedResult = 110;
            // Act
            int actualResult = c.Add(a, b);
            //Assert

            Assert.AreNotEqual(expectedResult, actualResult);//if true- pass
        }

        [Test]

        public void Calculator_Sub_Positive()
        {
            // Arrange
            Calculator c = new Calculator();
            int a = 10, b = 5;
            int expectedResult = 5;

            //Act
            int actualResult = c.Sub(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Calculator_Sub_Negative()
        {
            //Arrange
            Calculator c = new Calculator();
            int a = 10, b = 5;
            int expectedResult = 10;

            //Act
            int actualResult = c.Sub(a, b);
            //Assert
            Assert.AreNotEqual(expectedResult, actualResult);

        }

        [Test]
        public void Calculator_Add_MaxValue()
        {
            Calculator c=new Calculator();
            int a=int.MaxValue, b=int.MaxValue;
            int expectedResult = 0;

            int actualResult=c.Add(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
