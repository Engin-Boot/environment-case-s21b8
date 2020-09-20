using System;
using System.Collections.Generic;
using System.IO;

namespace Sender
{
    public class HelperFunctions
    {
        #region ValidatePath: returns if the given file exists in the specified path

        public bool ValidatePath(string path)
        {
            return File.Exists(path);
        }

        #endregion


        #region ReadFileWithHeader: reads file having column names
        public string ReadFileWithHeader(string path)
        {
            if (ValidatePath(path))
            {
                _lineNumber = 0;

                using (var reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        _line = reader.ReadLine();
                        _lineNumber += 1;
                        _fileContents.Add(_lineNumber, _line);

                    }
                }

                _status = "File read successfully!";
            }
            else
            {
                _status = "File not found in the specified path...";
            }
            return _status;
        }


        #endregion


        #region ExtractDelimiterSeparatedValues: extract values given a valid delimiter

        public string ExtractDelimiterSeparatedValues(char delimiter)
        {
            foreach (KeyValuePair<int, string> keyValue in _fileContents)
            {

                int lineNumber = keyValue.Key;
                string line = keyValue.Value;
                Values = line.Split(delimiter);

                _status = !line.Contains(delimiter.ToString()) ? "Delimiter not in file..." : "Correct delimiter supplied...";

                if (lineNumber == 1)
                    _columnNames = Values;
                else
                {
                    foreach (var value in Values)
                    {
                        _columnValues.Add(value);
                    }
                }
            }


            return _status;
        }

        #endregion


        #region CheckAndReplaceEmptyValues: Checks for empty values and replaces them with "Value not present"
        public string CheckAndReplaceEmptyValues()
        {
            _status = "Column Values not extracted...";

            _noOfColumns = _columnNames.GetLength(0);
            for (int i = 0; i < _columnValues.Count; i++)
            {
                if (_columnValues[i] == "")
                    _columnValues[i] = ValueNotPresent;
                _status = "Empty column values replaced successfully...";
            }
           

            return _status;
        }


        #endregion


        #region RedirectFileOutputToConsole: Calls WriteToConsole to print
        public string RedirectFileOutputToConsole()
        {
            if (_columnValues.Count > 0)
            {
                for (int i = 0; i < _columnValues.Count; i++)
                {
                    int column = i % _noOfColumns;
                    WriteToConsole(_columnNames[column], _columnValues[i]);
                }
                _status = "Redirection to console successful...";
            }
            else
            {
                _status = "No column values present. Cannot redirect output to console...";
            }
            return _status;
        }


        #endregion


        #region WriteToconsole Function: prints to console
        private void WriteToConsole(string columnName, string value)
        {
            Console.WriteLine(columnName + ": " + value + " ");
        }


        #endregion


        #region constants

        private const string ValueNotPresent = "Value Not Present";
        #endregion

        #region variables
        private int _lineNumber;
        private string _line;
        private readonly Dictionary<int, string> _fileContents = new Dictionary<int, string>();
        private string[] _columnNames = { };
        public string[] Values { get; set; }
        private int _noOfColumns;
        private string _status = "";
        private readonly List<string> _columnValues = new List<string>();
        #endregion

    }
}
