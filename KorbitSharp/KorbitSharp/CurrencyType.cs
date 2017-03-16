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
        /// <summary>
        /// TYPE_KRW
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string ToCurrencyPair(this CurrencyType type)
        {
            if (type == CurrencyType.Bitcoin) return "btc_krw";
            else if (type == CurrencyType.Ethereum) return "eth_krw";
            else if (type == CurrencyType.EthereumClassic) return "etc_krw";

            throw new NotImplementedException($"{type}");
        }

        /// <summary>
        /// KRW_TYPE
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string ToReversedCurrencyPair(this CurrencyType type)
        {
            if (type == CurrencyType.Bitcoin) return "krw_btc";
            else if (type == CurrencyType.Ethereum) return "krw_eth";
            else if (type == CurrencyType.EthereumClassic) return "krw_etc";

            throw new NotImplementedException($"{type}");
        }
    }
}
