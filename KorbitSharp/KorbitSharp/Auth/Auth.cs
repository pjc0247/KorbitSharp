using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace KorbitSharp
{
    using Model;

    public class Auth
    {
        private static string ClientId;
        private static string ClientSecret;

        private static long Nonce = -1;
        private static string AccessToken;
        public static string RefreshToken;
        public static DateTime RefreshedAt;

        public static bool IsAuthorized = false;

        internal static async Task<string> GetAccessTokenAsync()
        {
            if (DateTime.Now - RefreshedAt >= TimeSpan.FromSeconds(3400))
            {
                var accessTokenData = await RefreshAccessTokenAsync(ClientId, ClientSecret, RefreshToken);

                UpdateAuthData(accessTokenData);
            }

            return AccessToken;
        }
        internal static long GetNonce()
        {
            return Interlocked.Increment(ref Nonce);
        }

        public static async Task Login(string clientId, string clientSecret, string username, string password)
        {
            var accessTokenData = await RequestAccessTokenAsync(clientId, clientSecret, username, password);

            ClientId = clientId;
            ClientSecret = clientSecret;

            UpdateAuthData(accessTokenData);
        }
        public static async Task Login(string clientId, string clientSecret, string refreshToken)
        {
            var accessTokenData = await RefreshAccessTokenAsync(clientId, clientSecret, refreshToken);

            ClientId = clientId;
            ClientSecret = clientSecret;

            UpdateAuthData(accessTokenData);
        }

        public static void EnableExchange(long nonce)
        {
            Nonce = nonce;
        }

        private static void UpdateAuthData(RequestAccessTokenResponse authData) 
        {
            RefreshedAt = DateTime.Now;
            RefreshToken = authData.refresh_token;
            AccessToken = authData.access_token;

            IsAuthorized = true;
        }

        public static async Task<RequestAccessTokenResponse> RequestAccessTokenAsync(
            string clientId, string clientSecret, string username, string password)
        {
            var param = new Dictionary<string, object>()
            {
                {"client_id", clientId},
                {"client_secret", clientSecret},
                {"username", username},
                {"password", password},
                {"grant_type", "password"}
            };

            var response = KorbitCall.PostAsync<RequestAccessTokenResponse>("v1/oauth2/access_token", param);

            return await response;
        }

        public static async Task<RequestAccessTokenResponse> RefreshAccessTokenAsync(string clientId, string clientSecret, string refreshToken)
        {
            var param = new Dictionary<string, object>()
            {
                {"client_id", clientId},
                {"client_secret", clientSecret},
                {"refresh_token", refreshToken},
                {"grant_type", "refresh_token"}
            };

            var response = KorbitCall.PostAsync<RequestAccessTokenResponse>("v1/oauth2/access_token", param);

            return await response;
        }
    }
}
