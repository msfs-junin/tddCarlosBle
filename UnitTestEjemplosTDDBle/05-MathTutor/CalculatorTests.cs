using EjemplosTDDBle._05_MathTutor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System;

namespace UnitTestEjemplosTDDBle._05_MathTutor
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator _calculator;

        [TestInitialize]
        public void SetUp()
        {
            _calculator = new Calculator(-100,100);
        }

        [TestMethod]
        public void Add()
        {
            int result = _calculator.Add(2, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void AddWithDifferentArguments()
        { 
            int result = _calculator.Add(2, 5);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Substract()
        {
            int result = _calculator.Substract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SubstractReturningNegative()
        {
            int result = _calculator.Substract(3, 5);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void SubstractSettingLimitValues()
        {
            try
            {
                int result = _calculator.Substract(10, 150);
                Assert.Fail("Exception is not being thrown when " + "exceeding lower limit");
            }
            catch (OverflowException)
            {

            }
        }

        [TestMethod]
        public void SetAndGetUpperLimit()
        {
            Calculator calculator = new Calculator(-100, 100);
            Assert.AreEqual(100, calculator.limiteSuperior);
            Assert.AreEqual(-100, calculator.limiteInferior);
        }


         [TestMethod]
         public void AddExcedingUpperLimit()
         {
            Calculator calculator = new Calculator(-100, 100);
             try
             {
                int result = calculator.Add(10, 150);
                Assert.Fail("This should fail: we’re exceding upper limit");
             }
             catch (OverflowException)
             {
                // Ok, the SUT works as expected
             }
        }

        [TestMethod]
        public void ArgumentsExceedLimits()
        {
            Calculator calculator = new Calculator(-100, 100);
            try
            {
                calculator.Add(calculator.limiteSuperior + 1, calculator.limiteInferior - 1);
                Assert.Fail("This should fail: arguments exceed limits");
            }
            catch (OverflowException)
            {
                // Ok, this works
            }
        }

        [TestMethod]
        public void ArgumentsExceedLimitsInverse()
        {
            Calculator calculator = new Calculator(-100, 100);
            try
            {
                calculator.validador().validarLimitesDeArgumento(calculator.limiteInferior - 1, calculator.limiteSuperior+ 1);
                Assert.Fail("This should fail: arguments exceed limits");
            }
            catch (OverflowException)
            {
                // Ok, this works
            }
        }

        [TestMethod]
        public void ArgumentsExceedLimitsOnSubstract()
        {
            Calculator calculator = new Calculator(-100, 100);
            try
            {
                calculator.validador().validarLimitesDeArgumento(calculator.limiteSuperior + 1, calculator.limiteInferior - 1);
                Assert.Fail("This should fail: arguments exceed limits");
            }
            catch (OverflowException)
            {
                // Ok, this works
            }
        }

        [TestMethod]
        public void SubstractIsUsingValidator()
        {
            int arg1 = 10;
            int arg2 = -20;
            int upperLimit = 100;
            int lowerLimit = 100;
            var validatorMock = MockRepository.GenerateStrictMock<ILimitsValidator>();
            validatorMock.Expect(x => x.validarLimitesDeArgumento(arg1, arg2));

            Calculator calculator = new Calculator(validatorMock);
            calculator.Add(arg1, arg2);

            validatorMock.VerifyAllExpectations();
        }

    }
}
