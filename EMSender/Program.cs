﻿using Sender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSender
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";
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
