using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class QTHT_QuyenMap : EntityTypeConfiguration<QTHT_Quyen>
    {
        public QTHT_QuyenMap()
        {
            // Primary Key
            this.HasKey(t => t.IdRole);

            // Properties
            this.Property(t => t.IdRole)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QTHT_Quyen");
            this.Property(t => t.IdRole).HasColumnName("IdRole");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
        }
    }
}
