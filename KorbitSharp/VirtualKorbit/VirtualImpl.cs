using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KorbitSharp;

namespace VirtualKorbit
{
    public class VirtualImpl : IKorbitCall
    {
        KorbitCallImpl impl;

        public VirtualImpl()
        {
            impl = new KorbitCallImpl();
        }

        public Task<T> GetAsync<T>(string api, Dictionary<string, object> param)
        {
            if (api.StartsWith("v1/user/wallet"))
                return Task<T>.FromResult((T)(object)VirtualWallet.GetBalance());

            return impl.GetAsync<T>(api, param);
        }

        public Task<T> PostAsync<T>(string api, Dictionary<string, object> param)
        {
            return impl.PostAsync<T>(api, param);
        }
    }
}
