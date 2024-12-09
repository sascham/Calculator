using System;
using System.Collections.Generic;
using System.Text;
using LoreSoft.MathExpressions.UnitConversion;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace LoreSoft.MathExpressions.Tests.UnitConversion
{
    [TestFixture()]
    public class MassConverterTest
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
            double result = MassConverter.Convert(
                MassUnit.Ounce, MassUnit.Pound, 12);
            Assert.That(result, Is.EqualTo(0.75).Within(0.000001));

            result = MassConverter.Convert(
                MassUnit.Pound, MassUnit.Ounce, 0.75);
            Assert.That(result, Is.EqualTo(12).Within(0.000001));

            result = MassConverter.Convert(
                MassUnit.Kilogram, MassUnit.Pound, 1);
            Assert.That(result, Is.EqualTo(2.2046226218487757d).Within(0.000001));

            result = MassConverter.Convert(
                MassUnit.Ton, MassUnit.Pound, 1);
            Assert.That(result, Is.EqualTo(2000d).Within(0.000001));
        }
    }
}