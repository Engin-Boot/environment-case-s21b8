using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public class Driver
    {
        static void Main(string[] args)
        {
            //get path
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
