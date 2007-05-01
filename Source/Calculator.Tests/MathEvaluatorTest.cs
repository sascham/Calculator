using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Calculator.MathParser;

namespace Calculator.Tests
{
    [TestFixture()]
    public class MathEvaluatorTest
    {
        [SetUp()]
        public void Setup()
        {
            //TODO: NUnit setup
        }

        [TearDown()]
        public void TearDown()
        {
            //TODO: NUnit TearDown
        }

        [Test()]
        public void EvaluateSimple()
        {
            MathEvaluator eval = new MathEvaluator();
            double expected = (2d + 1d) * (1d + 2d);
            double result = eval.Evaluate("(2 + 1) * (1 + 2)");

            Assert.AreEqual(expected, result);

            expected = 2d + 1d * 1d + 2d;
            result = eval.Evaluate("2 + 1 * 1 + 2");

            Assert.AreEqual(expected, result);

            expected = 1d / 2d;
            result = eval.Evaluate("1/2");

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void EvaluateComplex()
        {
            MathEvaluator eval = new MathEvaluator();
            double expected = ((1d + 2d) + 3d) * 2d - 8d / 4d;
            double result = eval.Evaluate("((1+2)+3)*2-8/4");

            Assert.AreEqual(expected, result);

            expected = 3d + 4d / 5d - 8d;
            result = eval.Evaluate("3+4/5-8");

            Assert.AreEqual(expected, result);

            expected = Math.Pow(1, 2) + 5 * 1 + 14;
            result = eval.Evaluate("1 ^ 2 + 5 * 1 + 14");

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void EvaluateComplexPower()
        {
            //TODO: Fix pow support
            MathEvaluator eval = new MathEvaluator();
            double expected = Math.Pow(1, 2) + 5 * 1 + 14;
            double result = eval.Evaluate("1 ^ 2 + 5 * 1 + 14");

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void EvaluateFunctionSin()
        {
            MathEvaluator eval = new MathEvaluator();
            double expected = Math.Sin(45);
            double result = eval.Evaluate("sin(45)");

            Assert.AreEqual(expected, result);

        }

        [Test()]
        public void EvaluateFunctionSinMath()
        {
            MathEvaluator eval = new MathEvaluator();
            double expected = Math.Sin(45) + 45;
            double result = eval.Evaluate("sin(45) + 45");

            Assert.AreEqual(expected, result);

        }

        [Test()]
        public void EvaluateFunctionSinComplex()
        {
            MathEvaluator eval = new MathEvaluator();
            double expected = 10 * Math.Sin(35 + 10) + 10;
            double result = eval.Evaluate("10 * sin(35 + 10) + 10");

            Assert.AreEqual(expected, result);

        }

        [Test()]
        public void EvaluateVariableComplex()
        {
            MathEvaluator eval = new MathEvaluator();
            int i = 10;
            eval.Variables.Add("i", i);

            double expected = Math.Pow(i, 2) + 5 * i + 14;
            double result = eval.Evaluate("i^2+5*i+14");

            Assert.AreEqual(expected, result);

        }

        [Test()]
        public void EvaluateVariableLoop()
        {
            MathEvaluator eval = new MathEvaluator();
            eval.Variables.Add("i", 0);
            double expected = 0;
            double result = 0;

            for (int i = 1; i < 1000000; i++)
            {
                eval.Variables["i"] = i;
                //expected += Math.Pow(i, 2) + 5 * i + 14;
                result += eval.Evaluate("i^2+5*i+14");
            }

            //Assert.AreEqual(expected, result);
        }
    }
}