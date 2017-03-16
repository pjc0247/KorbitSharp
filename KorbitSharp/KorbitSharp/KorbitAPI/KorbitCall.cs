using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace KorbitSharp
{
    class KorbitCall {
        internal static IKorbitCall impl;

        static KorbitCall()
        {
            impl = new KorbitCallImpl();
        }

        public static async Task<T> GetAsync<T>(string api, Dictionary<string, object> param)
        {
            return await impl.GetAsync<T>(api, param);   
        }
        public static Task<T> GetAsync<T>(string api)
        {
            return GetAsync<T>(api, new Dictionary<string, object>());
        }

        public static async Task<T> PostAsync<T>(string api, Dictionary<string, object> param)
        {
            return await impl.PostAsync<T>(api, param);
        }
    }
}
