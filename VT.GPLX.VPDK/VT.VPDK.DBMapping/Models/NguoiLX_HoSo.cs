using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class NguoiLX_HoSo
    {
        public NguoiLX_HoSo()
        {
            this.NguoiLXHS_GiayTo = new List<NguoiLXHS_GiayTo>();
        }

        public string MaDK { get; set; }
        public string SoHoSo { get; set; }
        public string MaCSDT { get; set; }
        public string MaSoGTVT { get; set; }
        public string MaDVNhanHSo { get; set; }
        public System.DateTime NgayNhanHSo { get; set; }
        public string NguoiNhanHSo { get; set; }
        public Nullable<System.DateTime> NgayHenTra { get; set; }
        public int MaLoaiHs { get; set; }
        public string TT_XuLy { get; set; }
        public string DuongDanAnh { get; set; }
        public Nullable<int> ChatLuongAnh { get; set; }
        public Nullable<System.DateTime> NgayThuNhanAnh { get; set; }
        public string NguoiThuNhanAnh { get; set; }
        public string SoGPLXDaCo { get; set; }
        public string HangGPLXDaCo { get; set; }
        public string DonViCapGPLXDaCo { get; set; }
        public string NoiCapGPLXDaCo { get; set; }
        public string NgayCapGPLXDaCo { get; set; }
        public string NgayHHGPLXDaCo { get; set; }
        public string NgayTTGPLXDaCo { get; set; }
        public string DonViHocLX { get; set; }
        public Nullable<int> NamHocLX { get; set; }
        public string HangGPLX { get; set; }
        public Nullable<int> SoNamLX { get; set; }
        public Nullable<int> SoKmLXAnToan { get; set; }
        public Nullable<bool> GiayCNSK { get; set; }
        public string LyDoCapDoi { get; set; }
        public string MucDichCapDoi { get; set; }
        public Nullable<int> NoiDungSH { get; set; }
        public string MaKhoaHoc { get; set; }
        public string HangDaoTao { get; set; }
        public string SoGiayCNTN { get; set; }
        public string SoCCN { get; set; }
        public string MaBC1 { get; set; }
        public Nullable<bool> BC1_TuoiTS { get; set; }
        public Nullable<bool> BC1_ThamNien { get; set; }
        public string MaBC2 { get; set; }
        public Nullable<bool> KetQuaBC2 { get; set; }
        public Nullable<int> MaLyDoTCBC2 { get; set; }
        public string MaKySH { get; set; }
        public string SoBD { get; set; }
        public Nullable<int> LanSH { get; set; }
        public string SoQDSH { get; set; }
        public Nullable<System.DateTime> NgayQDSH { get; set; }
        public Nullable<int> KetQua_LyThuyet { get; set; }
        public string NhanXet_LyThuyet { get; set; }
        public Nullable<int> KetQua_Hinh { get; set; }
        public string NhanXet_Hinh { get; set; }
        public Nullable<int> KetQua_Duong { get; set; }
        public string NhanXet_Duong { get; set; }
        public string KetQuaSH { get; set; }
        public string SoQDTT { get; set; }
        public Nullable<System.DateTime> NgayQDTT { get; set; }
        public string NguoiKy { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public string SoGPLXTmp { get; set; }
        public Nullable<System.DateTime> NgayKTBC1 { get; set; }
        public string NguoiKTBC1 { get; set; }
        public Nullable<System.DateTime> NgayKTBC2 { get; set; }
        public string NguoiKTBC2 { get; set; }
        public string MaIn { get; set; }
        public Nullable<bool> KetQuaDoiSanhTW { get; set; }
        public string GhiChuKQDSTW { get; set; }
        public string ChuKy { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public string MaHTCap { get; set; }
        public long IDs { get; set; }
        public string TT_XuLy_Old { get; set; }
        public Nullable<bool> KQ_BC1 { get; set; }
        public string KQ_BC1_GhiChu { get; set; }
        public int Transfer_flag { get; set; }
        public string NamcapLandau { get; set; }
        public string MaTrichNgang { get; set; }
        public string DiaChiTrenGplx { get; set; }
        public string CoQuanQuanLyGplx { get; set; }
        public string DiaChiTrenGplx_ChiTiet { get; set; }
        public string SOSERI_GPLX_DACO { get; set; }
        public Nullable<int> IN_GPLX { get; set; }
        public virtual DM_DonViGTVT DM_DonViGTVT { get; set; }
        public virtual DM_DonViGTVT DM_DonViGTVT1 { get; set; }
        public virtual DM_DonViGTVT DM_DonViGTVT2 { get; set; }
        public virtual DM_HangDT DM_HangDT { get; set; }
        public virtual DM_HangGPLX DM_HangGPLX { get; set; }
        public virtual DM_HTCapGPLX DM_HTCapGPLX { get; set; }
        public virtual DM_LoaiHSo DM_LoaiHSo { get; set; }
        public virtual DM_NoiDungSH DM_NoiDungSH { get; set; }
        public virtual DM_TrangThai DM_TrangThai { get; set; }
        public virtual KhoaHoc KhoaHoc { get; set; }
        public virtual NguoiLX NguoiLX { get; set; }
        public virtual NguoiLX_Hoso_DichVu NguoiLX_Hoso_DichVu { get; set; }
        public virtual NguoiLX_Hoso_Quocte NguoiLX_Hoso_Quocte { get; set; }
        public virtual ICollection<NguoiLXHS_GiayTo> NguoiLXHS_GiayTo { get; set; }
    }
}
