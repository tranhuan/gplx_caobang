using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT.VPDK.CHINHANH.Models;
using VT.VPDK.DBMapping.Models;
using VT.VPDK.DBMapping.ModelsOther;

namespace VT.VPDK.CHINHANH.DataAccess.Repository
{
    public interface INguoiLXRepository : IRepository<NguoiLX>{
        NguoiLX GetByKey(string madk);
        IEnumerable<NguoiLX> Find(NguoiLX nguoilx,DateTime fromDate, DateTime toDate);
        IEnumerable<NguoiLX_NguoiLX_HoSo> Find_NguoiLX_NguoiLX_HoSo(NguoiLX nguoilx, DateTime fromDate, DateTime toDate);
    }
    public class NguoiLXRepository : EFRepository<NguoiLX>, INguoiLXRepository
    {
        public NguoiLXRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
        public NguoiLX GetByKey(string madk)
        {
            return DbSet.FirstOrDefault(f => f.MaDK == madk);
        }
        public IEnumerable<NguoiLX> Find(NguoiLX nguoilx,DateTime fromDate, DateTime toDate)
        {
            var result = DbSet.Where(w =>
                (string.IsNullOrEmpty(nguoilx.SoCMT.Trim()) || w.SoCMT.Equals(nguoilx.SoCMT.Trim())) &&
                (string.IsNullOrEmpty(nguoilx.HoVaTen.Trim()) || w.HoVaTen.ToLower().Equals(nguoilx.HoVaTen.ToLower().Trim())) &&
                (
                    ((fromDate == null) ||(w.NgayTao >= fromDate)) && 
                    ((toDate == null) ||(w.NgayTao <= toDate))
                )
                );
            return result;
        }
        public IEnumerable<NguoiLX_NguoiLX_HoSo> Find_NguoiLX_NguoiLX_HoSo(NguoiLX nguoilx, DateTime fromDate, DateTime toDate)
        {
            var result = DbSet.Where(w =>
                (string.IsNullOrEmpty(nguoilx.SoCMT.Trim()) || w.SoCMT.Equals(nguoilx.SoCMT.Trim())) &&
                (string.IsNullOrEmpty(nguoilx.MaDK.Trim()) || w.MaDK.Equals(nguoilx.MaDK.Trim())) &&
                (string.IsNullOrEmpty(nguoilx.HoVaTen.Trim()) || w.HoVaTen.ToLower().Equals(nguoilx.HoVaTen.ToLower().Trim())) &&
                (
                    ((fromDate == null) || (w.NgayTao >= fromDate)) &&
                    ((toDate == null) || (w.NgayTao <= toDate))
                )
                ).Select(s => new NguoiLX_NguoiLX_HoSo
                {
                    MaDK = s.MaDK,
                    DonViNhanHSo = s.DonViNhanHSo,
                    HoDemNLX = s.HoDemNLX,
                    TenNLX = s.TenNLX,
                    HoVaTen = s.HoVaTen,
                    MaQuocTich = s.MaQuocTich,
                    NgaySinh = s.NgaySinh,
                    NoiTT = s.NoiTT,
                    NoiTT_MaDVHC = s.NoiCT_MaDVHC,
                    NoiTT_MaDVQL = s.NoiTT_MaDVQL,
                    NoiCT = s.NoiCT,
                    NoiCT_MaDVHC = s.NoiCT_MaDVHC,
                    NoiCT_MaDVQL = s.NoiCT_MaDVQL,
                    SoCMT = s.SoCMT,
                    NgayCapCMT = s.NgayCapCMT,
                    NoiCapCMT = s.NoiCapCMT,
                    GhiChu = s.GhiChu,
                    TrangThai = s.TrangThai,
                    NguoiTao = s.NguoiTao,
                    NguoiSua = s.NguoiSua,
                    NgayTao = s.NgayTao,
                    NgaySua = s.NgaySua,
                    GioiTinh = s.GioiTinh == "F"?"Nữ":"Nam",
                    HoVaTenIn = s.HoVaTenIn,
                    SO_CMND_CU = s.SO_CMND_CU,
                    DonViGTVT = s.DM_DonViGTVT.TenDV,
                    //public virtual DM_DonViGTVT DM_DonViGTVT = s.
                    DVHC = s.DM_DVHC.TenDvhc,
                    //public virtual DM_DVHC DM_DVHC = s.
                    //public virtual DM_DVHC DM_DVHC1 = s.
                    QuocTich = s.DM_QuocTich.TenVN,
                    //public virtual DM_QuocTich DM_QuocTich = s.
                    HS_HangGPLX = s.NguoiLX_HoSo.HangGPLX,
                    HS_DuongDanAnh = s.NguoiLX_HoSo.DuongDanAnh
                });
            return result;
        }
    }
}
