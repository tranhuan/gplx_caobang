using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT.VPDK.DBMapping.Models;
using System.Data.Entity;

namespace VT.VPDK.SOGTVT.DataAccess.Repository
{
    public interface INguoiLXHS_GiayToRepository : IRepository<NguoiLXHS_GiayTo>
    {
        IEnumerable<NguoiLXHS_GiayTo> GetByMaDK(string madk);
        NguoiLXHS_GiayTo GetByKey(int magt,string madk);
        void AddOrUpdate(NguoiLXHS_GiayTo nguoiLXGiayTo);
    }
    public class NguoiLXHS_GiayToRepository : EFRepository<NguoiLXHS_GiayTo>, INguoiLXHS_GiayToRepository
    {
        public NguoiLXHS_GiayToRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
        public IEnumerable<NguoiLXHS_GiayTo> GetByMaDK(string madk)
        {
            return DbSet.Where(w => w.MaDK == madk);
        }
        public NguoiLXHS_GiayTo GetByKey(int magt, string madk)
        {
            return DbSet.FirstOrDefault(f => f.MaDK == madk && f.MaGT == magt);
        }
        public void AddOrUpdate(NguoiLXHS_GiayTo nguoiLXGiayTo)
        {
            if (nguoiLXGiayTo == null)
            {
                return;
            }
            var exist = GetByKey(nguoiLXGiayTo.MaGT,nguoiLXGiayTo.MaDK);
            if (exist == null)
            {
                Add(nguoiLXGiayTo);
            }
            //else
            //{
            //    exist = nguoiLXActions;
            //    Update(exist);
            //}
            Save();
        }
    }
}
