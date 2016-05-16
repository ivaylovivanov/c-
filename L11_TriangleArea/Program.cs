using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = double.Parse(Console.ReadLine());
            var side = double.Parse(Console.ReadLine());
            var area = (height * side) / 2;
            area = Math.Round(area, 2);
            Console.WriteLine("Triangle area = {0}", area);
        }
    }
}
