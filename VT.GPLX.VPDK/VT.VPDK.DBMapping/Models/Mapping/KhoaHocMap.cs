using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class KhoaHocMap : EntityTypeConfiguration<KhoaHoc>
    {
        public KhoaHocMap()
        {
            // Primary Key
            this.HasKey(t => t.MaKH);

            // Properties
            this.Property(t => t.MaKH)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.MaCSDT)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.MaSoGTVT)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.TenKH)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HangGPLX)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.HangDT)
                .HasMaxLength(20);

            this.Property(t => t.SoQD_KhaiGiang)
                .HasMaxLength(20);

            this.Property(t => t.MucTieuDT)
                .HasMaxLength(1000);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("KhoaHoc");
            this.Property(t => t.MaKH).HasColumnName("MaKH");
            this.Property(t => t.MaCSDT).HasColumnName("MaCSDT");
            this.Property(t => t.MaSoGTVT).HasColumnName("MaSoGTVT");
            this.Property(t => t.TenKH).HasColumnName("TenKH");
            this.Property(t => t.HangGPLX).HasColumnName("HangGPLX");
            this.Property(t => t.HangDT).HasColumnName("HangDT");
            this.Property(t => t.SoQD_KhaiGiang).HasColumnName("SoQD_KhaiGiang");
            this.Property(t => t.NgayQD_KhaiGiang).HasColumnName("NgayQD_KhaiGiang");
            this.Property(t => t.NgayKG).HasColumnName("NgayKG");
            this.Property(t => t.NgayBG).HasColumnName("NgayBG");
            this.Property(t => t.MucTieuDT).HasColumnName("MucTieuDT");
            this.Property(t => t.NgayThi).HasColumnName("NgayThi");
            this.Property(t => t.NgaySH).HasColumnName("NgaySH");
            this.Property(t => t.TongSoHV).HasColumnName("TongSoHV");
            this.Property(t => t.SoHVTotNghiep).HasColumnName("SoHVTotNghiep");
            this.Property(t => t.SoHVDuocCapGPLX).HasColumnName("SoHVDuocCapGPLX");
            this.Property(t => t.ThoiGianDT).HasColumnName("ThoiGianDT");
            this.Property(t => t.SoNgayOnKT).HasColumnName("SoNgayOnKT");
            this.Property(t => t.SoNgayThucHoc).HasColumnName("SoNgayThucHoc");
            this.Property(t => t.SoNgayNghiLe).HasColumnName("SoNgayNghiLe");
            this.Property(t => t.TongSoNgay).HasColumnName("TongSoNgay");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");

            // Relationships
            this.HasRequired(t => t.DM_DonViGTVT)
                .WithMany(t => t.KhoaHocs)
                .HasForeignKey(d => d.MaCSDT);
            this.HasRequired(t => t.DM_DonViGTVT1)
                .WithMany(t => t.KhoaHocs1)
                .HasForeignKey(d => d.MaSoGTVT);
            this.HasOptional(t => t.DM_HangDT)
                .WithMany(t => t.KhoaHocs)
                .HasForeignKey(d => d.HangDT);
            this.HasRequired(t => t.DM_HangGPLX)
                .WithMany(t => t.KhoaHocs)
                .HasForeignKey(d => d.HangGPLX);

        }
    }
}
