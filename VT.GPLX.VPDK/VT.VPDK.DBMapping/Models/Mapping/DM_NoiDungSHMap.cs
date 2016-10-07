using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DM_NoiDungSHMap : EntityTypeConfiguration<DM_NoiDungSH>
    {
        public DM_NoiDungSHMap()
        {
            // Primary Key
            this.HasKey(t => t.MaNoiDungSH);

            // Properties
            this.Property(t => t.TenNoiDungSH)
                .HasMaxLength(100);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DM_NoiDungSH");
            this.Property(t => t.MaNoiDungSH).HasColumnName("MaNoiDungSH");
            this.Property(t => t.TenNoiDungSH).HasColumnName("TenNoiDungSH");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
            this.Property(t => t.LePhiSatHach).HasColumnName("LePhiSatHach");
        }
    }
}
