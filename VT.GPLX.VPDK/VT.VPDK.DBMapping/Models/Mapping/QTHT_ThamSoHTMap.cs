using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class QTHT_ThamSoHTMap : EntityTypeConfiguration<QTHT_ThamSoHT>
    {
        public QTHT_ThamSoHTMap()
        {
            // Primary Key
            this.HasKey(t => t.MaTS);

            // Properties
            this.Property(t => t.MaTS)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.DonViSuDung)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.TenTS)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.GiaTriTS)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("QTHT_ThamSoHT");
            this.Property(t => t.MaTS).HasColumnName("MaTS");
            this.Property(t => t.DonViSuDung).HasColumnName("DonViSuDung");
            this.Property(t => t.TenTS).HasColumnName("TenTS");
            this.Property(t => t.GiaTriTS).HasColumnName("GiaTriTS");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
            this.Property(t => t.IsUpdate).HasColumnName("IsUpdate");
        }
    }
}
