using System;
using System.Collections.Generic;
using System.IO;

namespace ReadWriteFunctionality
{
    public class HelperFunctions
    {
        public const string ValueNotPresent = "Value Not Present";
        public bool ValidatePath(string path)
        {
            if (File.Exists(path))
                return true;
            else
                return false;
        }
        
        public void ReadFileWithHeader(string path)
        {
            lineNumber = 0;
            fileContents = new Dictionary<int, string>();
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    lineNumber += 1;

                    if (fileContents.ContainsKey(lineNumber))
                        fileContents[lineNumber] = line;
                    else
                        fileContents.Add(lineNumber, line);
                }
            }
        }

        public void ExtractDelimiterSeparatedRowValues(char delimiter)
        {
            foreach(KeyValuePair<int, string> keyValue in fileContents)
            {
                int lineNumber = keyValue.Key;
                string line = keyValue.Value;

                values = line.Split(delimiter);
                if (lineNumber == 1)
                    columnNames = values;
                else
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        columnValues.Add(values[i]);
                    }
                }
            }
        }
        public void CheckAndReplaceEmptyValues()
        {
            if (columnValues.Count != 0)
            {
                for (int i = 0; i < columnValues.Count; i++)
                {
                    if (columnValues[i] == "")
                        columnValues[i] = ValueNotPresent;
                }
            }
            else
            {
                Console.WriteLine("Column Values not extracted...");
            }
            
        }
        public void RedirectOutputToConsole()
        {
            noOfColumns = columnNames.GetLength(0);
            for (int i = 0; i < columnValues.Count; i++)
            {
                int columnno = i % noOfColumns;
                WriteToConsole(columnNames[columnno], columnValues[i]);
            }
        }

        public void WriteToConsole(string columnName, string value)
        {
            Console.WriteLine(columnName + ": " + value + " ");
        }



        private int lineNumber;
        private string line;
        Dictionary<int, string> fileContents;

        private string[] columnNames;
        private string[] values;
        
        private int noOfColumns;
        private HelperFunctions getHelperFunction;

        List<string> columnValues = new List<string>();
    }
}
