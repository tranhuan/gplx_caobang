using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT.GPLX.VPDK.Mapping
{
    public class NewGeneric<T> where T : new()
    {
        public static T GetObject()
        {
            return new T();
        }
    }
}
