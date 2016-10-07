using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DM_LoaiHSoMap : EntityTypeConfiguration<DM_LoaiHSo>
    {
        public DM_LoaiHSoMap()
        {
            // Primary Key
            this.HasKey(t => t.MaLoaiHs);

            // Properties
            this.Property(t => t.MaLoaiHs)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TenLoaiHs)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.SoVBPL)
                .HasMaxLength(50);

            this.Property(t => t.DieuKien)
                .HasMaxLength(150);

            this.Property(t => t.YeuCauDTSHLai)
                .HasMaxLength(50);

            this.Property(t => t.MaHTCap)
                .HasMaxLength(5);

            this.Property(t => t.Nhom)
                .HasMaxLength(10);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            this.Property(t => t.Hanoi)
                .HasMaxLength(150);

            this.Property(t => t.HanoiViettat)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DM_LoaiHSo");
            this.Property(t => t.MaLoaiHs).HasColumnName("MaLoaiHs");
            this.Property(t => t.TenLoaiHs).HasColumnName("TenLoaiHs");
            this.Property(t => t.ThoiHanTraKQ).HasColumnName("ThoiHanTraKQ");
            this.Property(t => t.SoVBPL).HasColumnName("SoVBPL");
            this.Property(t => t.DieuKien).HasColumnName("DieuKien");
            this.Property(t => t.YeuCauDTSHLai).HasColumnName("YeuCauDTSHLai");
            this.Property(t => t.MaHTCap).HasColumnName("MaHTCap");
            this.Property(t => t.MaNoiDungSH).HasColumnName("MaNoiDungSH");
            this.Property(t => t.Nhom).HasColumnName("Nhom");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
            this.Property(t => t.Hanoi).HasColumnName("Hanoi");
            this.Property(t => t.HanoiViettat).HasColumnName("HanoiViettat");
        }
    }
}
