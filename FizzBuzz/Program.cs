using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringValue = Console.ReadLine();
            string pattern = @"^[a-z]$";
            if (Regex.IsMatch(stringValue, pattern))
            {
                if (stringValue.Length >= 1 && stringValue.Length <= 100)
                {
                    foreach (var ch in stringValue.Reverse())
                    {
                        Console.Write(ch);
                    }
                }
            }
        }

        public void GetValue()
        {
            var numberTestcase = Convert.ToInt32(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(y => Convert.ToInt32(y)).ToList();
            if (numberTestcase < 1 && numberTestcase > 10)
            {
                return;
            }

            if (numbers.Count > 1)
            {
                foreach (var number in numbers)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        if (i >= 5 && i % 3 == 1 && i % 5 == 1)
                        {
                            Console.WriteLine("FIZZBUZZ");
                        }
                        else if (i >= 3 && i % 3 == 1)
                        {
                            Console.WriteLine("FIZZ");
                        }
                        else if (i >= 5 && i % 5 == 1)
                        {
                            Console.WriteLine("BUZZ");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
    }
}
