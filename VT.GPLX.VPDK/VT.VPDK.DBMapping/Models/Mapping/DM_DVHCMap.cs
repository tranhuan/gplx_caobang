using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DM_DVHCMap : EntityTypeConfiguration<DM_DVHC>
    {
        public DM_DVHCMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MaDvhc, t.MaDVQL });

            // Properties
            this.Property(t => t.MaDvhc)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.MaDVQL)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.MaDV)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.TenDvhc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TenNganGon)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TenDayDu)
                .HasMaxLength(100);

            this.Property(t => t.LoaiDvhc)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DM_DVHC");
            this.Property(t => t.MaDvhc).HasColumnName("MaDvhc");
            this.Property(t => t.MaDVQL).HasColumnName("MaDVQL");
            this.Property(t => t.MaDV).HasColumnName("MaDV");
            this.Property(t => t.TenDvhc).HasColumnName("TenDvhc");
            this.Property(t => t.TenNganGon).HasColumnName("TenNganGon");
            this.Property(t => t.TenDayDu).HasColumnName("TenDayDu");
            this.Property(t => t.LoaiDvhc).HasColumnName("LoaiDvhc");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
        }
    }
}
