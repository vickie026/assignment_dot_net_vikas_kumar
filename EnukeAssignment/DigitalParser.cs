using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EnukeAssignment
{
    public class DigitalParser
    {
        private string InputFile;
        private string OutputFile;
        private List<string> _InputLines;
        private List<string> _OutputLines;
        public DigitalParser(string InputFile, string OutputFile)
        {
            this.InputFile = InputFile;
            this.OutputFile = OutputFile;
        }
        private void ReadInput()
        {
            _InputLines = new List<string>();
            using (StreamReader reader = new StreamReader(InputFile))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if(line == null)
                    {
                        line = "";
                    }
                    _InputLines.Add(line);

                } while (!reader.EndOfStream);
            }
        }
        private void WriteOutput(string[] lines)
        {
            using(StreamWriter writer = new StreamWriter(OutputFile))
            {
                foreach(string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
        public void ProcessDigits()
        {
            int length = 3;
            ReadInput();
            string[] inputLines = _InputLines.ToArray<string>();
            _OutputLines = new List<string>();
            for (int i = 0; i < inputLines.Length - 2; i = i + 4)
            {
                string result = "";
                if( ( (i - 3) % 4 ) != 0 )
                {
                    string record1 = inputLines[i];
                    string record2 = inputLines[i + 1];
                    string record3 = inputLines[i + 2];

                    for(int j = 0; j < record1.Length; j = j + length)
                    {
                        string line1 = record1.Substring(j, length);
                        string line2 = record2.Substring(j, length);
                        string line3 = record3.Substring(j, length);
                        result += DigitParser(line1, line2, line3);
                    }
                    _OutputLines.Add(result);
                }
            }
            WriteOutput(_OutputLines.ToArray<string>());
        }
        private bool IsDigitParsedToZero(string line1, string line2, string line3)
        {
            return line1 == " _ " && line2 == "| |" && line3 == "|_|";
        }
        private bool IsDigitParsedToOne(string line1, string line2)
        {
            return (line1 == "  |" && line2 == "  |");
        }
        private bool IsDigitParsedToTwo(string line1, string line2, string line3)
        {
            return line1 == " _ " && line2 == " _|" && line3 == "|_ ";
        }
        private bool IsDigitParsedToThree(string line1, string line2, string line3)
        {
            return line1 == " _ " && line2 == " _|" && line3 == " _|";
        }
        private bool IsDigitParsedToFour(string line1, string line2)
        {
            return line1 == "|_|" && line2 == "  |";
        }
        private bool IsDigitParsedToFive(string line1, string line2, string line3)
        {
            return line1 == " _ " && line2 == "|_ " && line3 == " _|";
        }
        private bool IsDigitParsedToSix(string line1, string line2, string line3)
        {
            return line1 == " _ " && line2 == "|_ " && line3 == "|_|";
        }
        private bool IsDigitParsedToSeven(string line1, string line2, string line3)
        {
            return line1 == " _ " && line2 == "  |" && line3 == "  |";
        }
        private bool IsDigitParsedToEight(string line1,string line2, string line3)
        {
            return line1 == " _ " && line2 == "|_|" && line3 == "|_|";
        }
        private bool IsDigitParsedToNine(string line1, string line2, string line3)
        {
            return line1 == " _ " && line2 == "|_|" && line3 == " _|";
        }
        private string DigitParser(string line1, string line2, string line3)
        {
            if(line1 == "   ")
            {
                if(IsDigitParsedToOne(line2, line3))
                {
                    return "1";
                }
                if(IsDigitParsedToFour(line2, line3))
                {
                    return "4";
                }
            }
            if(IsDigitParsedToZero(line1, line2, line3))
            {
                return "0";
            }
            if(IsDigitParsedToTwo(line1, line2, line3))
            {
                return "2";
            }
            if(IsDigitParsedToThree(line1, line2, line3))
            {
                return "3";
            }
            if(IsDigitParsedToFive(line1, line2, line3))
            {
                return "5";
            }
            if(IsDigitParsedToSix(line1, line2, line3))
            {
                return "6";
            }
            if(IsDigitParsedToSeven(line1, line2, line3))
            {
                return "7";
            }
            if(IsDigitParsedToEight(line1, line2, line3))
            {
                return "8";
            }
            if(IsDigitParsedToNine(line1, line2, line3))
            {
                return "9";
            }
            return "?";
        }
    }
}
