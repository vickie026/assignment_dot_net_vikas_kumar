using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnukeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Choose the method Execute : ");
            Console.WriteLine(" Enter : ");
            Console.WriteLine("\n 1 MarcoPolo : ");
            Console.WriteLine("\n 2 Merge The Sorted Arrays");
            Console.WriteLine("\n 3 Parse The Digits\n");
            Console.Write(" Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    int limit = 100;
                    MarcoPolo marco = new MarcoPolo(limit);
                    Console.WriteLine(marco.Start());
                    break;
                case 2:
                    int[] FirstArray = { 2, 8, 11, 15, 21, 27, 33, 45 };
                    int[] SecondArray = { 1, 3, 4, 5, 17, 22, 35, 44, 50 };
                    MergeSortedArrays merger = new MergeSortedArrays(FirstArray, SecondArray);
                    merger.Merge();
                    int[] result = merger.MergedArray;
                    foreach(int i in result)
                    {
                        Console.Write(i + ", ");
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    string InputFilePath = @"..\..\ParseDigitData\input\";
                    string OutputFilePath = @"..\..\ParseDigitData\output\";
                    string InputFileName = "input_user_story_1.txt";
                    string OutputFileName = "output_user_story_1.txt";
                    DirectoryInfo DirInfo = new DirectoryInfo(OutputFilePath);
                    if(!DirInfo.Exists)
                    {
                        DirInfo.Create();
                    }
                    DigitalParser parser = new DigitalParser(InputFilePath + InputFileName, OutputFilePath + OutputFileName);
                    parser.ProcessDigits();
                    Console.WriteLine("\n Output has been generated... Please check at : "+DirInfo.Parent.Parent+ OutputFilePath.Substring(5) + OutputFileName +"\n");
                    break;
                default :
                    Console.WriteLine("\n Invalid Choice ..Please try again");
                    break;
            }
            
        }

    }
}
