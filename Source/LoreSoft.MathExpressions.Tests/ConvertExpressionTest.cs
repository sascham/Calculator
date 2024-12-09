using System;
using System.Collections.Generic;
using System.Text;
using LoreSoft.MathExpressions;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace  LoreSoft.MathExpressions.Tests
{
    [TestFixture()]
    public class ConvertExpressionTest
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
        public void IsConvertExpression()
        {
            bool result = ConvertExpression.IsConvertExpression("blah");
            Assert.That(result, Is.False);

            result = ConvertExpression.IsConvertExpression("[m->ft]");
            Assert.That(result, Is.True);

            result = ConvertExpression.IsConvertExpression("[ms->ft]");
            Assert.That(result, Is.False);

        }

        [Test]
        public void Convert()
        {
            ConvertExpression e = new ConvertExpression("[in->ft]");
            Assert.That(e, Is.Not.Null);

            double feet = e.Convert(new double[] { 12d });
            Assert.That(feet, Is.EqualTo(1));
        }
    }
}