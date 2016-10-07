using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class DM_DonViGTVT
    {
        public DM_DonViGTVT()
        {
            this.KhoaHocs = new List<KhoaHoc>();
            this.KhoaHocs1 = new List<KhoaHoc>();
            this.KySHes = new List<KySH>();
            this.NguoiLXes = new List<NguoiLX>();
            this.NguoiLX_GPLX = new List<NguoiLX_GPLX>();
            this.NguoiLX_GPLX1 = new List<NguoiLX_GPLX>();
            this.NguoiLX_GPLX2 = new List<NguoiLX_GPLX>();
            this.NguoiLX_HoSo = new List<NguoiLX_HoSo>();
            this.NguoiLX_HoSo1 = new List<NguoiLX_HoSo>();
            this.NguoiLX_HoSo2 = new List<NguoiLX_HoSo>();
        }

        public string MaDV { get; set; }
        public string MaDVQL { get; set; }
        public string LoaiDV { get; set; }
        public string TenDV { get; set; }
        public string CoQuanQL { get; set; }
        public Nullable<int> LoaiTTSH { get; set; }
        public string CacHangGPLX { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> LuuLuongDT { get; set; }
        public string SoGP { get; set; }
        public Nullable<System.DateTime> NgayGP { get; set; }
        public string LanhDao { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public string Website { get; set; }
        public Nullable<int> DienTichSanTap { get; set; }
        public Nullable<System.DateTime> NgayHHGP { get; set; }
        public string DiaDiemDaoTao { get; set; }
        public string MaDvOld { get; set; }
        public virtual ICollection<KhoaHoc> KhoaHocs { get; set; }
        public virtual ICollection<KhoaHoc> KhoaHocs1 { get; set; }
        public virtual ICollection<KySH> KySHes { get; set; }
        public virtual ICollection<NguoiLX> NguoiLXes { get; set; }
        public virtual ICollection<NguoiLX_GPLX> NguoiLX_GPLX { get; set; }
        public virtual ICollection<NguoiLX_GPLX> NguoiLX_GPLX1 { get; set; }
        public virtual ICollection<NguoiLX_GPLX> NguoiLX_GPLX2 { get; set; }
        public virtual ICollection<NguoiLX_HoSo> NguoiLX_HoSo { get; set; }
        public virtual ICollection<NguoiLX_HoSo> NguoiLX_HoSo1 { get; set; }
        public virtual ICollection<NguoiLX_HoSo> NguoiLX_HoSo2 { get; set; }
    }
}
