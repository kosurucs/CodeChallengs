using System;
using System.Linq;

namespace BeOptimized
{
    class Program
    {
        public static void Main()
        {
            var numbersCount = Convert.ToInt32(Console.ReadLine());
            if (numbersCount >= 1 & numbersCount < 10000)
            {
                var numbers = new int[numbersCount];
                for (int k = 0; k < numbersCount; k++)
                {
                    numbers[k] = Convert.ToInt32(Console.ReadLine());
                }

                if (numbers.Any(y => y < 1 || y > 1000))
                {
                    return;
                }

                int duplicateCount = 0;
                foreach (var va in numbers.Select(x => x).Distinct().ToArray())
                {
                    int count = 0;
                    foreach (var va1 in numbers)
                    {
                        if (va1 == va)
                        {
                            count++;
                        }
                    }

                    if (count > 1)
                    {
                        duplicateCount++;
                    }
                }

                Console.Write(duplicateCount);
            }
        }
    }
}
