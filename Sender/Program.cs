using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = "";
            string validTestPath = @"D:\a\environment-case-s21b8\environment-case-s21b8\TemperatureHumiditySampleData.csv";

            HelperFunctions csvFile = new HelperFunctions();
            string ReadFileWithHeader_status = csvFile.ReadFileWithHeader(validTestPath);
            string ExtractDelimiterSeparatedValues_status = csvFile.ExtractDelimiterSeparatedValues(',');
            string CheckAndReplaceEmptyValues_status = csvFile.CheckAndReplaceEmptyValues();
            string RedirectOutputToConsole_status = csvFile.RedirectFileOutputToConsole();
        }
    }
}
