using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class QTHT_ChucNangMap : EntityTypeConfiguration<QTHT_ChucNang>
    {
        public QTHT_ChucNangMap()
        {
            // Primary Key
            this.HasKey(t => t.IdFunction);

            // Properties
            this.Property(t => t.IdFunction)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IdParentFunction)
                .HasMaxLength(50);

            this.Property(t => t.FunctionName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Assemply)
                .HasMaxLength(128);

            this.Property(t => t.UserControlPath)
                .HasMaxLength(128);

            this.Property(t => t.ImagePath)
                .HasMaxLength(128);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("QTHT_ChucNang");
            this.Property(t => t.IdFunction).HasColumnName("IdFunction");
            this.Property(t => t.IdParentFunction).HasColumnName("IdParentFunction");
            this.Property(t => t.FunctionName).HasColumnName("FunctionName");
            this.Property(t => t.Assemply).HasColumnName("Assemply");
            this.Property(t => t.UserControlPath).HasColumnName("UserControlPath");
            this.Property(t => t.ImagePath).HasColumnName("ImagePath");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.OderBy).HasColumnName("OderBy");

            // Relationships
            this.HasOptional(t => t.QTHT_ChucNang2)
                .WithMany(t => t.QTHT_ChucNang1)
                .HasForeignKey(d => d.IdParentFunction);

        }
    }
}
