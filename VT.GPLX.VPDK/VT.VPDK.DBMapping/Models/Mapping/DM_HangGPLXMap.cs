using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DM_HangGPLXMap : EntityTypeConfiguration<DM_HangGPLX>
    {
        public DM_HangGPLXMap()
        {
            // Primary Key
            this.HasKey(t => t.MaHang);

            // Properties
            this.Property(t => t.MaHang)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.TenHang)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MoTaVN)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.MoTaEN)
                .HasMaxLength(300);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DM_HangGPLX");
            this.Property(t => t.MaHang).HasColumnName("MaHang");
            this.Property(t => t.TenHang).HasColumnName("TenHang");
            this.Property(t => t.HanSuDung).HasColumnName("HanSuDung");
            this.Property(t => t.MoTaVN).HasColumnName("MoTaVN");
            this.Property(t => t.MoTaEN).HasColumnName("MoTaEN");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
        }
    }
}
