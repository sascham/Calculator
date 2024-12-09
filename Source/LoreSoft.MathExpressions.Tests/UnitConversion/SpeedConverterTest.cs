using System;
using System.Collections.Generic;
using System.Text;
using LoreSoft.MathExpressions.UnitConversion;
using NUnit.Framework;

namespace  LoreSoft.MathExpressions.Tests.UnitConversion
{
    [TestFixture()]
    public class SpeedConverterTest
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
        public void Example()
        {
            double result = SpeedConverter.Convert(
                SpeedUnit.MeterPerSecond, SpeedUnit.KilometerPerHour, 60);
            Assert.That(result, Is.EqualTo(216d));

            result = SpeedConverter.Convert(
                SpeedUnit.MilePerHour, SpeedUnit.KilometerPerHour, 60);
            Assert.That(result, Is.EqualTo(96.560639999999992d));
        }
    }
}