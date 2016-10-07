using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class QTHT_NSD_Quyen_CNMap : EntityTypeConfiguration<QTHT_NSD_Quyen_CN>
    {
        public QTHT_NSD_Quyen_CNMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserName, t.IdFunction });

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.IdRole)
                .HasMaxLength(50);

            this.Property(t => t.IdFunction)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("QTHT_NSD_Quyen_CN");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.IdRole).HasColumnName("IdRole");
            this.Property(t => t.IdFunction).HasColumnName("IdFunction");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasMany(t => t.QTHT_Quyen)
                .WithMany(t => t.QTHT_NSD_Quyen_CN)
                .Map(m =>
                    {
                        m.ToTable("QTHT_NSD_QUYEN");
                        m.MapLeftKey("UserName", "IdFunction");
                        m.MapRightKey("IdRole");
                    });

            this.HasRequired(t => t.QTHT_ChucNang)
                .WithMany(t => t.QTHT_NSD_Quyen_CN)
                .HasForeignKey(d => d.IdFunction);
            this.HasRequired(t => t.QTHT_NguoiDung)
                .WithMany(t => t.QTHT_NSD_Quyen_CN)
                .HasForeignKey(d => d.UserName);

        }
    }
}
