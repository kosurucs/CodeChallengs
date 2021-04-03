using System;
using System.Linq;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCase = Convert.ToInt32(Console.ReadLine());
            if (testCase >= 1 && testCase <= 10)
            {
                var val1String = new string[testCase];
                var val2String = new string[testCase];

                for (int i = 0; i < testCase; i++)
                {
                    val1String[i] = Convert.ToString(Console.ReadLine());
                    val2String[i] = Convert.ToString(Console.ReadLine());
                }

                for (int l = 0; l < testCase; l++)
                {
                    if ((val1String[l].Length >= 1 && val1String[l].Length <= 1000) &&
                        (val2String[l].Length >= 1 && val2String[l].Length <= 1000))
                    {
                        var val1 = val1String[l].ToArray();
                        int valueCount = 0;
                        char lastChat = default(char);
                        foreach (var va in val1)
                        {
                            var val2 = val2String[l].ToArray();
                            foreach (var va2 in val2)
                            {
                                if (va2.CompareTo(va) == 0)
                                {
                                    if (!lastChat.Equals(va))
                                    {
                                        lastChat = va;
                                        valueCount++;
                                    }
                                }
                            }
                        }

                        if (valueCount == val1String[l].Length)
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                    }
                }
            }
        }
    }
}
