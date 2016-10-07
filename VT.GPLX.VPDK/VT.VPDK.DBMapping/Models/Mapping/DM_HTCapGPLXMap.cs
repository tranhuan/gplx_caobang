using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DM_HTCapGPLXMap : EntityTypeConfiguration<DM_HTCapGPLX>
    {
        public DM_HTCapGPLXMap()
        {
            // Primary Key
            this.HasKey(t => t.MaHTCap);

            // Properties
            this.Property(t => t.MaHTCap)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.TenHTCap)
                .HasMaxLength(70);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DM_HTCapGPLX");
            this.Property(t => t.MaHTCap).HasColumnName("MaHTCap");
            this.Property(t => t.TenHTCap).HasColumnName("TenHTCap");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
        }
    }
}
