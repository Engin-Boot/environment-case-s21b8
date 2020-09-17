namespace Sender
{
    class Program
    {
        static void Main()
        {
            //string path = "";
            string validTestPath = @"D:\a\environment-case-s21b8\environment-case-s21b8\TemperatureHumiditySampleData.csv";

            HelperFunctions csvFile = new HelperFunctions();
            var readFileWithHeader = csvFile.ReadFileWithHeader(validTestPath);
            var extractDelimiterSeparatedValues = csvFile.ExtractDelimiterSeparatedValues(',');
            var checkAndReplaceEmptyValues = csvFile.CheckAndReplaceEmptyValues();
            var redirectFileOutputToConsole = csvFile.RedirectFileOutputToConsole();
        }
    }
}
