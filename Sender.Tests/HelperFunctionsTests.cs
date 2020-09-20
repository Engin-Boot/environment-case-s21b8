using Xunit;

namespace Sender.Tests
{
    public class HelperFunctionsTests
    {

        HelperFunctions testObject = new HelperFunctions();
        private string emptyTestPath = " ";
        private string validTestPath = @"D:\a\environment-case-s21b8\environment-case-s21b8\TemperatureHumiditySampleData.csv";
        //private readonly string validTestPath = @"C:\Users\320087992\OneDrive - Philips\Desktop\LaunchCase-Study\TemperatureHumiditySampleData.csv";
        string _status;

        [Fact]
        public void ValidatePath_ShouldCheckIfFileExists()
        {

            bool expectedResult = false;
            Assert.True(testObject.ValidatePath(emptyTestPath) == expectedResult);

            expectedResult = true;
            Assert.True(testObject.ValidatePath(validTestPath) == expectedResult);
        }

        [Fact]
        public void ReadFileWithHeader_ShouldReadFile()
        {

            _status = testObject.ReadFileWithHeader(emptyTestPath);
            Assert.True(_status == "File not found in the specified path...");


            _status = testObject.ReadFileWithHeader(validTestPath);
            Assert.True(_status == "File read successfully!");
        }

        [Fact]
        public void ExtractDelimiterSeparatedValues_ShouldPopulateColumnNamesAndValues()
        {
           
            _status = testObject.ReadFileWithHeader(validTestPath);
            _status = testObject.ExtractDelimiterSeparatedValues(':');
            Assert.True(_status == "Delimiter not in file...");

            _status = testObject.ExtractDelimiterSeparatedValues(',');
            Assert.True(_status == "Correct delimiter supplied...");
        }

        [Fact]
        public void CheckAndReplaceEmptyValues_ShouldReplaceEmptyValueWithMessage()
        {

            _status = testObject.CheckAndReplaceEmptyValues();
            Assert.True(_status == "Column Values not extracted...");

            _status = testObject.ReadFileWithHeader(validTestPath);
            _status = testObject.ExtractDelimiterSeparatedValues(',');
            _status = testObject.CheckAndReplaceEmptyValues();
            Assert.True(_status == "Empty column values replaced successfully...");

        }

        [Fact]
        public void RedirectFileOutputToConsole_ShouldWriteToConsole()
        {
            _status = testObject.RedirectFileOutputToConsole();
            Assert.True(_status == "No column values present. Cannot redirect output to console...");

            _status = testObject.ReadFileWithHeader(validTestPath);
            _status = testObject.ExtractDelimiterSeparatedValues(',');
            _status = testObject.CheckAndReplaceEmptyValues();
            _status = testObject.RedirectFileOutputToConsole();
            Assert.True(_status == "Redirection to console successful...");
        }
    }
}
