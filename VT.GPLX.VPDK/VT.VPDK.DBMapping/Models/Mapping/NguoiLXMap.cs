using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class NguoiLXMap : EntityTypeConfiguration<NguoiLX>
    {
        public NguoiLXMap()
        {
            // Primary Key
            this.HasKey(t => t.MaDK);

            // Properties
            this.Property(t => t.MaDK)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.DonViNhanHSo)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.HoDemNLX)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.TenNLX)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.HoVaTen)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MaQuocTich)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.NgaySinh)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.NoiTT)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NoiTT_MaDVHC)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.NoiTT_MaDVQL)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.NoiCT)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NoiCT_MaDVHC)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.NoiCT_MaDVQL)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.SoCMT)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.NoiCapCMT)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            this.Property(t => t.GioiTinh)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.HoVaTenIn)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.SO_CMND_CU)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("NguoiLX");
            this.Property(t => t.MaDK).HasColumnName("MaDK");
            this.Property(t => t.DonViNhanHSo).HasColumnName("DonViNhanHSo");
            this.Property(t => t.HoDemNLX).HasColumnName("HoDemNLX");
            this.Property(t => t.TenNLX).HasColumnName("TenNLX");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.MaQuocTich).HasColumnName("MaQuocTich");
            this.Property(t => t.NgaySinh).HasColumnName("NgaySinh");
            this.Property(t => t.NoiTT).HasColumnName("NoiTT");
            this.Property(t => t.NoiTT_MaDVHC).HasColumnName("NoiTT_MaDVHC");
            this.Property(t => t.NoiTT_MaDVQL).HasColumnName("NoiTT_MaDVQL");
            this.Property(t => t.NoiCT).HasColumnName("NoiCT");
            this.Property(t => t.NoiCT_MaDVHC).HasColumnName("NoiCT_MaDVHC");
            this.Property(t => t.NoiCT_MaDVQL).HasColumnName("NoiCT_MaDVQL");
            this.Property(t => t.SoCMT).HasColumnName("SoCMT");
            this.Property(t => t.NgayCapCMT).HasColumnName("NgayCapCMT");
            this.Property(t => t.NoiCapCMT).HasColumnName("NoiCapCMT");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
            this.Property(t => t.GioiTinh).HasColumnName("GioiTinh");
            this.Property(t => t.HoVaTenIn).HasColumnName("HoVaTenIn");
            this.Property(t => t.SO_CMND_CU).HasColumnName("SO_CMND_CU");

            // Relationships
            this.HasRequired(t => t.DM_DonViGTVT)
                .WithMany(t => t.NguoiLXes)
                .HasForeignKey(d => d.DonViNhanHSo);
            this.HasRequired(t => t.DM_DVHC)
                .WithMany(t => t.NguoiLXes)
                .HasForeignKey(d => new { d.NoiCT_MaDVHC, d.NoiCT_MaDVQL });
            this.HasRequired(t => t.DM_DVHC1)
                .WithMany(t => t.NguoiLXes1)
                .HasForeignKey(d => new { d.NoiTT_MaDVHC, d.NoiTT_MaDVQL });
            this.HasRequired(t => t.DM_QuocTich)
                .WithMany(t => t.NguoiLXes)
                .HasForeignKey(d => d.MaQuocTich);

        }
    }
}
