using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class KySHMap : EntityTypeConfiguration<KySH>
    {
        public KySHMap()
        {
            // Primary Key
            this.HasKey(t => t.MaKySH);

            // Properties
            this.Property(t => t.MaKySH)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.MaTTSH)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.SoQD)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.NguoiQD)
                .HasMaxLength(50);

            this.Property(t => t.ChuTich_HDSH)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PhoChuTich_HDSH)
                .HasMaxLength(50);

            this.Property(t => t.UV_GD_TTSH)
                .HasMaxLength(50);

            this.Property(t => t.UV_ToTruong)
                .HasMaxLength(50);

            this.Property(t => t.UV_ThuKy)
                .HasMaxLength(50);

            this.Property(t => t.SoViPham)
                .HasMaxLength(100);

            this.Property(t => t.NX_ThucHien_QuyChe)
                .HasMaxLength(50);

            this.Property(t => t.NX_TrinhDo_CBSH)
                .HasMaxLength(50);

            this.Property(t => t.NX_CoSo_VCKT)
                .HasMaxLength(50);

            this.Property(t => t.NX_DamBao_AnToan)
                .HasMaxLength(50);

            this.Property(t => t.NX_VanDe_Khac)
                .HasMaxLength(50);

            this.Property(t => t.NhanXet)
                .HasMaxLength(100);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            this.Property(t => t.TenKySH)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("KySH");
            this.Property(t => t.MaKySH).HasColumnName("MaKySH");
            this.Property(t => t.MaTTSH).HasColumnName("MaTTSH");
            this.Property(t => t.NgaySH).HasColumnName("NgaySH");
            this.Property(t => t.GioSH).HasColumnName("GioSH");
            this.Property(t => t.SoQD).HasColumnName("SoQD");
            this.Property(t => t.NgayQD).HasColumnName("NgayQD");
            this.Property(t => t.NguoiQD).HasColumnName("NguoiQD");
            this.Property(t => t.ChuTich_HDSH).HasColumnName("ChuTich_HDSH");
            this.Property(t => t.PhoChuTich_HDSH).HasColumnName("PhoChuTich_HDSH");
            this.Property(t => t.UV_GD_TTSH).HasColumnName("UV_GD_TTSH");
            this.Property(t => t.UV_ToTruong).HasColumnName("UV_ToTruong");
            this.Property(t => t.UV_ThuKy).HasColumnName("UV_ThuKy");
            this.Property(t => t.TongSoDK).HasColumnName("TongSoDK");
            this.Property(t => t.SoDuSH).HasColumnName("SoDuSH");
            this.Property(t => t.SoDat).HasColumnName("SoDat");
            this.Property(t => t.SoKhongDat).HasColumnName("SoKhongDat");
            this.Property(t => t.SoVang).HasColumnName("SoVang");
            this.Property(t => t.SoVangThiHinh).HasColumnName("SoVangThiHinh");
            this.Property(t => t.SoVangThiDuong).HasColumnName("SoVangThiDuong");
            this.Property(t => t.SoDuSHLanDau).HasColumnName("SoDuSHLanDau");
            this.Property(t => t.SoDatSHLanDau).HasColumnName("SoDatSHLanDau");
            this.Property(t => t.TyLeDat).HasColumnName("TyLeDat");
            this.Property(t => t.SoViPham).HasColumnName("SoViPham");
            this.Property(t => t.SHHaiLan).HasColumnName("SHHaiLan");
            this.Property(t => t.NX_ThucHien_QuyChe).HasColumnName("NX_ThucHien_QuyChe");
            this.Property(t => t.NX_TrinhDo_CBSH).HasColumnName("NX_TrinhDo_CBSH");
            this.Property(t => t.NX_CoSo_VCKT).HasColumnName("NX_CoSo_VCKT");
            this.Property(t => t.NX_DamBao_AnToan).HasColumnName("NX_DamBao_AnToan");
            this.Property(t => t.NX_VanDe_Khac).HasColumnName("NX_VanDe_Khac");
            this.Property(t => t.NhanXet).HasColumnName("NhanXet");
            this.Property(t => t.LePhi_LyThuyet).HasColumnName("LePhi_LyThuyet");
            this.Property(t => t.LePhi_ThiHinh).HasColumnName("LePhi_ThiHinh");
            this.Property(t => t.LePhi_ThiDuong).HasColumnName("LePhi_ThiDuong");
            this.Property(t => t.LePhi_CapGPLX).HasColumnName("LePhi_CapGPLX");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
            this.Property(t => t.TenKySH).HasColumnName("TenKySH");

            // Relationships
            this.HasRequired(t => t.DM_DonViGTVT)
                .WithMany(t => t.KySHes)
                .HasForeignKey(d => d.MaTTSH);

        }
    }
}
