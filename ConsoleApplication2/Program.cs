using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20_WorkingPlaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine()) * 100;
            var w = (double.Parse(Console.ReadLine()) * 100) - 100;

            var placesPerRow = Math.Floor(w / 70);
            var numRows = Math.Floor(h / 120);

            var total = (placesPerRow * numRows) - 3;

            Console.WriteLine(total);
        }
    }
}
