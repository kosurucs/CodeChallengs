using System;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nofInterger = Convert.ToInt32(Console.ReadLine());
            if (nofInterger >= 3 && nofInterger <= 1000000)
            {
                var values = new int[nofInterger];
                for (int i = 0; i < nofInterger; i++)
                {
                    values[i] = Convert.ToInt32(Console.ReadLine());
                }

                var sortedValues = values.OrderByDescending(x => x).ToArray();
                var count = sortedValues.Length - 1;
                for (int k = 0; k < sortedValues.Length; k++)
                {
                    if (k == count)
                    {
                        Console.WriteLine(sortedValues[k]);
                        break;
                    }
                    else if (k <= count)
                    {
                        Console.WriteLine(sortedValues[k]);
                        Console.WriteLine(sortedValues[count]);
                        count--;
                    }
                    else if (k >= count)
                    {
                        break;
                    }
                }
            }
        }
    }
}
