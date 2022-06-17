using Labb3_SystemTesting;
using System;
using Xunit;

namespace Labb3_systemtestingXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Add_5_And_10_Return_15()
        {
            var add = new Calculator();
            var actual = add.Addition(5, 10);
            var expected = 15;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Subtract_Negative_100_from_50_Return_Negative_150()
        {
            var sub = new Calculator();
            var actual = sub.Subtract(-100, 50);
            var expected = -150;
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(10, 2, 20)]
        [InlineData(5, 5, 25)]
        [InlineData(100, 10, 1000)]
        [InlineData(12, 12, 144)]
        [InlineData(3, 8, 24)]
        [InlineData(-4, 7, -28)]
        public void Theory_Multiply_Data(double value1, double value2, double expected)
        {
            var multiply = new Calculator();
            var res = multiply.Multiply(value1, value2);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Devide_100_With_10_Return_10()
        {
            var dev = new Calculator();
            var actual = dev.Devide(100, 10);
            var expected = 10;
            Assert.Equal(expected, actual);
            
        }
    }
}
