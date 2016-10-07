using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DM_HangDTMap : EntityTypeConfiguration<DM_HangDT>
    {
        public DM_HangDTMap()
        {
            // Primary Key
            this.HasKey(t => t.MaHangDT);

            // Properties
            this.Property(t => t.MaHangDT)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.TenHangDT)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HangGPLX)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.SoVBPL)
                .HasMaxLength(30);

            this.Property(t => t.DKSH)
                .HasMaxLength(255);

            this.Property(t => t.MucTieuDT)
                .HasMaxLength(500);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DM_HangDT");
            this.Property(t => t.MaHangDT).HasColumnName("MaHangDT");
            this.Property(t => t.TenHangDT).HasColumnName("TenHangDT");
            this.Property(t => t.HangGPLX).HasColumnName("HangGPLX");
            this.Property(t => t.SoVBPL).HasColumnName("SoVBPL");
            this.Property(t => t.TuoiHV).HasColumnName("TuoiHV");
            this.Property(t => t.ThamNien).HasColumnName("ThamNien");
            this.Property(t => t.KmLXAT).HasColumnName("KmLXAT");
            this.Property(t => t.DKSH).HasColumnName("DKSH");
            this.Property(t => t.MucTieuDT).HasColumnName("MucTieuDT");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
        }
    }
}
