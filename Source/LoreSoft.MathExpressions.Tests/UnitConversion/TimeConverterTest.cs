using System;
using System.Collections.Generic;
using System.Text;
using LoreSoft.MathExpressions.UnitConversion;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace LoreSoft.MathExpressions.Tests.UnitConversion
{
    [TestFixture()]
    public class TimeConverterTest
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
        public void Convert()
        {
            double result = TimeConverter.Convert(
                TimeUnit.Hour, TimeUnit.Day, 24);
            Assert.That(result, Is.EqualTo(1));

            result = TimeConverter.Convert(
                TimeUnit.Minute, TimeUnit.Hour, 60);
            Assert.That(result, Is.EqualTo(1));

            result = TimeConverter.Convert(
                TimeUnit.Day, TimeUnit.Week, 7);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}