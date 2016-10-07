using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT.VPDK.DBMapping.Models;
using System.Data.Entity;

namespace VT.VPDK.CHINHANH.DataAccess.Repository
{
    public interface IDM_DonViGTVTRepository : IRepository<DM_DonViGTVT>
    {
        DM_DonViGTVT GetByKey(string MaDv);
        //void AddOrUpdate(DM_DVHC dmDVHCActions);
    }
    public class DM_DonViGTVTRepository : EFRepository<DM_DonViGTVT>, IDM_DonViGTVTRepository
    {
        public DM_DonViGTVTRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
        public DM_DonViGTVT GetByKey(string MaDv)
        {
            return DbSet.FirstOrDefault(f => f.MaDV == MaDv);
        }
    }
}
