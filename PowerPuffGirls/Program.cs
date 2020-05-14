using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPuffGirls
{
    public class Program
    {
        public static void Main(string[] args)
         {
            const int _maxIngredinets = 10000000;
            var ingredients = Convert.ToInt32(Console.ReadLine());
            if (1 <= ingredients && ingredients <= _maxIngredinets)
            {
                var quantity_Of_Ingredients = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x) && Convert.ToInt64(x) >= 0 && Convert.ToInt64(x) < long.MaxValue).Select(x => Convert.ToInt64(x)).ToArray();
                if (quantity_Of_Ingredients.Length == ingredients)
                {
                    var quantity_Of_each_Ingredients = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(x => Convert.ToInt64(x)).ToArray();
                    if (quantity_Of_each_Ingredients.Length == quantity_Of_Ingredients.Length)
                    {
                        var counts = new List<long>();
                        for (int i = 0; i < quantity_Of_Ingredients.Length; i++)
                        {
                            counts.Add(quantity_Of_each_Ingredients[i] / quantity_Of_Ingredients[i]);
                        }

                        long returnVal = counts[0];
                        foreach (var val in counts)
                        {
                            if (val <= returnVal)
                            {
                                returnVal = val;
                            }
                        }
                        Console.WriteLine(returnVal);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}

