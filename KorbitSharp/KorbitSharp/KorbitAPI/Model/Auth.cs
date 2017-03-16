using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorbitSharp.Model
{
    public class RequestAccessTokenResponse
    {
        public string token_type;
        public string access_token;
        public int expires_in;
        public string refresh_token;
    }
}
