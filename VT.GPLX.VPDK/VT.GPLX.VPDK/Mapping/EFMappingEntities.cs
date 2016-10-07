using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace VT.GPLX.VPDK.Mapping
{
    public class EFMappingEntities<T> : IMappingEntities<T> where T : class
    {
        public T MappingObject(T entity)
        {
            T newT = default(T);
            Type newTypeT = typeof(T);
            Type typeT = entity.GetType();
            PropertyInfo[] arrTypeT = typeT.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo[] arrNewTypeT = newTypeT.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo item in arrTypeT)
            {
                foreach (PropertyInfo newItem in arrNewTypeT)
                {
                    if (item.Name == newItem.Name)
                    {
                        newItem.SetValue(newT, item.GetValue(entity));
                        break;
                    }
                }
            }
            return newT;
        }
    }
}
