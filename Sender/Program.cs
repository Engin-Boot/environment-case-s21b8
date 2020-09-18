using System;

namespace Sender
{
    class Program
    {
        static void Main()
        {
            //string path = "";
<<<<<<< HEAD
            //string validTestPath = @"D:\a\environment-case-s21b8\environment-case-s21b8\TemperatureHumiditySampleData.csv";
            string validTestPath = @"C:\Users\320087992\OneDrive - Philips\Desktop\LaunchCase-Study\TemperatureHumiditySampleData";
            HelperFunctions csvFile = new HelperFunctions();
            var readFileWithHeader = csvFile.ReadFileWithHeader(validTestPath);
            var extractDelimiterSeparatedValues = csvFile.ExtractDelimiterSeparatedValues(',');
            var checkAndReplaceEmptyValues = csvFile.CheckAndReplaceEmptyValues();
            var redirectFileOutputToConsole = csvFile.RedirectFileOutputToConsole();
=======
            string validTestPath = @"C:\Users\320087877\OneDrive - Philips\Documents\EM\TemperatureHumiditySampleData.csv";

            HelperFunctions csvFile = new HelperFunctions();

            string ReadFileWithHeader_status = csvFile.ReadFileWithHeader(validTestPath);
            string ExtractDelimiterSeparatedValues_status = csvFile.ExtractDelimiterSeparatedValues(',');
            string CheckAndReplaceEmptyValues_status = csvFile.CheckAndReplaceEmptyValues();
            string RedirectOutputToConsole_status = csvFile.RedirectFileOutputToConsole();
            Console.WriteLine(ReadFileWithHeader_status);

            //var readFileWithHeader = csvFile.ReadFileWithHeader(validTestPath);
            //var extractDelimiterSeparatedValues = csvFile.ExtractDelimiterSeparatedValues(',');
            var checkAndReplaceEmptyValues = csvFile.CheckAndReplaceEmptyValues();
            //var redirectFileOutputToConsole = csvFile.RedirectFileOutputToConsole();

>>>>>>> 3dc5f2fab43a94ed0909a1e245df91cdd67a084d
        }
    }
}
