using System;

namespace StatisticsCounter
{
    public static class StandardDeviationCounter
    {
        public static double CountStandardDeviation(double average, double[] variables)
        {
            double tmp = 0;
            for (int i = 0; i < variables.Length; i++)
            {
                tmp += (variables[i] - average) * (variables[i] - average);
            }

            tmp /= variables.Length;
            return Math.Sqrt(tmp);
        }
    }
}