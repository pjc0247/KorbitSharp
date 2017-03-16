using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorbitSharp
{
    public interface IKorbitCall
    {
        Task<T> GetAsync<T>(string api, Dictionary<string, object> param);
        Task<T> PostAsync<T>(string api, Dictionary<string, object> param);
    }
}
