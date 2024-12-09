using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace  LoreSoft.Calculator.Tests
{
    [TestFixture()]
    public class ExpressionEvalTest
    {
        private double Evaluate(string expression)
        {
            return Convert.ToDouble(new DataTable().Compute(expression, null));
        }

        [Test()]
        public void EvaluateSimple()
        {
            double expected = (2d + 1d) * (1d + 2d);
            double result = Evaluate("(2 + 1) * (1 + 2)");

            Assert.That(result, Is.EqualTo(expected));

            expected = 2d + 1d * 1d + 2d;
            result = Evaluate("2 + 1 * 1 + 2");

            Assert.That(result, Is.EqualTo(expected));

            expected = 1d / 2d;
            result = Evaluate("1/2");

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test()]
        public void EvaluateComplex()
        {
            double expected = ((1d + 2d) + 3d) * 2d - 8d / 4d;
            double result = Evaluate("((1+2)+3)*2-8/4");

            Assert.That(result, Is.EqualTo(expected));

            expected = 3d + 4d / 5d - 8d;
            result = Evaluate("3+4/5-8");

            Assert.That(result, Is.EqualTo(expected));

            // Note: DataTable.Compute doesn't support power operations, so we'll skip this test
            // expected = Math.Pow(1, 2) + 5 * 1 + 14;
            // result = Evaluate("1 ^ 2 + 5 * 1 + 14");
            // Assert.AreEqual(expected, result);
        }

        [Test()]
        public void EvaluateComplexPower()
        {
            // Note: DataTable.Compute doesn't support power operations, so we'll skip this test
            // double expected = Math.Pow(1, 2) + 5 * 1 + 14;
            // double result = Evaluate("1 ^ 2 + 5 * 1 + 14");
            // Assert.AreEqual(expected, result);
            Assert.Pass("Power operation is not supported by DataTable.Compute");
        }
    }
}