using System;
using System.Collections.Generic;
using System.Linq;

namespace WinOrLose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cases = Convert.ToInt16(Console.ReadLine());
            if (cases < 1 || cases > 10)
            {
                return;
            }

            LoadTestCase(cases);
            Console.ReadLine();
        }

        public static void LoadTestCase(int caseCount)
        {
            var villanStrength = new Dictionary<int, long[]>();
            var playersEnergies = new Dictionary<int, long[]>();

            for (int i = 0; i < caseCount; i++)
            {
                var players = Convert.ToInt32(Console.ReadLine());

                if (players < 1 || players > 1000)
                {
                    return;
                }
                var villan = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(x => Convert.ToInt64(x)).OrderByDescending(x => x).ToArray();
                var player = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(x => Convert.ToInt64(x)).OrderByDescending(x => x).ToArray();
                if (villan.Any(x => x < 1 || x > 100000) || player.Any(y => y < 1 || y > 100000))
                {
                    return;
                }

                villanStrength.Add(i, villan);
                playersEnergies.Add(i, player);
            }

            var result = GetStrage(villanStrength, playersEnergies, caseCount);
            foreach (var val in result)
            {
                Console.WriteLine(val);
            }
        }

        public static string GetStatusOfGame(long[] villanStrength, long[] playersEnergies)
        {
            for (int i = 0; i < playersEnergies.Length; i++)
            {
                for (int j = 0; j < villanStrength.Length; j++)
                {
                    if (playersEnergies[i] < villanStrength[j])
                    {
                        if (i >= j)
                        {
                            continue;
                        }
                        else
                        {
                            return "LOSE";
                        }
                    }
                }
            }

            return "WIN";
        }

        public static List<string> GetStrage(Dictionary<int, long[]> villanStrength, Dictionary<int, long[]> playersEnergies, int testCaseCount)
        {
            var values = new List<string>();
            for (int i = 0; i < testCaseCount; i++)
            {
                values.Add(GetStatusOfGame(villanStrength[i], playersEnergies[i]));
            }

            return values;
        }
    }
}
