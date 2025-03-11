using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLabApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = 4 * Math.Sin(x) * 5 * Math.Cos(x);
            Console.WriteLine("{0:0.00}", y);
            Console.ReadKey();
        }
    }
}
