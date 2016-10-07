using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class QTHT_NSD_NhomNSDMap : EntityTypeConfiguration<QTHT_NSD_NhomNSD>
    {
        public QTHT_NSD_NhomNSDMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IdUser, t.IdGroup });

            // Properties
            this.Property(t => t.IdUser)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.IdGroup)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("QTHT_NSD_NhomNSD");
            this.Property(t => t.IdUser).HasColumnName("IdUser");
            this.Property(t => t.IdGroup).HasColumnName("IdGroup");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.QTHT_NguoiDung)
                .WithMany(t => t.QTHT_NSD_NhomNSD)
                .HasForeignKey(d => d.IdUser);
            this.HasRequired(t => t.QTHT_NhomNSD)
                .WithMany(t => t.QTHT_NSD_NhomNSD)
                .HasForeignKey(d => d.IdGroup);

        }
    }
}
