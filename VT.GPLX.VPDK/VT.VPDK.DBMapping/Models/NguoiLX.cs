using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class NguoiLX
    {
        public string MaDK { get; set; }
        public string DonViNhanHSo { get; set; }
        public string HoDemNLX { get; set; }
        public string TenNLX { get; set; }
        public string HoVaTen { get; set; }
        public string MaQuocTich { get; set; }
        public string NgaySinh { get; set; }
        public string NoiTT { get; set; }
        public string NoiTT_MaDVHC { get; set; }
        public string NoiTT_MaDVQL { get; set; }
        public string NoiCT { get; set; }
        public string NoiCT_MaDVHC { get; set; }
        public string NoiCT_MaDVQL { get; set; }
        public string SoCMT { get; set; }
        public Nullable<System.DateTime> NgayCapCMT { get; set; }
        public string NoiCapCMT { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public string GioiTinh { get; set; }
        public string HoVaTenIn { get; set; }
        public string SO_CMND_CU { get; set; }
        public virtual DM_DonViGTVT DM_DonViGTVT { get; set; }
        public virtual DM_DVHC DM_DVHC { get; set; }
        public virtual DM_DVHC DM_DVHC1 { get; set; }
        public virtual DM_QuocTich DM_QuocTich { get; set; }
        public virtual NguoiLX_HoSo NguoiLX_HoSo { get; set; }
    }
}
