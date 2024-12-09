using System;
using System.Collections.Generic;
using System.Text;
using LoreSoft.MathExpressions.UnitConversion;
using NUnit.Framework;

namespace LoreSoft.MathExpressions.Tests.UnitConversion
{
    [TestFixture()]
    public class TemperatureConverterTest
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
            double result = TemperatureConverter.Convert(
                TemperatureUnit.Celsius, TemperatureUnit.Fahrenheit, -40d);
            Assert.That(result, Is.EqualTo(-40));

            result = TemperatureConverter.Convert(
                TemperatureUnit.Celsius, TemperatureUnit.Fahrenheit, 0);
            Assert.That(result, Is.EqualTo(32));

            result = TemperatureConverter.Convert(
                TemperatureUnit.Fahrenheit, TemperatureUnit.Celsius, 212);
            Assert.That(result, Is.EqualTo(100));

            result = TemperatureConverter.Convert(
                TemperatureUnit.Fahrenheit, TemperatureUnit.Kelvin, 212);
            Assert.That(result, Is.EqualTo(373.15));
        }
    }
}