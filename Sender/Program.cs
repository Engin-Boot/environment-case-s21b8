﻿using System;

namespace Sender
{
    class Program
    {
        static void Main()
        {
            //string path = "";
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

        }
    }
}
