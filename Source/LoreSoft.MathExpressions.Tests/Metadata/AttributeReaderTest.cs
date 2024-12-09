using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using LoreSoft.MathExpressions.Metadata;
using LoreSoft.MathExpressions.UnitConversion;

namespace LoreSoft.MathExpressions.Tests.Metadata
{
    [TestFixture()]
    public class AttributeReaderTest
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
        public void GetDescription()
        {
            string result = AttributeReader.GetDescription<SpeedUnit>(SpeedUnit.MilePerHour);
            Assert.That(result, Is.EqualTo("Mile/Hour"));

            result = AttributeReader.GetDescription<SpeedUnit>(SpeedUnit.Knot);
            Assert.That(result, Is.EqualTo("Knot"));



        }

        [Test()]
        public void GetAbbreviation()
        {
            string result = AttributeReader.GetAbbreviation<SpeedUnit>(SpeedUnit.MilePerHour);
            Assert.That(result, Is.EqualTo("mph"));

            result = AttributeReader.GetAbbreviation<SpeedUnit>(SpeedUnit.Knot);
            Assert.That(result, Is.EqualTo("knot"));



        }
    }
}