using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class NguoiLX_Hoso_DichVuMap : EntityTypeConfiguration<NguoiLX_Hoso_DichVu>
    {
        public NguoiLX_Hoso_DichVuMap()
        {
            // Primary Key
            this.HasKey(t => t.MADK);

            // Properties
            this.Property(t => t.MADK)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.MADK_DVCC3)
                .HasMaxLength(25);

            this.Property(t => t.TEN)
                .HasMaxLength(100);

            this.Property(t => t.DIEN_THOAI)
                .HasMaxLength(20);

            this.Property(t => t.MA_DVHC)
                .HasMaxLength(10);

            this.Property(t => t.DIACHI)
                .HasMaxLength(100);

            this.Property(t => t.LYDO)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("NguoiLX_Hoso_DichVu");
            this.Property(t => t.MADK).HasColumnName("MADK");
            this.Property(t => t.MADK_DVCC3).HasColumnName("MADK_DVCC3");
            this.Property(t => t.TEN).HasColumnName("TEN");
            this.Property(t => t.DIEN_THOAI).HasColumnName("DIEN_THOAI");
            this.Property(t => t.MA_DVHC).HasColumnName("MA_DVHC");
            this.Property(t => t.DIACHI).HasColumnName("DIACHI");
            this.Property(t => t.TRANG_THAI).HasColumnName("TRANG_THAI");
            this.Property(t => t.LYDO).HasColumnName("LYDO");
            this.Property(t => t.LASTUPDATED).HasColumnName("LASTUPDATED");

            // Relationships
            this.HasRequired(t => t.NguoiLX_HoSo)
                .WithOptional(t => t.NguoiLX_Hoso_DichVu);

        }
    }
}
