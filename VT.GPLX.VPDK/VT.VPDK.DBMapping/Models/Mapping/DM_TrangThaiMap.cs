using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DM_TrangThaiMap : EntityTypeConfiguration<DM_TrangThai>
    {
        public DM_TrangThaiMap()
        {
            // Primary Key
            this.HasKey(t => t.MaTT);

            // Properties
            this.Property(t => t.MaTT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.TenTT)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DM_TrangThai");
            this.Property(t => t.MaTT).HasColumnName("MaTT");
            this.Property(t => t.TenTT).HasColumnName("TenTT");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
        }
    }
}
