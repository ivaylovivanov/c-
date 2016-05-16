using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            var bgn = usd * 1.79549;
            bgn = Math.Round(bgn, 2);
            Console.WriteLine("{0} BGN", bgn);
        }
    }
}
