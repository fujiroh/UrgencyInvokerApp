using System;
using LogicalValueLibrary;
using NUnit.Framework;

namespace LogicalValueLibraryTest
{
    [TestFixture]
    public class LogicalValueTest
    {
        [Test]
        [TestCase(1, 1, true)]
        [TestCase(1.55, 1.55, true)]
        [TestCase(1.55, 1.5, false)]
        [TestCase(.55, 0.55, true)]
        [TestCase(-.55, 0.55, false)]
        [TestCase(null, 1, false)]
        [TestCase(1, null, false)]
        public void Equality_Test(double value1, double value2, bool result)
        {
            var v1 = LogicalValue.Create(value1);
            var v2 = LogicalValue.Create(value2);
            Assert.AreEqual(v1.Equals(v2), result);
        }

        private static readonly object[] _plusTestCase =
        {
            new TestCaseData(LogicalValue.Create(1), LogicalValue.Create(1), LogicalValue.Create(2)),
            new TestCaseData(LogicalValue.Create(100), LogicalValue.Create(-20), LogicalValue.Create(80)),
            new TestCaseData(LogicalValue.Create(1), LogicalValue.Create(-3), LogicalValue.Create(-2)),
            new TestCaseData(LogicalValue.Create(1.55), LogicalValue.Create(1.45), LogicalValue.Create(3)),
            new TestCaseData(LogicalValue.Create(1), LogicalValue.Create(0.5), LogicalValue.Create(1.5)),
        };

        [TestCaseSource(nameof(_plusTestCase))]
        public void Plus_Test(LogicalValue value1, LogicalValue value2, LogicalValue expected)
        {
            var actual = value1 + value2;
            Assert.IsTrue(actual.Equals(expected));
        }

        private static readonly object[] _minusTestCase =
        {
            new TestCaseData(LogicalValue.Create(1), LogicalValue.Create(1), LogicalValue.Create(0)),
            new TestCaseData(LogicalValue.Create(100), LogicalValue.Create(-20), LogicalValue.Create(120)),
            new TestCaseData(LogicalValue.Create(1), LogicalValue.Create(3), LogicalValue.Create(-2)),
            new TestCaseData(LogicalValue.Create(1.55), LogicalValue.Create(1.45), LogicalValue.Create(0.1)),
            new TestCaseData(LogicalValue.Create(1), LogicalValue.Create(0.5), LogicalValue.Create(0.5)),
        };

        [TestCaseSource(nameof(_minusTestCase))]
        public void Minus_Test(LogicalValue value1, LogicalValue value2, LogicalValue expected)
        {
            var actual = value1 - value2;
            Assert.IsTrue(actual.Equals(expected));
        }
        
        private static readonly object[] _multipleTest =
        {
            new TestCaseData(LogicalValue.Create(1), LogicalValue.Create(1), LogicalValue.Create(1)),
            new TestCaseData(LogicalValue.Create(100), LogicalValue.Create(-20), LogicalValue.Create(-2000)),
            new TestCaseData(LogicalValue.Create(1000), LogicalValue.Create(1000), LogicalValue.Create(1000000)),
            new TestCaseData(LogicalValue.Create(-1), LogicalValue.Create(-1), LogicalValue.Create(1)),
            new TestCaseData(LogicalValue.Create(0.5), LogicalValue.Create(0.5), LogicalValue.Create(0.25)),
        };

        [Test]
        [TestCaseSource(nameof(_multipleTest))]
        public void Multiple_Test(LogicalValue value1, LogicalValue value2, LogicalValue expected)
        {
            var actual = value1 * value2;
            Assert.IsTrue(actual.Equals(expected));
        }
        
        private static readonly object[] _divideTest =
        {
            new TestCaseData(LogicalValue.Create(1), LogicalValue.Create(1), LogicalValue.Create(1)),
            new TestCaseData(LogicalValue.Create(100), LogicalValue.Create(-20), LogicalValue.Create(-5)),
            new TestCaseData(LogicalValue.Create(1), LogicalValue.Create(4), LogicalValue.Create(0.25)),
            new TestCaseData(LogicalValue.Create(-1), LogicalValue.Create(-1), LogicalValue.Create(1)),
            new TestCaseData(LogicalValue.Create(0.5), LogicalValue.Create(0.5), LogicalValue.Create(1)),
        };
        
        [Test]
        [TestCaseSource(nameof(_divideTest))]
        public void Divide_Test(LogicalValue value1, LogicalValue value2, LogicalValue expected)
        {
            var actual = value1 / value2;
            Assert.IsTrue(actual.Equals(expected));
        }
    }
}