using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DM_LoaiDVMap : EntityTypeConfiguration<DM_LoaiDV>
    {
        public DM_LoaiDVMap()
        {
            // Primary Key
            this.HasKey(t => t.MaLoaiDV);

            // Properties
            this.Property(t => t.MaLoaiDV)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.TenLoaiDV)
                .HasMaxLength(50);

            this.Property(t => t.LoaiDV)
                .HasMaxLength(10);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DM_LoaiDV");
            this.Property(t => t.MaLoaiDV).HasColumnName("MaLoaiDV");
            this.Property(t => t.TenLoaiDV).HasColumnName("TenLoaiDV");
            this.Property(t => t.LoaiDV).HasColumnName("LoaiDV");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
        }
    }
}
