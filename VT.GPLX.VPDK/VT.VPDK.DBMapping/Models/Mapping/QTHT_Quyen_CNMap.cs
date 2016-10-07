using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class QTHT_Quyen_CNMap : EntityTypeConfiguration<QTHT_Quyen_CN>
    {
        public QTHT_Quyen_CNMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IdRole, t.IdFunction });

            // Properties
            this.Property(t => t.IdRole)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IdFunction)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ghichu)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("QTHT_Quyen_CN");
            this.Property(t => t.IdRole).HasColumnName("IdRole");
            this.Property(t => t.IdFunction).HasColumnName("IdFunction");
            this.Property(t => t.Ghichu).HasColumnName("Ghichu");

            // Relationships
            this.HasRequired(t => t.QTHT_ChucNang)
                .WithMany(t => t.QTHT_Quyen_CN)
                .HasForeignKey(d => d.IdFunction);
            this.HasRequired(t => t.QTHT_Quyen)
                .WithMany(t => t.QTHT_Quyen_CN)
                .HasForeignKey(d => d.IdRole);

        }
    }
}
