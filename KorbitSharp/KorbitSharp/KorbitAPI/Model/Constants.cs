using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorbitSharp.Model
{
    public class ConstantsResponse
    {
        public int krwWithdrawalFee;
        public int maxKrwWithdrawal;
        public int minKrwWithdrawal;

        public int btcTickSize;
        public float btcWithdrawalFee;
        public float maxBtcOrder;
        public int maxBtcPrice;
        public float minBtcOrder;
        public int minBtcPrice;
        public float maxBtcWithdrawal;
        public float minBtcWithdrawal;

        public int etcTickSize;
        public float maxEtcOrder;
        public int maxEtcPrice;
        public float minEtcOrder;
        public int minEtcPrice;

        public int ethTickSize;
        public float maxEthOrder;
        public int maxEthPrice;
        public float minEthOrder;
        public int minEthPrice;

        public int minTradableLevel;
    }
}
