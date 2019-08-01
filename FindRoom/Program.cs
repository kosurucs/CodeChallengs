using System;
using System.Linq;

namespace FindRoom
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stringLength = Convert.ToInt32(Console.ReadLine());
            if (stringLength >= 3 && stringLength <= 500)
            {
                var stringVal = Console.ReadLine();
                ManageString(stringVal);
            }
        }

        public static bool IsValid(string valu)
        {
            return valu.Equals(valu.Reverse());
        }

        public static string ManageString(string stringValue)
        {
            if (stringValue != null)
            {
                var first = stringValue;
                var second = stringValue.Reverse().ToString();

                while (!first.Equals(second, StringComparison.CurrentCulture))
                {
                    var sc = second.ToArray();
                    var fs = first.ToArray();
                    for (int i = 0; i < first.Length; i++)
                    {
                        if (fs[i] == sc[i])
                        {

                        }
                        else
                        {

                        }
                    }

                };

                var halfWay = stringValue.Length / 2;
                var firstHalf = stringValue.Take(halfWay);
                var secondHalf = stringValue.Skip(halfWay);
                var rll = stringValue.Reverse();

                for (int i = 0; i < secondHalf.Count(); i++)
                {
                    // if()
                }
            }

            return null;
        }
    }
}
