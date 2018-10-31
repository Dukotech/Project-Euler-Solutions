using System;
using Xunit;
using ProjectEuler;

namespace ProjectEuler.Tests
{
    public class ProblemTests
    {
        [Fact]
        public void Problem1_ShouldReturn_233168()
        {
<<<<<<< HEAD
            Assert.Equal(Problem4.LargestThreeDigitPalindrome(), 906609);
        }

        [Fact]
        public void Problem8_ShouldReturn_23514624000()
        {
            Assert.Equal(Problem4.LargestThreeDigitPalindrome(), 906609);
        }

=======
            Assert.Equal(Problem1.SumOfDivision(), 233168);
        }

>>>>>>> upstream/master
        [Fact]
        public void Problem2_ReturnResult_4613732()
        {
            Assert.Equal(Problem2.FibonacciEvenNumbersSum(0, 1, 0), 4613732);
<<<<<<< HEAD
=======
        }

        [Fact]
        public void Problem3_ShouldReturn_6857()
        {
            Assert.Throws<NotImplementedException>(() => 
            {
                Problem3.GetResult();
            });
        }

        [Fact]
        public void Problem4_ShouldReturn_906609()
        {
            Assert.Equal(Problem4.LargestThreeDigitPalindrome(), 906609);
>>>>>>> upstream/master
        }

        [Fact]
        public void Problem5_ShouldReturn_232792560()
        {
            Assert.Throws<NotImplementedException>(() => 
            {
                Problem5.GetResult();
            });
        }
        
        [Fact]
        public void Problem6_ShouldReturn_25164150()
        {
            Assert.Equal(Problem6.SumSquareDifference(), 25164150);
        }

        [Fact]
        public void Problem7_ShouldReturn_104743()
        {
            Assert.Equal(Problem7.Problem7Answer(), 104743);
        }

        [Fact] 
        public void Problem8_ShouldReturn_23514624000()
        {
           Assert.Equal(Problem8.GetResult(), 23514624000);
        }

        [Fact]
        public void Problem9_ShouldReturn_31875000()
        {
            Assert.Equal(Problem9.Pythagorean(), 31875000);
        }

        [Fact]
        public void Problem10_ShouldReturn_142913828922()
        {
            Assert.Throws<NotImplementedException>(() => 
            {
                Problem10.GetResult();
            });
        }

        [Fact]
        public void Problem11_ShouldReturn_70600674()
        {
            Assert.Throws<NotImplementedException>(() => 
            {
                Problem11.GetResult();
            });
        }

        [Fact]
        public void Problem12_ShouldReturn_76576500()
        {
            Assert.Throws<NotImplementedException>(() => 
            {
                Problem12.GetResult();
            });
        }

        [Fact]
        public void Problem13_ShouldReturn_5537376230()
        {
            Assert.Throws<NotImplementedException>(() => 
            {
                Problem13.GetResult();
            });
        }

        [Fact]
        public void Problem14_ShouldReturn_837799()
        {
            Assert.Throws<NotImplementedException>(() => 
            {
                Problem14.GetResult();
            });
        }

        [Fact]
        public void Problem15_ShouldReturn_137846528820()
        {
            Assert.Throws<NotImplementedException>(() => 
            {
                Problem15.GetResult();
            });
        }

        [Fact]
        public void Problem16_ShouldReturn_1366()
        {
            Assert.Equal(Problem16.Problem16Answer(), 1366);
        }

        [Fact]
        public void Problem17_ShouldReturn_21124()
        {
            Assert.Throws<NotImplementedException>(() => 
            {
                Problem17.GetResult();
            });
        }

<<<<<<< HEAD
        [Fact]
        public void Problem13_ShouldReturn_5537376230()
        {
            Assert.Equal(Problem13.FirstTenDigit(), "5537376230");
        }

=======
>>>>>>> upstream/master
        [Fact]
        public void Problem18_ShouldReturn_1074()
        {
<<<<<<< HEAD
            Assert.Equal(Problem9.Pythagorean(), 31875000);
=======
            Assert.Throws<NotImplementedException>(() => 
            {
                Problem18.GetResult();
            });
>>>>>>> upstream/master
        }

        [Fact]
        public void Problem19_ShouldReturn_171()
        {
            Assert.Throws<NotImplementedException>(() => 
            {
                Problem19.GetResult();
            });
        }
      
        [Fact]
        public void Problem20_ShouldReturn_648()
        {
            Assert.Equal(Problem20.FactorialDigitSum(), 648);
        }
    }
}
