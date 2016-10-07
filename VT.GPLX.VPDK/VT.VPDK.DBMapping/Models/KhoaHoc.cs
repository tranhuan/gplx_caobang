using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class KhoaHoc
    {
        public KhoaHoc()
        {
            this.NguoiLX_HoSo = new List<NguoiLX_HoSo>();
        }

        public string MaKH { get; set; }
        public string MaCSDT { get; set; }
        public string MaSoGTVT { get; set; }
        public string TenKH { get; set; }
        public string HangGPLX { get; set; }
        public string HangDT { get; set; }
        public string SoQD_KhaiGiang { get; set; }
        public Nullable<System.DateTime> NgayQD_KhaiGiang { get; set; }
        public Nullable<System.DateTime> NgayKG { get; set; }
        public Nullable<System.DateTime> NgayBG { get; set; }
        public string MucTieuDT { get; set; }
        public Nullable<System.DateTime> NgayThi { get; set; }
        public Nullable<System.DateTime> NgaySH { get; set; }
        public Nullable<int> TongSoHV { get; set; }
        public Nullable<int> SoHVTotNghiep { get; set; }
        public Nullable<int> SoHVDuocCapGPLX { get; set; }
        public Nullable<int> ThoiGianDT { get; set; }
        public Nullable<int> SoNgayOnKT { get; set; }
        public Nullable<int> SoNgayThucHoc { get; set; }
        public Nullable<int> SoNgayNghiLe { get; set; }
        public Nullable<int> TongSoNgay { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public virtual DM_DonViGTVT DM_DonViGTVT { get; set; }
        public virtual DM_DonViGTVT DM_DonViGTVT1 { get; set; }
        public virtual DM_HangDT DM_HangDT { get; set; }
        public virtual DM_HangGPLX DM_HangGPLX { get; set; }
        public virtual ICollection<NguoiLX_HoSo> NguoiLX_HoSo { get; set; }
    }
}
