using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13_RadianToDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());
            var degrees = (radians * 180) / Math.PI;
            degrees = Math.Round(degrees, 2);
            Console.WriteLine(degrees);
        }
    }
}
