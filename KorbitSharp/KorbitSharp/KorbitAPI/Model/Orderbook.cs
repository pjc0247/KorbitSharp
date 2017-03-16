using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorbitSharp.Model
{
    public class OrderbookResponse
    {
        public long timestamp;

        public OrderbookItem[] asks;
        public OrderbookItem[] bids;
    }
}
