using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT.VPDK.DBMapping.Models;
using System.Data.Entity;

namespace VT.VPDK.SOGTVT.DataAccess.Repository
{
    public interface INguoiLX_Hoso_DichVuRepository : IRepository<NguoiLX_Hoso_DichVu>
    {
        NguoiLX_Hoso_DichVu GetByKey(string madk);
        void AddOrUpdate(NguoiLX_Hoso_DichVu NguoiLXHosoDichVuActions);
    }
    public class NguoiLX_Hoso_DichVuRepository : EFRepository<NguoiLX_Hoso_DichVu>, INguoiLX_Hoso_DichVuRepository
    {
        public NguoiLX_Hoso_DichVuRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public void AddOrUpdate(NguoiLX_Hoso_DichVu NguoiLXHosoDichVuActions)
        {
            if (NguoiLXHosoDichVuActions == null)
            {
                return;
            }
            var exist = GetByKey(NguoiLXHosoDichVuActions.MADK);
            if (exist == null)
            {
                Add(NguoiLXHosoDichVuActions);
            }
            //else
            //{
            //    exist = nguoiLXActions;
            //    Update(exist);
            //}
            Save();
        }
        public NguoiLX_Hoso_DichVu GetByKey(string madk)
        {
            return DbSet.FirstOrDefault(f => f.MADK == madk);
        }
    }
}
