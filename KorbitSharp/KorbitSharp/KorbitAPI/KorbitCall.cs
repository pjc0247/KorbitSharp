using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace KorbitSharp
{
    class KorbitCall {
        public static readonly string Host = "https://api.korbit.co.kr/";

        private static string ToQueryString(Dictionary<string, object> dic)
        {
            var array = (from e in dic
                         select string.Format("{0}={1}", Uri.EscapeUriString(e.Key), Uri.EscapeUriString(e.Value.ToString())))
                .ToArray();
            return "?" + string.Join("&", array);
        }

        public static async Task<T> GetAsync<T>(string api, Dictionary<string, object> param)
        {
            var json = await RestCall.GetAsync(Host + api + ToQueryString(param));

            return JsonConvert.DeserializeObject<T>(json);
        }
        public static Task<T> GetAsync<T>(string api)
        {
            return GetAsync<T>(api, new Dictionary<string, object>());
        }
    }
}
