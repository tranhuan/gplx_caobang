using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class NguoiLX_GPLXMap : EntityTypeConfiguration<NguoiLX_GPLX>
    {
        public NguoiLX_GPLXMap()
        {
            // Primary Key
            this.HasKey(t => t.MaDK);

            // Properties
            this.Property(t => t.MaDK)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.SoGPLX)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.HangGPLX)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.SoHoSo)
                .HasMaxLength(18);

            this.Property(t => t.SoGPLXCu)
                .HasMaxLength(20);

            this.Property(t => t.NoiCapGPLX)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.CoQuanQLGPLX)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.MoTaVN)
                .HasMaxLength(255);

            this.Property(t => t.MoTaEN)
                .HasMaxLength(255);

            this.Property(t => t.NguoiKy)
                .HasMaxLength(255);

            this.Property(t => t.MaHTCap)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.NoiHocGPLX)
                .HasMaxLength(6);

            this.Property(t => t.DuongDanAnh)
                .HasMaxLength(255);

            this.Property(t => t.HoTenDem)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TenNLX)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.HoVaTen)
                .IsRequired()
                .HasMaxLength(70);

            this.Property(t => t.NgaySinh)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.MaQuocTich)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.NoiCT)
                .HasMaxLength(50);

            this.Property(t => t.NoiCT_MaDVHC)
                .HasMaxLength(5);

            this.Property(t => t.NoiCT_MaDVQL)
                .HasMaxLength(5);

            this.Property(t => t.SoCMT)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SoSeri)
                .HasMaxLength(20);

            this.Property(t => t.NoiIn)
                .HasMaxLength(50);

            this.Property(t => t.NguoiTra)
                .HasMaxLength(50);

            this.Property(t => t.NoiTra)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            this.Property(t => t.GioiTinh)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Hanoi)
                .HasMaxLength(150);

            this.Property(t => t.HanoiViettat)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("NguoiLX_GPLX");
            this.Property(t => t.MaDK).HasColumnName("MaDK");
            this.Property(t => t.SoGPLX).HasColumnName("SoGPLX");
            this.Property(t => t.HangGPLX).HasColumnName("HangGPLX");
            this.Property(t => t.SoHoSo).HasColumnName("SoHoSo");
            this.Property(t => t.SoGPLXCu).HasColumnName("SoGPLXCu");
            this.Property(t => t.NoiCapGPLX).HasColumnName("NoiCapGPLX");
            this.Property(t => t.NgayCapGPLX).HasColumnName("NgayCapGPLX");
            this.Property(t => t.CoQuanQLGPLX).HasColumnName("CoQuanQLGPLX");
            this.Property(t => t.NgayHHGPLX).HasColumnName("NgayHHGPLX");
            this.Property(t => t.NgayTTGPLX).HasColumnName("NgayTTGPLX");
            this.Property(t => t.MoTaVN).HasColumnName("MoTaVN");
            this.Property(t => t.MoTaEN).HasColumnName("MoTaEN");
            this.Property(t => t.NguoiKy).HasColumnName("NguoiKy");
            this.Property(t => t.MaHTCap).HasColumnName("MaHTCap");
            this.Property(t => t.NoiHocGPLX).HasColumnName("NoiHocGPLX");
            this.Property(t => t.NamHocGPLX).HasColumnName("NamHocGPLX");
            this.Property(t => t.DuongDanAnh).HasColumnName("DuongDanAnh");
            this.Property(t => t.HoTenDem).HasColumnName("HoTenDem");
            this.Property(t => t.TenNLX).HasColumnName("TenNLX");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.NgaySinh).HasColumnName("NgaySinh");
            this.Property(t => t.MaQuocTich).HasColumnName("MaQuocTich");
            this.Property(t => t.NoiCT).HasColumnName("NoiCT");
            this.Property(t => t.NoiCT_MaDVHC).HasColumnName("NoiCT_MaDVHC");
            this.Property(t => t.NoiCT_MaDVQL).HasColumnName("NoiCT_MaDVQL");
            this.Property(t => t.SoCMT).HasColumnName("SoCMT");
            this.Property(t => t.SoSeri).HasColumnName("SoSeri");
            this.Property(t => t.NoiIn).HasColumnName("NoiIn");
            this.Property(t => t.NgayIn).HasColumnName("NgayIn");
            this.Property(t => t.NgayTra).HasColumnName("NgayTra");
            this.Property(t => t.NguoiTra).HasColumnName("NguoiTra");
            this.Property(t => t.NoiTra).HasColumnName("NoiTra");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.GioiTinh).HasColumnName("GioiTinh");
            this.Property(t => t.NgayTT_A1).HasColumnName("NgayTT_A1");
            this.Property(t => t.NgayTT_A2).HasColumnName("NgayTT_A2");
            this.Property(t => t.NgayTT_A3).HasColumnName("NgayTT_A3");
            this.Property(t => t.NgayTT_A4).HasColumnName("NgayTT_A4");
            this.Property(t => t.NgayTT_B1).HasColumnName("NgayTT_B1");
            this.Property(t => t.NgayTT_B2).HasColumnName("NgayTT_B2");
            this.Property(t => t.NgayTT_C).HasColumnName("NgayTT_C");
            this.Property(t => t.NgayTT_D).HasColumnName("NgayTT_D");
            this.Property(t => t.NgayTT_E).HasColumnName("NgayTT_E");
            this.Property(t => t.NgayTT_F).HasColumnName("NgayTT_F");
            this.Property(t => t.NgayTT_FB2).HasColumnName("NgayTT_FB2");
            this.Property(t => t.NgayTT_FC).HasColumnName("NgayTT_FC");
            this.Property(t => t.NgayTT_FD).HasColumnName("NgayTT_FD");
            this.Property(t => t.NgayTT_FE).HasColumnName("NgayTT_FE");
            this.Property(t => t.Hanoi).HasColumnName("Hanoi");
            this.Property(t => t.HanoiViettat).HasColumnName("HanoiViettat");

            // Relationships
            this.HasRequired(t => t.DM_DonViGTVT)
                .WithMany(t => t.NguoiLX_GPLX)
                .HasForeignKey(d => d.NoiCapGPLX);
            this.HasRequired(t => t.DM_DonViGTVT1)
                .WithMany(t => t.NguoiLX_GPLX1)
                .HasForeignKey(d => d.CoQuanQLGPLX);
            this.HasOptional(t => t.DM_DonViGTVT2)
                .WithMany(t => t.NguoiLX_GPLX2)
                .HasForeignKey(d => d.NoiHocGPLX);
            this.HasOptional(t => t.DM_DVHC)
                .WithMany(t => t.NguoiLX_GPLX)
                .HasForeignKey(d => new { d.NoiCT_MaDVHC, d.NoiCT_MaDVQL });
            this.HasRequired(t => t.DM_HangGPLX)
                .WithMany(t => t.NguoiLX_GPLX)
                .HasForeignKey(d => d.HangGPLX);
            this.HasRequired(t => t.DM_HTCapGPLX)
                .WithMany(t => t.NguoiLX_GPLX)
                .HasForeignKey(d => d.MaHTCap);
            this.HasRequired(t => t.DM_QuocTich)
                .WithMany(t => t.NguoiLX_GPLX)
                .HasForeignKey(d => d.MaQuocTich);
            this.HasRequired(t => t.NguoiLX_GPLX2)
                .WithOptional(t => t.NguoiLX_GPLX1);

        }
    }
}
