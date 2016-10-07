using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DM_MonHocMap : EntityTypeConfiguration<DM_MonHoc>
    {
        public DM_MonHocMap()
        {
            // Primary Key
            this.HasKey(t => t.MaMH);

            // Properties
            this.Property(t => t.TenMH)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VPPL)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DM_MonHoc");
            this.Property(t => t.MaMH).HasColumnName("MaMH");
            this.Property(t => t.TenMH).HasColumnName("TenMH");
            this.Property(t => t.VPPL).HasColumnName("VPPL");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
        }
    }
}
