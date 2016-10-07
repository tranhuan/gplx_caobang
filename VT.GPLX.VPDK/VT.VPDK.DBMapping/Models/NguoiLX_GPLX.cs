using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class NguoiLX_GPLX
    {
        public string MaDK { get; set; }
        public string SoGPLX { get; set; }
        public string HangGPLX { get; set; }
        public string SoHoSo { get; set; }
        public string SoGPLXCu { get; set; }
        public string NoiCapGPLX { get; set; }
        public System.DateTime NgayCapGPLX { get; set; }
        public string CoQuanQLGPLX { get; set; }
        public Nullable<System.DateTime> NgayHHGPLX { get; set; }
        public System.DateTime NgayTTGPLX { get; set; }
        public string MoTaVN { get; set; }
        public string MoTaEN { get; set; }
        public string NguoiKy { get; set; }
        public string MaHTCap { get; set; }
        public string NoiHocGPLX { get; set; }
        public int NamHocGPLX { get; set; }
        public string DuongDanAnh { get; set; }
        public string HoTenDem { get; set; }
        public string TenNLX { get; set; }
        public string HoVaTen { get; set; }
        public string NgaySinh { get; set; }
        public string MaQuocTich { get; set; }
        public string NoiCT { get; set; }
        public string NoiCT_MaDVHC { get; set; }
        public string NoiCT_MaDVQL { get; set; }
        public string SoCMT { get; set; }
        public string SoSeri { get; set; }
        public string NoiIn { get; set; }
        public Nullable<System.DateTime> NgayIn { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public string NguoiTra { get; set; }
        public string NoiTra { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> NgayTT_A1 { get; set; }
        public Nullable<System.DateTime> NgayTT_A2 { get; set; }
        public Nullable<System.DateTime> NgayTT_A3 { get; set; }
        public Nullable<System.DateTime> NgayTT_A4 { get; set; }
        public Nullable<System.DateTime> NgayTT_B1 { get; set; }
        public Nullable<System.DateTime> NgayTT_B2 { get; set; }
        public Nullable<System.DateTime> NgayTT_C { get; set; }
        public Nullable<System.DateTime> NgayTT_D { get; set; }
        public Nullable<System.DateTime> NgayTT_E { get; set; }
        public Nullable<System.DateTime> NgayTT_F { get; set; }
        public Nullable<System.DateTime> NgayTT_FB2 { get; set; }
        public Nullable<System.DateTime> NgayTT_FC { get; set; }
        public Nullable<System.DateTime> NgayTT_FD { get; set; }
        public Nullable<System.DateTime> NgayTT_FE { get; set; }
        public string Hanoi { get; set; }
        public string HanoiViettat { get; set; }
        public virtual DM_DonViGTVT DM_DonViGTVT { get; set; }
        public virtual DM_DonViGTVT DM_DonViGTVT1 { get; set; }
        public virtual DM_DonViGTVT DM_DonViGTVT2 { get; set; }
        public virtual DM_DVHC DM_DVHC { get; set; }
        public virtual DM_HangGPLX DM_HangGPLX { get; set; }
        public virtual DM_HTCapGPLX DM_HTCapGPLX { get; set; }
        public virtual DM_QuocTich DM_QuocTich { get; set; }
        public virtual NguoiLX_GPLX NguoiLX_GPLX1 { get; set; }
        public virtual NguoiLX_GPLX NguoiLX_GPLX2 { get; set; }
    }
}
