using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorbitSharp
{
    using Model;

    public class Wallet
    {

        public static async Task<WalletResponse> QueryWalletAsync(CurrencyType type)
        {
            var param = new Dictionary<string, object>()
            {
                {"currency_pair", type.ToCurrencyPair()}
            };

            var response = KorbitCall.GetAsync<WalletResponse>("v1/user/wallet", param);

            return await response;
        }
    }
}
