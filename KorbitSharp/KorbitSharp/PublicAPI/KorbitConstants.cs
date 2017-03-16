using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorbitSharp
{
    using Model;

    public class KorbitConstants
    {
        public static ConstantsResponse Value = null;

        public static async Task<ConstantsResponse> RefreshAsync()
        {
            var response = await KorbitCall.GetAsync<ConstantsResponse>("v1/constants");

            Value = response;

            return response;
        }
    }
}
