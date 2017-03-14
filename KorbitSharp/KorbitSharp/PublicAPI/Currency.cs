using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;

namespace KorbitSharp
{
    using KorbitSharp.Model;

    public class Currency
    {
        public static async Task<int> QueryAsync(CurrencyType type)
        {
            var param = new Dictionary<string, object>()
            {
                {"currency_pair", type.ToCurrencyPair()}
            };
            
            var response = await KorbitCall.GetAsync<TickerResponse>("/v1/ticker", param);

            return response.last;
        }

        public static async Task<DetailedTickerResponse> QueryDetailedAsync(CurrencyType type)
        {
            var param = new Dictionary<string, object>()
            {
                {"currency_pair", type.ToCurrencyPair()}
            };

            var response = await KorbitCall.GetAsync<DetailedTickerResponse>("/v1/ticker", param);

            return response;
        }
    }
}
