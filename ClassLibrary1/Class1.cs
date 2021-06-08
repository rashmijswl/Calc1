using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Calc1;

using System.Threading.Tasks;

namespace UnitTestCalc2
{
    [TestFixture]
    public class UnitTestCalc2
    {
        Program calc = new Program();
        [Test]
        public void Add_Positive_Number()
        {

            double a = 5, b = 4;//arrange
            double res = calc.addition(a, b); //act
            Assert.AreEqual(res, 9); //assert

        }

        [Test]
        public void Add_Negative_Number()
        {
            double a = -75, b = -4;//arrange
            double res = calc.addition(a, b); //act
            Assert.AreEqual(res, -79); //assert

        }

        [Test]
        public void Add_Negative_Positive_Number()
        {
            double a = -15, b = 4;//arrange
            double res = calc.addition(a, b); //act
            Assert.AreEqual(res, -11); //assert
        }

        [Test]
        public void Substract_Positive_Number()
        {
            double a = 15, b = 74;//arrange
            double res = calc.subtraction(a, b); //act
            Assert.AreEqual(res, -59); //assert

        }

        [Test]
        public void Substract_Negative_Number()
        {
            double a = -5, b = -4;//arrange
            double res = calc.subtraction(a, b); //act
            Assert.AreEqual(res, -1); //assert

        }

        [Test]
        public void Substract_Negative_Positive_Number()
        {
            double a = -5, b = 84;//arrange
            double res = calc.subtraction(a, b); //act
            Assert.AreEqual(res, -89); //assert

        }

        [Test]
        public void Multiply_Positive_Number()
        {
            double a = 3, b = 8;//arrange
            double res = calc.multiplication(a, b); //act
            Assert.AreEqual(res, 24); //assert

        }

        [Test]
        public void Multiply_Negative_Number()
        {
            double a = -9, b = -4;//arrange
            double res = calc.multiplication(a, b); //act
            Assert.AreEqual(res, 36); //assert

        }

        [Test]
        public void Multiply_Negative_Positive_Number()
        {
            double a = -5, b = 14;//arrange
            double res = calc.multiplication(a, b); //act
            Assert.AreEqual(res, -70); //assert

        }

        [Test]
        public void Divide_Positive_Number()
        {
            double a = 100, b = 20;//arrange
            double res = calc.division(a, b); //act
            Assert.AreEqual(res, 5); //assert

        }

        [Test]
        public void Divide_Negative_Number()
        {
            double a = -10, b = -100;//arrange
            double res = calc.division(a, b); //act
            Assert.AreEqual(res, 0.1); //assert

        }

        [Test]
        public void Divide_Negative_Positive_Number()
        {
            double a = 84, b = -5;//arrange
            double res = calc.division(a, b); //act
            Assert.AreEqual(res, -16.8); //assert

        }

    }
}
