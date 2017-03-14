using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorbitSharp
{
    public enum CurrencyType
    {
        Bitcoin,
        Ethereum,
        EthereumClassic
    }

    static class CurrencyTypeExt
    {
        public static string ToCurrencyPair(this CurrencyType type)
        {
            if (type == CurrencyType.Bitcoin) return "btc_krw";
            else if (type == CurrencyType.Ethereum) return "eth_krw";
            else if (type == CurrencyType.EthereumClassic) return "etc_krw";

            throw new NotImplementedException($"{type}");
        }
    }
}
