using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();

            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;

            switch (from.ToLower())
            {
                case "usd":
                    sum = sum * usd;
                    break;
                case "eur":
                    sum = sum * eur;
                    break;
                case "gbp":
                    sum = sum * gbp;
                    break;
                default:
                    break;
            }

            switch (to.ToLower())
            {
                case "usd":
                    sum = sum / usd;
                    break;
                case "eur":
                    sum = sum / eur;
                    break;
                case "gbp":
                    sum = sum / gbp;
                    break;
                default:
                    break;
            }

            sum = Math.Round(sum, 2);

            Console.Write(sum + " " + to.ToUpper());
            Console.WriteLine();
            
        }
    }
}
