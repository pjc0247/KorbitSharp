using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KorbitSharp;

namespace VirtualKorbit
{
    public class VirtualKorbit
    {
        public static void Charge(CurrencyType type, int krwAmount)
        {

        }

        public static void EnableVirtualCorbit()
        {
            // 실수 방지용
            Auth.EnableExchange(-1);
            Korbit.SetKorbitCallImpl(new VirtualImpl());
        }
    }
}
