using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L21_VegiesStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var vPrice = double.Parse(Console.ReadLine());
            var fPrice = double.Parse(Console.ReadLine());
            var vKG = int.Parse(Console.ReadLine());
            var fKG = int.Parse(Console.ReadLine());
            var eur = 1.94;
            
            var vGross = vPrice * vKG;
            var fGross = fPrice * fKG;
            var totalGrossLV = vGross + fGross;
            var totalGrossEUR = totalGrossLV / eur;

            Console.WriteLine(totalGrossEUR);
        }
    }
}
