using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sender.Tests
{
    public class HelperFunctionsTests
    {
        Sender.HelperFunctions testObject = new HelperFunctions();
        private string emptyTestPath = " ";
        private string validTestPath = @"C:\Users\320087992\Documents\Bootcamp\environment-case-s21b8\TemperatureHumiditySampleData.csv ";
        string status;
        [Fact]
        public void ValidatePath_ShouldCheckIfFileExists()
        {
            
            bool expectedResult = false;
            Assert.True(testObject.ValidatePath(emptyTestPath) == expectedResult);

            expectedResult = true;
            Assert.True(testObject.ValidatePath(validTestPath) == expectedResult);
        }

        [Fact]
        public void ReadFileWitheader_SouldReadFile()
        {
            
            status = testObject.ReadFileWithHeader(emptyTestPath);
            Assert.True(status == "File not found in the specified path...");

            
            status = testObject.ReadFileWithHeader(validTestPath);
            Assert.True(status == "File read successfully!");
        }

        [Fact]
        public void ExtractDelimiterSeparatedValues_ShouldPopulateColumnNamesAndValues()
        {
            status = testObject.ExtractDelimiterSeparatedValues(',');
            Assert.True(status == "File read operation not performed...");

            status = testObject.ReadFileWithHeader(validTestPath);
            status = testObject.ExtractDelimiterSeparatedValues(':');
            Assert.True(status == "Delimiter not in file...");

            status = testObject.ExtractDelimiterSeparatedValues(',');
            Assert.True(status == "Correct delimiter supplied...");
        }

        [Fact]
        public void CheckAndReplaceEmptyValues_ShouldReplaceEmptyValueWithMessage()
        {

            status = testObject.CheckAndReplaceEmptyValues();
            Assert.True(status == "Column Values not extracted...");

            status = testObject.ReadFileWithHeader(validTestPath);
            status = testObject.ExtractDelimiterSeparatedValues(',');
            status = testObject.CheckAndReplaceEmptyValues();
            Assert.True(status == "Column values extracted successfully...");

        }

        [Fact]
        public void RedirectFileOutputToConsole_ShouldWriteToConsole()
        {
            status = testObject.RedirectFileOutputToConsole();
            Assert.True(status == "No column values present. Cannot redirect output to console...");

            status = testObject.ReadFileWithHeader(validTestPath);
            status = testObject.ExtractDelimiterSeparatedValues(',');
            status = testObject.CheckAndReplaceEmptyValues();
            status = testObject.RedirectFileOutputToConsole();
            Assert.True(status == "Redirection to console successfull...");
        }
    }
}
