using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class QTHT_NhomCNMap : EntityTypeConfiguration<QTHT_NhomCN>
    {
        public QTHT_NhomCNMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IdGroup, t.IdFunction });

            // Properties
            this.Property(t => t.IdGroup)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IdFunction)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("QTHT_NhomCN");
            this.Property(t => t.IdGroup).HasColumnName("IdGroup");
            this.Property(t => t.IdFunction).HasColumnName("IdFunction");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.QTHT_ChucNang)
                .WithMany(t => t.QTHT_NhomCN)
                .HasForeignKey(d => d.IdFunction);
            this.HasRequired(t => t.QTHT_NhomNSD)
                .WithMany(t => t.QTHT_NhomCN)
                .HasForeignKey(d => d.IdGroup);

        }
    }
}
