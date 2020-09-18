namespace Sender
{
    class Program
    {
        static void Main()
        {
            //string path = "";
            //string validTestPath = @"D:\a\environment-case-s21b8\environment-case-s21b8\TemperatureHumiditySampleData.csv";
            string validTestPath = @"C:\Users\320087992\OneDrive - Philips\Desktop\LaunchCase-Study\TemperatureHumiditySampleData";
            HelperFunctions csvFile = new HelperFunctions();
            var readFileWithHeader = csvFile.ReadFileWithHeader(validTestPath);
            var extractDelimiterSeparatedValues = csvFile.ExtractDelimiterSeparatedValues(',');
            var checkAndReplaceEmptyValues = csvFile.CheckAndReplaceEmptyValues();
            var redirectFileOutputToConsole = csvFile.RedirectFileOutputToConsole();
        }
    }
}
