using ReadWriteFunctionality;
using System;
using System.Collections.Generic;
using System.IO;

namespace EnvironmentMonitoringDataSource
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\320087992\Documents\Bootcamp\environment-case-s21b8\TemperatureHumiditySampleData.csv";

            HelperFunctions csvFile = new HelperFunctions();

            if (csvFile.ValidatePath(path))
            {
                csvFile.ReadFileWithHeader(path);
                csvFile.ExtractDelimiterSeparatedRowValues(',');
                csvFile.CheckAndReplaceEmptyValues();
                csvFile.RedirectOutputToConsole();
            }
                
            else
                Console.WriteLine("File does not exist in the specified path...");
        }
    }
}
