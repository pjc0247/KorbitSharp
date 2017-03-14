using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace KorbitSharp
{
    class RestCall
    {
        public static async Task<string> GetAsync(string uri)
        {
            var http = new HttpClient();
            var response = await http.GetAsync(uri);

            if (response.IsSuccessStatusCode == false)
                throw new HttpRequestException($"{response.StatusCode}");

            return await response.Content.ReadAsStringAsync();
        }
    }
}
