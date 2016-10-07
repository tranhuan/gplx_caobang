using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DVCC3_GPLXMap : EntityTypeConfiguration<DVCC3_GPLX>
    {
        public DVCC3_GPLXMap()
        {
            // Primary Key
            this.HasKey(t => t.IDs);

            // Properties
            this.Property(t => t.MaDK)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.SoGPLXDaCo)
                .HasMaxLength(20);

            this.Property(t => t.HangGPLXDaCo)
                .HasMaxLength(20);

            this.Property(t => t.NoiCapGPLXDaCo)
                .HasMaxLength(20);

            this.Property(t => t.NgayCapGPLXDaCo)
                .HasMaxLength(20);

            this.Property(t => t.NgayHHGPLXDaCo)
                .HasMaxLength(20);

            this.Property(t => t.NgayTTGPLXDaCo)
                .HasMaxLength(20);

            this.Property(t => t.SoSeri)
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("DVCC3_GPLX");
            this.Property(t => t.IDs).HasColumnName("IDs");
            this.Property(t => t.MaDK).HasColumnName("MaDK");
            this.Property(t => t.SoGPLXDaCo).HasColumnName("SoGPLXDaCo");
            this.Property(t => t.HangGPLXDaCo).HasColumnName("HangGPLXDaCo");
            this.Property(t => t.NoiCapGPLXDaCo).HasColumnName("NoiCapGPLXDaCo");
            this.Property(t => t.NgayCapGPLXDaCo).HasColumnName("NgayCapGPLXDaCo");
            this.Property(t => t.NgayHHGPLXDaCo).HasColumnName("NgayHHGPLXDaCo");
            this.Property(t => t.NgayTTGPLXDaCo).HasColumnName("NgayTTGPLXDaCo");
            this.Property(t => t.SoSeri).HasColumnName("SoSeri");
            this.Property(t => t.idx).HasColumnName("idx");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
        }
    }
}
