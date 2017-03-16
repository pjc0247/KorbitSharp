using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KorbitSharp.Model
{
    public class WalletResponse
    {
        public BalanceItem balance;
        public BalanceItem pendingOut;
        public BalanceItem pendingOrders;
        public BalanceItem available;
    }

    public class BalanceItem
    {
        public int valueAsKrw;
        public double value;
    }

    public class BalanceItemConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(BalanceItem) == objectType;
        }

        public override object ReadJson(
            JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jary = JArray.Load(reader);
            var item = new BalanceItem();

            if (jary.Count != 2)
                throw new InvalidOperationException("too many items in BalanceItem");

            foreach (JObject jobj in jary)
            {
                if ((string)jobj["currency"] == "krw")
                    item.valueAsKrw = (int)jobj["value"];
                else
                    item.value = (double)jobj["value"];
            }

            return item;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
