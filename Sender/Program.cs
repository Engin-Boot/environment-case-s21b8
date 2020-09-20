using System;

namespace Sender
{
    class Program
    {
        static void Main()
        {
            
            var validTestPath = @"D:\a\environment-case-s21b8\environment-case-s21b8\TemperatureHumiditySampleData.csv";
            //string validTestPath = @"C:\Users\320087992\OneDrive - Philips\Desktop\LaunchCase-Study\TemperatureHumiditySampleData";
            HelperFunctions csvFile = new HelperFunctions();
            string _status;

            _status = csvFile.ReadFileWithHeader(validTestPath);
            _status = csvFile.ExtractDelimiterSeparatedValues(',');
            _status = csvFile.CheckAndReplaceEmptyValues();
            _status = csvFile.RedirectFileOutputToConsole();

            //Console.WriteLine(_status);
        }
    }
}
