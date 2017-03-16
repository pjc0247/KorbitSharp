using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace KorbitSharp
{
    public class KorbitCallImpl : IKorbitCall
    {
        public static readonly string Host = "https://api.korbit.co.kr/";

        private static string ToQueryString(Dictionary<string, object> dic)
        {
            if (dic == null || dic.Count == 0)
                return "";

            var array = (from e in dic
                         select string.Format("{0}={1}", Uri.EscapeUriString(e.Key), Uri.EscapeUriString(e.Value?.ToString() ?? "")))
                .ToArray();
            return "?" + string.Join("&", array);
        }

        public async Task<T> GetAsync<T>(string api, Dictionary<string, object> param)
        {
            var json = await RestCall.GetAsync(Host + api + ToQueryString(param));

            return JsonConvert.DeserializeObject<T>(json, new JsonConverter[] {
                new Model.BalanceItemConverter(),
                new Model.OrderbookItemConverter()
            });
        }

        public async Task<T> PostAsync<T>(string api, Dictionary<string, object> param)
        {
            param["nonce"] = Auth.GetNonce();

            var json = await RestCall.PostAsync(
                Host + api + ToQueryString(param),
                JsonConvert.SerializeObject(param));

            return JsonConvert.DeserializeObject<T>(json, new JsonConverter[] {
                new Model.BalanceItemConverter(),
                new Model.OrderbookItemConverter() });
        }
    }
}
