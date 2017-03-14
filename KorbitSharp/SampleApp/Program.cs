using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KorbitSharp;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Currency.QueryAsync(CurrencyType.Ethereum).Result);

        }
    }
}
