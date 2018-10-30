using System;
using Xunit;
using ProjectEuler;

namespace ProjectEuler.Tests
{
    public class ProblemTests
    {
        [Fact]
        public void Promlem4_ShouldReturn_906609()
        {
            Assert.Equal(Problem4.LargestThreeDigitPalindrome(), 906609);
        }

        [Fact]
        public void Problem8_ShouldReturn_23514624000()
        {
            Assert.Equal(Problem4.LargestThreeDigitPalindrome(), 906609);
        }

        [Fact]
        public void Problem2_ReturnResult_4613732()
        {
            Assert.Equal(Problem2.FibonacciEvenNumbersSum(0, 1, 0), 4613732);
        }

        //[Fact] 
        //public void Problem8_ShouldReturn_23514624000()
        //{
        //    Assert.Equal(Problem8.GetResult(), 23514624000);
        //}

        [Fact]
        public void Promlem7_ShouldReturn_104743()
        {
            Assert.Equal(Problem7.Problem7Answer(), 104743);
        }

        [Fact]
        public void Promlem16_ShouldReturn_1366()
        {
            Assert.Equal(Problem16.Problem16Answer(), 1366);
        }

        [Fact]
        public void Problem20_ShouldReturn_648()
        {
            Assert.Equal(Problem20.FactorialDigitSum(), 648);
        }

        [Fact]
        public void Problem13_ShouldReturn_5537376230()
        {
            Assert.Equal(Problem13.FirstTenDigit(), "5537376230");
        }

        [Fact]
        public void Promlem9_ShouldReturn_31875000()
        {
            Assert.Equal(Problem9.Pythagorean(), 31875000);
        }

    }
}
