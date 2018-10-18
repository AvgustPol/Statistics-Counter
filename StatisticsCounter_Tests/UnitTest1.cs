using StatisticsCounter;
using Xunit;

namespace StatisticsCounter_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ExcelWorker excelWorker = new ExcelWorker();

            excelWorker.AddCellToWorksheetIntoColumnsAB(1, 1 + 42);
        }
    }
}