using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT.VPDK.DBMapping.Models;
using System.Data.Entity;

namespace VT.VPDK.CHINHANH.DataAccess.Repository
{
    public interface IDM_DVHCRepository : IRepository<DM_DVHC>
    {
        DM_DVHC GetByKey(string MaDvhc);
        //void AddOrUpdate(DM_DVHC dmDVHCActions);
    }
    public class DM_DVHCRepository : EFRepository<DM_DVHC>, IDM_DVHCRepository
    {
        public DM_DVHCRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
        public DM_DVHC GetByKey(string MaDvhc)
        {
            return DbSet.FirstOrDefault(f => f.MaDvhc == MaDvhc);
        }
    }
}
