using System.IO;

namespace StatisticsCounter
{
    public class ToFileLogger
    {
        private string Path => _folderPath + _fileName;
        private readonly string _folderPath = @"D:\7 semestr\Metaheurystyki\Data\Result\";
        private readonly string _fileName;

        //private readonly List<StatisticsData> _statistics;

        public ToFileLogger(string fileName)
        {
            _fileName = fileName;
            //_statistics = new List<StatisticsData>();

            //delete old data if exists
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
        }

        public void LogToFile(AverageCounter )
        {
            File.AppendAllLines(Path,
                new[] { $"Generation Number,Best Fitness GA ,Average Fitness GA,Worst Fitness GA, Best Fitness TS", });

            foreach (var stat in _statistics)
            {
                File.AppendAllLines(Path,
                    new[] { $"{stat.GenerationNumber},{stat.BestFitness},{stat.AverageFitness},{stat.WorstFitness}" });
            }
        }

        //public void LogToObject(int generationsCounter, double getBestFitness, double getAverageFitness, double getWorstFitness)
        //{
        //    _statistics.Add(new StatisticsData()
        //    {
        //        GenerationNumber = generationsCounter,
        //        AverageFitness = getAverageFitness,
        //        BestFitness = getBestFitness,
        //        WorstFitness = getWorstFitness
        //    });
        //}
    }
}