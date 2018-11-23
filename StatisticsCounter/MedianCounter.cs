using System.Linq;

namespace StatisticsCounter
{
    public class MedianCounter
    {
        public static double CountMedian(double[] numbers)
        {
            int arrayLength = numbers.Length;
            int halfIndex = arrayLength / 2;

            //I want to use LINQ so I need convert array to list
            var numbersList = numbers.ToList();
            numbersList.Sort();

            if (arrayLength % 2 == 1)
            {
                return numbers[halfIndex];
            }
            else
            {
                return (numbersList[halfIndex] + numbersList[halfIndex - 1]) / 2;
            }
        }
    }
}