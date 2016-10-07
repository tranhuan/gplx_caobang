using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class NguoiLXHS_GiayToMap : EntityTypeConfiguration<NguoiLXHS_GiayTo>
    {
        public NguoiLXHS_GiayToMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MaGT, t.MaDK });

            // Properties
            this.Property(t => t.MaGT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MaDK)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.SoHoSo)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.TenGT)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("NguoiLXHS_GiayTo");
            this.Property(t => t.MaGT).HasColumnName("MaGT");
            this.Property(t => t.MaDK).HasColumnName("MaDK");
            this.Property(t => t.SoHoSo).HasColumnName("SoHoSo");
            this.Property(t => t.TenGT).HasColumnName("TenGT");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");

            // Relationships
            this.HasRequired(t => t.DM_GiayTo)
                .WithMany(t => t.NguoiLXHS_GiayTo)
                .HasForeignKey(d => d.MaGT);
            this.HasRequired(t => t.NguoiLX_HoSo)
                .WithMany(t => t.NguoiLXHS_GiayTo)
                .HasForeignKey(d => d.MaDK);

        }
    }
}
