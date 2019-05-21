using System;
using System.Collections.Generic;
using System.Linq;

namespace Neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCases = Convert.ToInt16(Console.ReadLine());
            if (testCases >= 1 && testCases <= 10)
            {
                var testCaseValues = new Dictionary<int, short[]>();
                for (int i = 0; i < testCases; i++)
                {
                    var numberOfhouses = Convert.ToInt16(Console.ReadLine());
                    if (numberOfhouses >= 1 && numberOfhouses <= 10000)
                    {
                        var tickerNumbers = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x))
                                                                   .Select(x => Convert.ToInt16(x))
                                                                   .OrderByDescending(x => x).ToArray();

                        if (tickerNumbers.Any(x => x < -1000 && x > 1000))
                        {
                            return;
                        }
                        else
                        {
                            testCaseValues.Add(i, tickerNumbers);
                        }
                    }
                }

                foreach (var caseValues in testCaseValues)
                {
                    var sortValues = caseValues.Value.Where(x => x > 0).OrderByDescending(x => x).ToArray<short>();
                    var maxVal = sortValues[0];
                    if (sortValues.Length > 1)
                    {
                        for (int i = 1; i < sortValues.Length; i++)
                        {
                            int nextVal = i + 1;
                            if (IsSecondValueInSequences(maxVal, sortValues[i]))
                            {
                                if (sortValues.Length > nextVal)
                                {
                                    if (IsFirstValueIsEqualSecondValue(sortValues[i], sortValues[nextVal]))
                                    {
                                        Console.Write(sortValues[i]);
                                        Console.WriteLine(sortValues[nextVal]);
                                        break;
                                    }

                                    var values = GetMaxValue(sortValues, i, nextVal, maxVal);
                                    Console.WriteLine(values);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(maxVal);
                                    break;
                                }
                            }
                            else
                            {
                                var value = GetMaxValue(sortValues, i, nextVal, maxVal);
                                Console.WriteLine(value);

                                break;
                            }
                        }
                    }
                    else if (sortValues.Length == 1)
                    {
                        if (IsSecondValueInSequences(maxVal, sortValues[1]))
                        {
                            Console.WriteLine(maxVal);
                            break;
                        }
                    }
                }

                Console.ReadLine();
            }
        }

        private static bool IsFirstValueIsEqualSecondValue(int first, int second)
        {
            return first == second ? true : false;
        }

        private static bool IsSecondValueInSequences(int first, int second)
        {
            return (first - 1) == second ? true : false;
        }

        private static string GetMaxValue(short[] sortWithPastiveValues, int i, int nextVal, int maxVal)
        {
            if (!IsSecondValueInSequences(sortWithPastiveValues[i], sortWithPastiveValues[nextVal]))
            {
                if (GetSum(maxVal, sortWithPastiveValues[nextVal]) > GetSum(sortWithPastiveValues[i], sortWithPastiveValues[nextVal]))
                {
                    return sortWithPastiveValues[nextVal].ToString() + maxVal.ToString();
                }
                else if (maxVal > GetSum(sortWithPastiveValues[i], sortWithPastiveValues[nextVal]))
                {
                    return maxVal.ToString();
                }
            }
            else
            {
                if (maxVal > GetSum(sortWithPastiveValues[i], sortWithPastiveValues[nextVal]))
                {
                    return maxVal.ToString();
                }

                return sortWithPastiveValues[nextVal].ToString() + maxVal.ToString();
            }

            return null;
        }

        private static int GetSum(int first, int second)
        {
            return first + second;
        }
    }
}
