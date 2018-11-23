using StatisticsCounter;
using Xunit;

namespace StatisticsCounter_Tests
{
    public class MedianCounter_Test
    {
        [Fact]
        public void Median_Should_be_Six()
        {
            //a
            double[] testArray = new double[] { 1, 3, 3, 6, 7, 8, 9 };
            double expectedResult = 6;

            //act
            double result = MedianCounter.CountMedian(testArray);

            //assert
            Assert.True(result == expectedResult);
        }

        [Fact]
        public void Median_Should_be_fourAndHalf()
        {
            //a
            double[] testArray = new double[] { 1, 2, 3, 4, 5, 6, 8, 9 };
            double expectedResult = 4.5;

            //act
            double result = MedianCounter.CountMedian(testArray);

            //assert
            Assert.True(result == expectedResult);
        }
    }
}