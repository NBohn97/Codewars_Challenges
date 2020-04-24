using System;
using src;
using Xunit;

namespace codewars.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FixedTest()
        {
            string expected = "How Can Mirrors Be Real If Our Eyes Aren't Real";
            string actual = "How can mirrors be real if our eyes aren't real".ToJadenCase();
            

            Assert.Equal(expected,actual);
        }

        [Fact]
        public void EvenOrOddIndex1()
        {
            Assert.Equal(3, IQ.Test("2 4 7 8 10"));
        }

        [Fact]
        public void EvenOrOddIndex2()
        {
            Assert.Equal(1, IQ.Test("1 2 2"));
        }
        
        [Fact]
        public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
        {
            Assert.True(Triangle.IsTriangle(5, 7, 10));
        }

        [Fact]
        public void IsTriangle_ValidOneSideIsZero_ReturnsFalse()
        {
            Assert.False(Triangle.IsTriangle(5, 7, 0));
        }
        
        [Fact]
        public void IsTriangle_ValidSidesAreTooShort_ReturnsFalse()
        {
            Assert.False(Triangle.IsTriangle(2, 7, 10));
        }

    }
}
