using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DVCC3_HoSoMap : EntityTypeConfiguration<DVCC3_HoSo>
    {
        public DVCC3_HoSoMap()
        {
            // Primary Key
            this.HasKey(t => t.IDs);

            // Properties
            this.Property(t => t.MaDK)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.MaDK_Core)
                .HasMaxLength(25);

            this.Property(t => t.HoDemNLX)
                .HasMaxLength(30);

            this.Property(t => t.TenNLX)
                .HasMaxLength(20);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(70);

            this.Property(t => t.HoVaTenIn)
                .HasMaxLength(50);

            this.Property(t => t.NgaySinh)
                .HasMaxLength(8);

            this.Property(t => t.GioiTinh)
                .HasMaxLength(2);

            this.Property(t => t.MaQuocTich)
                .HasMaxLength(3);

            this.Property(t => t.NoiTT)
                .HasMaxLength(50);

            this.Property(t => t.NoiTT_MaDVHC)
                .HasMaxLength(5);

            this.Property(t => t.NoiTT_MaDVQL)
                .HasMaxLength(5);

            this.Property(t => t.NoiCT)
                .HasMaxLength(50);

            this.Property(t => t.NoiCT_MaDVHC)
                .HasMaxLength(5);

            this.Property(t => t.NoiCT_MaDVQL)
                .HasMaxLength(5);

            this.Property(t => t.SoCMT)
                .HasMaxLength(20);

            this.Property(t => t.NgayCapCMT)
                .HasMaxLength(20);

            this.Property(t => t.NoiCapCMT)
                .HasMaxLength(50);

            this.Property(t => t.SoHoSo)
                .HasMaxLength(18);

            this.Property(t => t.TT_XuLy)
                .HasMaxLength(2);

            this.Property(t => t.MaSoGTVT)
                .HasMaxLength(6);

            this.Property(t => t.MaDVNhanHSo)
                .HasMaxLength(6);

            this.Property(t => t.NgayNhanHSo)
                .HasMaxLength(20);

            this.Property(t => t.NguoiNhanHSo)
                .HasMaxLength(50);

            this.Property(t => t.NgayHenTra)
                .HasMaxLength(20);

            this.Property(t => t.MaLoaiHs)
                .HasMaxLength(10);

            this.Property(t => t.DonViHocLX)
                .HasMaxLength(6);

            this.Property(t => t.NamHocLX)
                .HasMaxLength(10);

            this.Property(t => t.HangGPLX)
                .HasMaxLength(3);

            this.Property(t => t.SoNamLX)
                .HasMaxLength(10);

            this.Property(t => t.SoKmLXAnToan)
                .HasMaxLength(10);

            this.Property(t => t.LyDoCapDoi)
                .HasMaxLength(255);

            this.Property(t => t.MucDichCapDoi)
                .HasMaxLength(255);

            this.Property(t => t.NamcapLandau)
                .HasMaxLength(4);

            this.Property(t => t.SoGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.HangGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.DonViCapGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.NoiCapGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.NgayCapGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.NgayHHGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.NgayTTGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.QUOCTE_NOI_SINH)
                .HasMaxLength(50);

            this.Property(t => t.SO_SERI)
                .HasMaxLength(50);

            this.Property(t => t.BUUCHINH_TEN)
                .HasMaxLength(50);

            this.Property(t => t.BUUCHINH_DIENTHOAI)
                .HasMaxLength(50);

            this.Property(t => t.BUUCHINH_DIACHI)
                .HasMaxLength(50);

            this.Property(t => t.BUUCHINH_DIACHI_CODE)
                .HasMaxLength(50);

            this.Property(t => t.QUOC_TE)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DVCC3_HoSo");
            this.Property(t => t.IDs).HasColumnName("IDs");
            this.Property(t => t.MaDK).HasColumnName("MaDK");
            this.Property(t => t.MaDK_Core).HasColumnName("MaDK_Core");
            this.Property(t => t.HoDemNLX).HasColumnName("HoDemNLX");
            this.Property(t => t.TenNLX).HasColumnName("TenNLX");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.HoVaTenIn).HasColumnName("HoVaTenIn");
            this.Property(t => t.NgaySinh).HasColumnName("NgaySinh");
            this.Property(t => t.GioiTinh).HasColumnName("GioiTinh");
            this.Property(t => t.MaQuocTich).HasColumnName("MaQuocTich");
            this.Property(t => t.NoiTT).HasColumnName("NoiTT");
            this.Property(t => t.NoiTT_MaDVHC).HasColumnName("NoiTT_MaDVHC");
            this.Property(t => t.NoiTT_MaDVQL).HasColumnName("NoiTT_MaDVQL");
            this.Property(t => t.NoiCT).HasColumnName("NoiCT");
            this.Property(t => t.NoiCT_MaDVHC).HasColumnName("NoiCT_MaDVHC");
            this.Property(t => t.NoiCT_MaDVQL).HasColumnName("NoiCT_MaDVQL");
            this.Property(t => t.SoCMT).HasColumnName("SoCMT");
            this.Property(t => t.NgayCapCMT).HasColumnName("NgayCapCMT");
            this.Property(t => t.NoiCapCMT).HasColumnName("NoiCapCMT");
            this.Property(t => t.SoHoSo).HasColumnName("SoHoSo");
            this.Property(t => t.TT_XuLy).HasColumnName("TT_XuLy");
            this.Property(t => t.MaSoGTVT).HasColumnName("MaSoGTVT");
            this.Property(t => t.MaDVNhanHSo).HasColumnName("MaDVNhanHSo");
            this.Property(t => t.NgayNhanHSo).HasColumnName("NgayNhanHSo");
            this.Property(t => t.NguoiNhanHSo).HasColumnName("NguoiNhanHSo");
            this.Property(t => t.NgayHenTra).HasColumnName("NgayHenTra");
            this.Property(t => t.MaLoaiHs).HasColumnName("MaLoaiHs");
            this.Property(t => t.DonViHocLX).HasColumnName("DonViHocLX");
            this.Property(t => t.NamHocLX).HasColumnName("NamHocLX");
            this.Property(t => t.HangGPLX).HasColumnName("HangGPLX");
            this.Property(t => t.SoNamLX).HasColumnName("SoNamLX");
            this.Property(t => t.SoKmLXAnToan).HasColumnName("SoKmLXAnToan");
            this.Property(t => t.LyDoCapDoi).HasColumnName("LyDoCapDoi");
            this.Property(t => t.MucDichCapDoi).HasColumnName("MucDichCapDoi");
            this.Property(t => t.NamcapLandau).HasColumnName("NamcapLandau");
            this.Property(t => t.SoGPLXDaCo).HasColumnName("SoGPLXDaCo");
            this.Property(t => t.HangGPLXDaCo).HasColumnName("HangGPLXDaCo");
            this.Property(t => t.DonViCapGPLXDaCo).HasColumnName("DonViCapGPLXDaCo");
            this.Property(t => t.NoiCapGPLXDaCo).HasColumnName("NoiCapGPLXDaCo");
            this.Property(t => t.NgayCapGPLXDaCo).HasColumnName("NgayCapGPLXDaCo");
            this.Property(t => t.NgayHHGPLXDaCo).HasColumnName("NgayHHGPLXDaCo");
            this.Property(t => t.NgayTTGPLXDaCo).HasColumnName("NgayTTGPLXDaCo");
            this.Property(t => t.NgayDangkyOnline).HasColumnName("NgayDangkyOnline");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Transfer_flag).HasColumnName("Transfer_flag");
            this.Property(t => t.QUOCTE_NOI_SINH).HasColumnName("QUOCTE_NOI_SINH");
            this.Property(t => t.SO_SERI).HasColumnName("SO_SERI");
            this.Property(t => t.BUUCHINH_TEN).HasColumnName("BUUCHINH_TEN");
            this.Property(t => t.BUUCHINH_DIENTHOAI).HasColumnName("BUUCHINH_DIENTHOAI");
            this.Property(t => t.BUUCHINH_DIACHI).HasColumnName("BUUCHINH_DIACHI");
            this.Property(t => t.BUUCHINH_DIACHI_CODE).HasColumnName("BUUCHINH_DIACHI_CODE");
            this.Property(t => t.QUOC_TE).HasColumnName("QUOC_TE");
        }
    }
}
