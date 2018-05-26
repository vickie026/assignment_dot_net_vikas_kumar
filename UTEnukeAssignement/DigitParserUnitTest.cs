using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using EnukeAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTEnukeAssignement
{
    [TestClass]
    public class DigitParserUnitTest
    {
        [TestMethod]
        public void Test_ProcessDigits()
        {
            //arrange
            string InputFile = @"C:\Users\DELL\source\repos\EnukeAssignment\UTEnukeAssignement\UnitTestParseDigit\test_input_file.txt";
            string OutputFile = @"C:\Users\DELL\source\repos\EnukeAssignment\UTEnukeAssignement\UnitTestParseDigit\test_output_file.txt";
            DigitalParser parser = new DigitalParser(InputFile, OutputFile);

            //act
            parser.ProcessDigits();
            var expectedHash = GetFileHash(@"C:\Users\DELL\source\repos\EnukeAssignment\UTEnukeAssignement\UnitTestParseDigit\test_expected_output_file.txt");
            var actualHash = GetFileHash(OutputFile);

            //assert
            Assert.AreEqual(expectedHash, actualHash);
        }
        public string GetFileHash(string filename)
        {
            var hash = new SHA1Managed();
            var clearBytes = File.ReadAllBytes(filename);
            var hashedBytes = hash.ComputeHash(clearBytes);
            return ConvertBytesToHex(hashedBytes);
        }

        public string ConvertBytesToHex(byte[] bytes)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x"));
            }
            return sb.ToString();
        }

    }
}
