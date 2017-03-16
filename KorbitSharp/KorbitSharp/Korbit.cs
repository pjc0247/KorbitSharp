using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorbitSharp
{
    public class Korbit
    {
        public static void SetKorbitCallImpl(IKorbitCall impl)
        {
            if (impl == null)
                throw new ArgumentNullException(nameof(impl));

            KorbitCall.impl = impl;
        }
    }
}
