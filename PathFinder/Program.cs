using System;
using System.IO;
using System.Reflection;

namespace PathFinder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\tessdata";

            Console.WriteLine(path);
        }
    }
}
