using System;
using System.IO;

namespace StatisticsCounter
{
    public class ToFileLogger
    {
        public readonly String DEFAULT_FILE_NAME = @"D:\7 semestr\Metaheurystyki\Data\Result\newdoc.csv";

        public void LogToLocalObject()
        {
        }

        public void Log(int generationsCounter, double getBestFitness, double getAverageFitness, double getWorstFitness)
        {
            File.AppendAllLines(DEFAULT_FILE_NAME,
                new[] { $"{generationsCounter},{getBestFitness},{getAverageFitness},{getWorstFitness}" });
        }
    }
}