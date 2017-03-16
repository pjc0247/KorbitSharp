using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace KorbitSharp.Model
{
    public class OrderbookItem
    {
        public int price;

        public double amount;

        public int reserved;
    }

    public class OrderItem
    {
        public long timestamp;

        /// <summary>
        /// Transaction ID (Unique)
        /// </summary>
        public string tid;

        public int price;

        public double amount;
    }

    public class OrderbookItemConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(OrderbookItem) == objectType;
        }

        public override object ReadJson(
            JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jary = JArray.Load(reader);
            var item = new OrderbookItem();

            item.price = (int)jary[0];
            item.amount = (double)jary[1];
            item.reserved = (int)jary[2];

            return item;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
