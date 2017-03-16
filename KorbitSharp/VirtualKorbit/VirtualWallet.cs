using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KorbitSharp;
using KorbitSharp.Model;

namespace VirtualKorbit
{
    class WalletBalances
    {
        public BalanceItem balance;
        public BalanceItem pendingOut;
        public BalanceItem pendingOrders;
        public BalanceItem available;
    }

    class VirtualWallet
    {
        public static Dictionary<CurrencyType, WalletBalances> wallet;

        static VirtualWallet()
        {
        }

        public static void Charge(CurrencyType type, int krwAmount)
        {
            wallet[type].balance.krwValue += krwAmount;
        }

        public static WalletResponse GetBalance()
        {
            return new WalletResponse()
            {
                
            };
        }
    }
}
