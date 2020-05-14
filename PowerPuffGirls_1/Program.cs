using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPuffGirls_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());

            if (testCases >= 1 && testCases <= 100000)
            {
                var final_plan = new int[testCases];
                for (int j = 0; j < testCases; j++)
                {
                    var number_Of_Players = Convert.ToInt32(Console.ReadLine());
                    if (number_Of_Players >= 1 && number_Of_Players <= 100000)
                    {
                        var GRTeam = Console.ReadLine().Split(' ')
                            .Where(x => !string.IsNullOrEmpty(x) && Convert.ToInt64(x) >= 0 && Convert.ToInt64(x) <= long.MaxValue)
                            .Select(x => Convert.ToInt64(x)).OrderBy(x => x).ToArray();

                        var OPTeam = Console.ReadLine().Split(' ')
                            .Where(x => !string.IsNullOrEmpty(x) && Convert.ToInt64(x) >= 0 && Convert.ToInt64(x) <= long.MaxValue)
                            .Select(x => Convert.ToInt64(x)).ToList<long>();

                        var winCount = 0;
                        for (int i = 0; i < GRTeam.Length; i++)
                        {
                            var grT_val = GRTeam[i];
                            for (int k = 0; k < OPTeam.Count; k++)
                            {
                                if (grT_val > OPTeam[k])
                                {
                                    OPTeam.RemoveAt(k);
                                    winCount++;
                                    break;
                                }
                            }
                        }

                        final_plan[j] = winCount;
                    }
                }

                foreach (var val in final_plan)
                {
                    Console.WriteLine(val);
                }

                Console.ReadLine();
            }
        }
    }
}
