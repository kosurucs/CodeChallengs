using System;
using System.Linq;
using System.Text;

namespace ProxyClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numberOfStudnets = Convert.ToInt32(Console.ReadLine());
            if (numberOfStudnets >= 1 || numberOfStudnets <= 100)
            {
                var attendcies = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x))
                    .Select(x => Convert.ToInt32(x))
                    .Distinct()
                    .OrderBy(x => x)
                    .ToArray();
                var missingStudents = new StringBuilder();
                if (attendcies.Length <= numberOfStudnets)
                {
                    for (int i = 1; i <= numberOfStudnets; i++)
                    {
                        int count = 0;
                        foreach (var student in attendcies)
                        {
                            if (i == student)
                            {
                                count++;
                                break;
                            }
                        }
                        if (count == 0)
                        {
                            missingStudents.Append(i).Append(' ');
                        }
                    }
                }
                Console.WriteLine(missingStudents.ToString().TrimEnd());
            }

            Console.ReadLine();
        }
    }
}
