using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ascii
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int testCaseCount = default(int);
            var testCaseInput = new List<string>();
            GetTestCaseCountValue(ref testCaseCount);
            GetTestCaseInPutValue(ref testCaseInput, testCaseCount);
            DisplayAsciiValues(testCaseInput);
            Console.ReadLine();
        }

        public static void GetTestCaseCountValue(ref int testCaseCount)
        {
            var count = Convert.ToInt16(Console.ReadLine());
            if (count >= 1 && count <= 10)
            {
                testCaseCount = count;
            }
        }

        public static void GetTestCaseInPutValue(ref List<string> testCaseInput, int testCaseCount)
        {
            if (testCaseCount >= 1)
            {
                for (int i = 1; i <= testCaseCount; i++)
                {
                    var inputString = Console.ReadLine();
                    if (!string.IsNullOrEmpty(inputString))
                    {
                        if (1 <= inputString.Length && inputString.Length <= 100)
                        {
                            Match match = Regex.Match(inputString, @"([A-Za-z0-9\-]+)", RegexOptions.None);
                            if (match.Success)
                            {
                                testCaseInput.Add(inputString);
                            }
                        }
                    }
                }
            }
        }

        public static void DisplayAsciiValues(List<string> testCaseInput)
        {
            foreach (var value in testCaseInput)
            {
                StringBuilder stringResult = new StringBuilder();
                foreach (char charValue in value)
                {
                    stringResult.Append((int)charValue);
                }

                Console.WriteLine(stringResult);
            }
        }
    }
}
