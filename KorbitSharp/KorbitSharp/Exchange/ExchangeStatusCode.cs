using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorbitSharp
{
    public class ExchangeStatusCode
    {
        public static readonly string Success = "success";

        public static readonly string TooManyOrders = "too_many_orders";
        public static readonly string NotEnoughBtc = "not_enough_btc";
        public static readonly string NotEnoughKrw = "not_enough_krw";
    }
}
