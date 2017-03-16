using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorbitSharp
{
    using Model;

    public class Exchange
    {
        public static async Task<string> PlaceBid(CurrencyType type, int price, double amount)
        {
            var param = new Dictionary<string, object>()
            {
                {"currency_type", type.ToCurrencyPair()},
                {"type", "limit"},
                {"price", price},
                {"coin_amount", amount}
            };

            var response = await KorbitCall.PostAsync<ExchangeResponse>("v1/user/orders/buy", param);

            return response.status;
        }

        public static async Task<string> PlaceAsk(CurrencyType type, int price, double amount)
        {
            var param = new Dictionary<string, object>()
            {
                {"currency_type", type.ToCurrencyPair()},
                {"type", "limit"},
                {"price", price},
                {"coin_amount", amount}
            };

            var response = await KorbitCall.PostAsync<ExchangeResponse>("v1/user/orders/sell", param);

            return response.status;
        }
    }
}
