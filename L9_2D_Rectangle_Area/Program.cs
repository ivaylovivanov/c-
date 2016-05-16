using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var ax = double.Parse(Console.ReadLine());
            var ay = double.Parse(Console.ReadLine());
            var cx = double.Parse(Console.ReadLine());
            var cy = double.Parse(Console.ReadLine());
            var length = Math.Abs(ax - cx);
            var width = Math.Abs(ay - cy);
            var area = length * width;
            var perimeter = 2 * (length + width);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
