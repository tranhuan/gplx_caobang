using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT.VPDK.DBMapping.Models;
using System.Data.Entity;

namespace VT.VPDK.CHINHANH.DataAccess.Repository
{
    public interface IQTHT_ThamSoHTRepository : IRepository<QTHT_ThamSoHT>
    {
        QTHT_ThamSoHT GetByKey(string TenTS);
    }
    public class QTHT_ThamSoHTRepository : EFRepository<QTHT_ThamSoHT>, IQTHT_ThamSoHTRepository
    {
        public QTHT_ThamSoHTRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
        public QTHT_ThamSoHT GetByKey(string TenTS)
        {
            return DbSet.FirstOrDefault(f => f.TenTS == TenTS);
        }
    }
}
