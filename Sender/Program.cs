using System;
namespace Sender
{
    
    abstract class Program
    {
        static void Main()
        {
            
            var validTestPath = @"D:\a\environment-case-s21b8\environment-case-s21b8\TemperatureHumiditySampleData.csv";
            //string validTestPath = @"C:\Users\320087992\OneDrive - Philips\Desktop\LaunchCase-Study\TemperatureHumiditySampleData";
            var csvFile = new HelperFunctions();
 
            Console.WriteLine(csvFile.ReadFileWithHeader(validTestPath));
            Console.WriteLine(csvFile.ExtractDelimiterSeparatedValues(','));
            Console.WriteLine(csvFile.CheckAndReplaceEmptyValues());
            Console.WriteLine(csvFile.RedirectFileOutputToConsole());

            
        }
    }

    
}
