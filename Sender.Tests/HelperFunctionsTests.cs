using Xunit;

namespace Sender.Tests
{
    public class HelperFunctionsTests
    {

        readonly HelperFunctions _testObject = new HelperFunctions();
        private readonly string _emptyTestPath = " ";
        private readonly string _validTestPath = @"D:\a\environment-case-s21b8\environment-case-s21b8\TemperatureHumiditySampleData.csv";
        //private readonly string validTestPath = @"C:\Users\320087992\OneDrive - Philips\Desktop\LaunchCase-Study\TemperatureHumiditySampleData.csv";
        string _status;

        [Fact]
        public void ValidatePath_ShouldCheckIfFileExists()
        {

            bool expectedResult = false;
            Assert.True(_testObject.ValidatePath(_emptyTestPath) == expectedResult);

            expectedResult = true;
            Assert.True(_testObject.ValidatePath(_validTestPath) == expectedResult);
        }

        [Fact]
        public void ReadFileWithHeader_ShouldReadFile()
        {

            _status = _testObject.ReadFileWithHeader(_emptyTestPath);
            Assert.True(_status == "File not found in the specified path...");


            _status = _testObject.ReadFileWithHeader(_validTestPath);
            Assert.True(_status == "File read successfully!");
        }

        [Fact]
        public void ExtractDelimiterSeparatedValues_ShouldPopulateColumnNamesAndValues()
        {
           
            _status = _testObject.ReadFileWithHeader(_validTestPath);
            _status = _testObject.ExtractDelimiterSeparatedValues(':');
            Assert.True(_status == "Delimiter not in file...");

            _status = _testObject.ExtractDelimiterSeparatedValues(',');
            Assert.True(_status == "Correct delimiter supplied...");
        }

        [Fact]
        public void CheckAndReplaceEmptyValues_ShouldReplaceEmptyValueWithMessage()
        {

            _status = _testObject.CheckAndReplaceEmptyValues();
            Assert.True(_status == "Column Values not extracted...");

            _status = _testObject.ReadFileWithHeader(_validTestPath);
            _status = _testObject.ExtractDelimiterSeparatedValues(',');
            _status = _testObject.CheckAndReplaceEmptyValues();
            Assert.True(_status == "Empty column values replaced successfully...");

        }

        [Fact]
        public void RedirectFileOutputToConsole_ShouldWriteToConsole()
        {
            _status = _testObject.RedirectFileOutputToConsole();
            Assert.True(_status == "No column values present. Cannot redirect output to console...");

            _status = _testObject.ReadFileWithHeader(_validTestPath);
            _status = _testObject.ExtractDelimiterSeparatedValues(',');
            _status = _testObject.CheckAndReplaceEmptyValues();
            _status = _testObject.RedirectFileOutputToConsole();
            Assert.True(_status == "Redirection to console successful...");
        }
    }
}
