using System.Data.Entity;
using System.Data.Entity.Infrastructure;
//using VT.VPDK.SOGTVT.Models.Mapping;
using VT.VPDK.DBMapping.Models;
using VT.VPDK.DBMapping.Models.Mapping;

namespace VT.VPDK.SOGTVT.Models
{
    public partial class gplx_vpdkContext : DbContext
    {
        static gplx_vpdkContext()
        {
            Database.SetInitializer<gplx_vpdkContext>(null);
        }

        public gplx_vpdkContext()
            : base("gplx_vpdk_sogtvtContext")
        {
        }

        public DbSet<DM_DonViGTVT> DM_DonViGTVT { get; set; }
        public DbSet<DM_DVHC> DM_DVHC { get; set; }
        public DbSet<DM_GiayTo> DM_GiayTo { get; set; }
        public DbSet<DM_HangDT> DM_HangDT { get; set; }
        public DbSet<DM_HangGPLX> DM_HangGPLX { get; set; }
        public DbSet<DM_HTCapGPLX> DM_HTCapGPLX { get; set; }
        public DbSet<DM_LoaiDV> DM_LoaiDV { get; set; }
        public DbSet<DM_LoaiHSo> DM_LoaiHSo { get; set; }
        public DbSet<DM_LoaiHSo_GiayTo> DM_LoaiHSo_GiayTo { get; set; }
        public DbSet<DM_MonHoc> DM_MonHoc { get; set; }
        public DbSet<DM_NoiDungSH> DM_NoiDungSH { get; set; }
        public DbSet<DM_QuocTich> DM_QuocTich { get; set; }
        public DbSet<DM_TrangThai> DM_TrangThai { get; set; }
        public DbSet<DVCC3_GPLX> DVCC3_GPLX { get; set; }
        public DbSet<DVCC3_HoSo> DVCC3_HoSo { get; set; }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<KySH> KySHes { get; set; }
        public DbSet<NguoiLX> NguoiLXes { get; set; }
        public DbSet<NguoiLX_GPLX> NguoiLX_GPLX { get; set; }
        public DbSet<NguoiLX_HoSo> NguoiLX_HoSo { get; set; }
        public DbSet<NguoiLX_Hoso_DichVu> NguoiLX_Hoso_DichVu { get; set; }
        public DbSet<NguoiLX_Hoso_Quocte> NguoiLX_Hoso_Quocte { get; set; }
        public DbSet<NguoiLXHS_GiayTo> NguoiLXHS_GiayTo { get; set; }
        public DbSet<QTHT_ChucNang> QTHT_ChucNang { get; set; }
        public DbSet<QTHT_NguoiDung> QTHT_NguoiDung { get; set; }
        public DbSet<QTHT_NhatKyLoi> QTHT_NhatKyLoi { get; set; }
        public DbSet<QTHT_NhomCN> QTHT_NhomCN { get; set; }
        public DbSet<QTHT_NhomNSD> QTHT_NhomNSD { get; set; }
        public DbSet<QTHT_NSD_NhomNSD> QTHT_NSD_NhomNSD { get; set; }
        public DbSet<QTHT_NSD_Quyen_CN> QTHT_NSD_Quyen_CN { get; set; }
        public DbSet<QTHT_Quyen> QTHT_Quyen { get; set; }
        public DbSet<QTHT_Quyen_CN> QTHT_Quyen_CN { get; set; }
        public DbSet<QTHT_ThamSoHT> QTHT_ThamSoHT { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TRANS_CLI_HangDoiGui> TRANS_CLI_HangDoiGui { get; set; }
        public DbSet<TRANS_CLI_HangDoiNhan> TRANS_CLI_HangDoiNhan { get; set; }
        public DbSet<TRANS_CLI_NhatKyGui> TRANS_CLI_NhatKyGui { get; set; }
        public DbSet<TRANS_CLI_NhatKyNhan> TRANS_CLI_NhatKyNhan { get; set; }
        public DbSet<TRANS_LoaiDuLieu> TRANS_LoaiDuLieu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DM_DonViGTVTMap());
            modelBuilder.Configurations.Add(new DM_DVHCMap());
            modelBuilder.Configurations.Add(new DM_GiayToMap());
            modelBuilder.Configurations.Add(new DM_HangDTMap());
            modelBuilder.Configurations.Add(new DM_HangGPLXMap());
            modelBuilder.Configurations.Add(new DM_HTCapGPLXMap());
            modelBuilder.Configurations.Add(new DM_LoaiDVMap());
            modelBuilder.Configurations.Add(new DM_LoaiHSoMap());
            modelBuilder.Configurations.Add(new DM_LoaiHSo_GiayToMap());
            modelBuilder.Configurations.Add(new DM_MonHocMap());
            modelBuilder.Configurations.Add(new DM_NoiDungSHMap());
            modelBuilder.Configurations.Add(new DM_QuocTichMap());
            modelBuilder.Configurations.Add(new DM_TrangThaiMap());
            modelBuilder.Configurations.Add(new DVCC3_GPLXMap());
            modelBuilder.Configurations.Add(new DVCC3_HoSoMap());
            modelBuilder.Configurations.Add(new KhoaHocMap());
            modelBuilder.Configurations.Add(new KySHMap());
            modelBuilder.Configurations.Add(new NguoiLXMap());
            modelBuilder.Configurations.Add(new NguoiLX_GPLXMap());
            modelBuilder.Configurations.Add(new NguoiLX_HoSoMap());
            modelBuilder.Configurations.Add(new NguoiLX_Hoso_DichVuMap());
            modelBuilder.Configurations.Add(new NguoiLX_Hoso_QuocteMap());
            modelBuilder.Configurations.Add(new NguoiLXHS_GiayToMap());
            modelBuilder.Configurations.Add(new QTHT_ChucNangMap());
            modelBuilder.Configurations.Add(new QTHT_NguoiDungMap());
            modelBuilder.Configurations.Add(new QTHT_NhatKyLoiMap());
            modelBuilder.Configurations.Add(new QTHT_NhomCNMap());
            modelBuilder.Configurations.Add(new QTHT_NhomNSDMap());
            modelBuilder.Configurations.Add(new QTHT_NSD_NhomNSDMap());
            modelBuilder.Configurations.Add(new QTHT_NSD_Quyen_CNMap());
            modelBuilder.Configurations.Add(new QTHT_QuyenMap());
            modelBuilder.Configurations.Add(new QTHT_Quyen_CNMap());
            modelBuilder.Configurations.Add(new QTHT_ThamSoHTMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TRANS_CLI_HangDoiGuiMap());
            modelBuilder.Configurations.Add(new TRANS_CLI_HangDoiNhanMap());
            modelBuilder.Configurations.Add(new TRANS_CLI_NhatKyGuiMap());
            modelBuilder.Configurations.Add(new TRANS_CLI_NhatKyNhanMap());
            modelBuilder.Configurations.Add(new TRANS_LoaiDuLieuMap());
        }
    }
}
