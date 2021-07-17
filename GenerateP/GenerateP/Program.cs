using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "P number generator with using Monte Carlo method";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Generator generator = new Generator();
            Console.WriteLine("Enter value of dots: ");
            generator.dots = int.Parse(Console.ReadLine());

            Console.WriteLine("Answer: {0}", generator.GetPnumber());
            Console.ReadKey();
        }
    }
}
