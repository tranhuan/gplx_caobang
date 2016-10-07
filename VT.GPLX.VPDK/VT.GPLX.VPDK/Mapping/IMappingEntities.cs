using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT.GPLX.VPDK.Mapping
{
    public interface IMappingEntities<T> where T : class
    {
        T MappingObject(T entity);
    }
}
