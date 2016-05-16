using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_CelsiusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var farenheit = (celsius * 1.8) + 32;
            farenheit = Math.Round(farenheit, 2);
            Console.WriteLine(farenheit);
        }
    }
}
