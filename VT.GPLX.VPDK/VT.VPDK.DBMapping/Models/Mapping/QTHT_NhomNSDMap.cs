using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class QTHT_NhomNSDMap : EntityTypeConfiguration<QTHT_NhomNSD>
    {
        public QTHT_NhomNSDMap()
        {
            // Primary Key
            this.HasKey(t => t.IdGroup);

            // Properties
            this.Property(t => t.IdGroup)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TenNhom)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("QTHT_NhomNSD");
            this.Property(t => t.IdGroup).HasColumnName("IdGroup");
            this.Property(t => t.TenNhom).HasColumnName("TenNhom");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.UseFlag).HasColumnName("UseFlag");
        }
    }
}
