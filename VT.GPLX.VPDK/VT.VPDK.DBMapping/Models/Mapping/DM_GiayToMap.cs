using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DM_GiayToMap : EntityTypeConfiguration<DM_GiayTo>
    {
        public DM_GiayToMap()
        {
            // Primary Key
            this.HasKey(t => t.MaGT);

            // Properties
            this.Property(t => t.TenGT)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.TenGTEN)
                .HasMaxLength(150);

            this.Property(t => t.SoVBPL)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DM_GiayTo");
            this.Property(t => t.MaGT).HasColumnName("MaGT");
            this.Property(t => t.TenGT).HasColumnName("TenGT");
            this.Property(t => t.TenGTEN).HasColumnName("TenGTEN");
            this.Property(t => t.SoVBPL).HasColumnName("SoVBPL");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
        }
    }
}
