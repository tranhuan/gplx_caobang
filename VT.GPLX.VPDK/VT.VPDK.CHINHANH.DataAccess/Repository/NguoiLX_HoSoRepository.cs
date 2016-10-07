using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT.VPDK.DBMapping.Models;
using System.Data.Entity;

namespace VT.VPDK.CHINHANH.DataAccess.Repository
{
    public interface INguoiLX_HoSoRepository : IRepository<NguoiLX_HoSo>
    {
        NguoiLX_HoSo GetByKey(string madk);
        void AddOrUpdate(NguoiLX_HoSo nguoiLXActions);
    }
    public class NguoiLX_HoSoRepository : EFRepository<NguoiLX_HoSo>, INguoiLX_HoSoRepository
    {
        public NguoiLX_HoSoRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
        public void AddOrUpdate(NguoiLX_HoSo nguoiLXActions)
        {
            if (nguoiLXActions == null)
            {
                return;
            }
            var exist = GetByKey(nguoiLXActions.MaDK);
            if (exist == null)
            {
                Add(nguoiLXActions);
            }
            //else
            //{
            //    exist = nguoiLXActions;
            //    Update(exist);
            //}
            Save();
        }
        public NguoiLX_HoSo GetByKey(string madk)
        {
            return DbSet.FirstOrDefault(f => f.MaDK == madk);
        }
    }
}
