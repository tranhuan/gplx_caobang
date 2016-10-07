using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class QTHT_NhatKyLoiMap : EntityTypeConfiguration<QTHT_NhatKyLoi>
    {
        public QTHT_NhatKyLoiMap()
        {
            // Primary Key
            this.HasKey(t => t.MaNK);

            // Properties
            this.Property(t => t.MaNK)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.NguoiSuDung)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TenChucNang)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ThaoTac)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ThongBaoLoi)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("QTHT_NhatKyLoi");
            this.Property(t => t.MaNK).HasColumnName("MaNK");
            this.Property(t => t.NguoiSuDung).HasColumnName("NguoiSuDung");
            this.Property(t => t.NgayThucHien).HasColumnName("NgayThucHien");
            this.Property(t => t.TenChucNang).HasColumnName("TenChucNang");
            this.Property(t => t.ThaoTac).HasColumnName("ThaoTac");
            this.Property(t => t.ThongBaoLoi).HasColumnName("ThongBaoLoi");
        }
    }
}
