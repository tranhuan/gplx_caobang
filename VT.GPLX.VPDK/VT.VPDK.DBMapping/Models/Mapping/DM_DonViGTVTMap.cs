using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class DM_DonViGTVTMap : EntityTypeConfiguration<DM_DonViGTVT>
    {
        public DM_DonViGTVTMap()
        {
            // Primary Key
            this.HasKey(t => t.MaDV);

            // Properties
            this.Property(t => t.MaDV)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.MaDVQL)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.LoaiDV)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.TenDV)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CoQuanQL)
                .HasMaxLength(100);

            this.Property(t => t.CacHangGPLX)
                .HasMaxLength(50);

            this.Property(t => t.DienThoai)
                .HasMaxLength(20);

            this.Property(t => t.Fax)
                .HasMaxLength(20);

            this.Property(t => t.DiaChi)
                .HasMaxLength(100);

            this.Property(t => t.SoGP)
                .HasMaxLength(20);

            this.Property(t => t.LanhDao)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            this.Property(t => t.Website)
                .HasMaxLength(100);

            this.Property(t => t.DiaDiemDaoTao)
                .HasMaxLength(300);

            this.Property(t => t.MaDvOld)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("DM_DonViGTVT");
            this.Property(t => t.MaDV).HasColumnName("MaDV");
            this.Property(t => t.MaDVQL).HasColumnName("MaDVQL");
            this.Property(t => t.LoaiDV).HasColumnName("LoaiDV");
            this.Property(t => t.TenDV).HasColumnName("TenDV");
            this.Property(t => t.CoQuanQL).HasColumnName("CoQuanQL");
            this.Property(t => t.LoaiTTSH).HasColumnName("LoaiTTSH");
            this.Property(t => t.CacHangGPLX).HasColumnName("CacHangGPLX");
            this.Property(t => t.DienThoai).HasColumnName("DienThoai");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.DiaChi).HasColumnName("DiaChi");
            this.Property(t => t.LuuLuongDT).HasColumnName("LuuLuongDT");
            this.Property(t => t.SoGP).HasColumnName("SoGP");
            this.Property(t => t.NgayGP).HasColumnName("NgayGP");
            this.Property(t => t.LanhDao).HasColumnName("LanhDao");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.DienTichSanTap).HasColumnName("DienTichSanTap");
            this.Property(t => t.NgayHHGP).HasColumnName("NgayHHGP");
            this.Property(t => t.DiaDiemDaoTao).HasColumnName("DiaDiemDaoTao");
            this.Property(t => t.MaDvOld).HasColumnName("MaDvOld");
        }
    }
}
