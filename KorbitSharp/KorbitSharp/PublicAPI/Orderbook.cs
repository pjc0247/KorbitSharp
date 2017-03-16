using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorbitSharp
{
    using Model;

    public class Orderbook
    {
        public static async Task<OrderbookResponse> QueryOrderbookAsync(CurrencyType type)
        {
            var param = new Dictionary<string, object>()
            {
                {"currency_pair", type.ToCurrencyPair()},
                {"category", "all"}
            };

            var response = await KorbitCall.GetAsync<OrderbookResponse>("v1/orderbook", param);

            return response;
        }
        
        public static async Task<OrderHistoryResponse> QueryOrderHistoryAsync(CurrencyType type, TimePeriod period)
        {
            var param = new Dictionary<string, object>()
            {
                {"currency_pair", type.ToCurrencyPair()},
                {"time", period.ToPeriodString()}
            };

            var response = await KorbitCall.GetAsync<OrderHistoryResponse>("v1/transactions", param);

            return response;
        }
    }
}
