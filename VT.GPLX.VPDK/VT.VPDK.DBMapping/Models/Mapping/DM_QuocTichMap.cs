using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DM_QuocTichMap : EntityTypeConfiguration<DM_QuocTich>
    {
        public DM_QuocTichMap()
        {
            // Primary Key
            this.HasKey(t => t.Ma);

            // Properties
            this.Property(t => t.Ma)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.TenEN)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.TenVN)
                .HasMaxLength(200);

            this.Property(t => t.GhiChu)
                .HasMaxLength(300);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DM_QuocTich");
            this.Property(t => t.Ma).HasColumnName("Ma");
            this.Property(t => t.TenEN).HasColumnName("TenEN");
            this.Property(t => t.TenVN).HasColumnName("TenVN");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
        }
    }
}
