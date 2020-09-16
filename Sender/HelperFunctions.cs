using System;
using System.Collections.Generic;
using System.IO;

namespace Sender
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

        public string ReadFileWithHeader(string path)
        {
            if (ValidatePath(path))
            {
                lineNumber = 0;

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
                status = "File read successfully!";
            }
            else
            {
                status = "File not found in the specified path...";
            }
            return status;
        }
        private string status = "";
        public string ExtractDelimiterSeparatedValues(char delimiter)
        {
            if (fileContents.Count > 0)
            {
                foreach (KeyValuePair<int, string> keyValue in fileContents)
                {
                    int lineNumber = keyValue.Key;
                    string line = keyValue.Value;
                    values = line.Split(delimiter);

                    if (!line.Contains(delimiter.ToString()))
                        status = "Delimiter not in file...";
                    else
                        status = "Correct delimiter supplied...";

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
            else
            {
                status = "File read operation not performed...";

            }
            return status;
        }
        public string CheckAndReplaceEmptyValues()
        {

            if (columnValues.Count != 0)
            {
                noOfColumns = columnNames.GetLength(0);
                for (int i = 0; i < columnValues.Count; i++)
                {
                    if (columnValues[i] == "")
                        columnValues[i] = ValueNotPresent;
                }
                status = "Column values extracted successfully...";
            }
            else
            {
                noOfColumns = 0;
                status = "Column Values not extracted...";
            }
            return status;
        }
        public string RedirectFileOutputToConsole()
        {
            if (columnValues.Count > 0)
            {
                for (int i = 0; i < columnValues.Count; i++)
                {
                    int columnno = i % noOfColumns;
                    WriteToConsole(columnNames[columnno], columnValues[i]);
                }
                status = "Redirection to console successfull...";
            }
            else
            {
                status = "No column values present. Cannot redirect output to console...";
            }
            return status;
        }

        public void WriteToConsole(string columnName, string value)
        {
            Console.WriteLine(columnName + ": " + value + " ");
        }



        private int lineNumber;
        private string line;
        private Dictionary<int, string> fileContents = new Dictionary<int, string>();

        private string[] columnNames = { };
        public string[] values;

        private int noOfColumns;
        private List<string> columnValues = new List<string>();
    }
}
