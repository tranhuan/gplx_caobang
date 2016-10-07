using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class NguoiLX_HoSoMap : EntityTypeConfiguration<NguoiLX_HoSo>
    {
        public NguoiLX_HoSoMap()
        {
            // Primary Key
            this.HasKey(t => t.MaDK);

            // Properties
            this.Property(t => t.MaDK)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.SoHoSo)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.MaCSDT)
                .HasMaxLength(6);

            this.Property(t => t.MaSoGTVT)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.MaDVNhanHSo)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.NguoiNhanHSo)
                .HasMaxLength(50);

            this.Property(t => t.TT_XuLy)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.DuongDanAnh)
                .HasMaxLength(255);

            this.Property(t => t.NguoiThuNhanAnh)
                .HasMaxLength(50);

            this.Property(t => t.SoGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.HangGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.DonViCapGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.NoiCapGPLXDaCo)
                .HasMaxLength(500);

            this.Property(t => t.NgayCapGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.NgayHHGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.NgayTTGPLXDaCo)
                .HasMaxLength(100);

            this.Property(t => t.DonViHocLX)
                .HasMaxLength(6);

            this.Property(t => t.HangGPLX)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.LyDoCapDoi)
                .HasMaxLength(50);

            this.Property(t => t.MucDichCapDoi)
                .HasMaxLength(50);

            this.Property(t => t.MaKhoaHoc)
                .HasMaxLength(13);

            this.Property(t => t.HangDaoTao)
                .HasMaxLength(20);

            this.Property(t => t.SoGiayCNTN)
                .HasMaxLength(20);

            this.Property(t => t.SoCCN)
                .HasMaxLength(20);

            this.Property(t => t.MaBC1)
                .HasMaxLength(18);

            this.Property(t => t.MaBC2)
                .HasMaxLength(13);

            this.Property(t => t.MaKySH)
                .HasMaxLength(12);

            this.Property(t => t.SoBD)
                .HasMaxLength(3);

            this.Property(t => t.SoQDSH)
                .HasMaxLength(20);

            this.Property(t => t.NhanXet_LyThuyet)
                .HasMaxLength(50);

            this.Property(t => t.NhanXet_Hinh)
                .HasMaxLength(50);

            this.Property(t => t.NhanXet_Duong)
                .HasMaxLength(50);

            this.Property(t => t.KetQuaSH)
                .HasMaxLength(2);

            this.Property(t => t.SoQDTT)
                .HasMaxLength(20);

            this.Property(t => t.NguoiKy)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(255);

            this.Property(t => t.NguoiTao)
                .HasMaxLength(30);

            this.Property(t => t.NguoiSua)
                .HasMaxLength(30);

            this.Property(t => t.SoGPLXTmp)
                .HasMaxLength(20);

            this.Property(t => t.NguoiKTBC1)
                .HasMaxLength(50);

            this.Property(t => t.NguoiKTBC2)
                .HasMaxLength(50);

            this.Property(t => t.MaIn)
                .HasMaxLength(255);

            this.Property(t => t.GhiChuKQDSTW)
                .HasMaxLength(255);

            this.Property(t => t.ChuKy)
                .HasMaxLength(255);

            this.Property(t => t.MaHTCap)
                .HasMaxLength(5);

            this.Property(t => t.IDs)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TT_XuLy_Old)
                .HasMaxLength(2);

            this.Property(t => t.KQ_BC1_GhiChu)
                .HasMaxLength(50);

            this.Property(t => t.NamcapLandau)
                .HasMaxLength(4);

            this.Property(t => t.MaTrichNgang)
                .HasMaxLength(30);

            this.Property(t => t.DiaChiTrenGplx)
                .HasMaxLength(150);

            this.Property(t => t.CoQuanQuanLyGplx)
                .HasMaxLength(150);

            this.Property(t => t.DiaChiTrenGplx_ChiTiet)
                .HasMaxLength(150);

            this.Property(t => t.SOSERI_GPLX_DACO)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NguoiLX_HoSo");
            this.Property(t => t.MaDK).HasColumnName("MaDK");
            this.Property(t => t.SoHoSo).HasColumnName("SoHoSo");
            this.Property(t => t.MaCSDT).HasColumnName("MaCSDT");
            this.Property(t => t.MaSoGTVT).HasColumnName("MaSoGTVT");
            this.Property(t => t.MaDVNhanHSo).HasColumnName("MaDVNhanHSo");
            this.Property(t => t.NgayNhanHSo).HasColumnName("NgayNhanHSo");
            this.Property(t => t.NguoiNhanHSo).HasColumnName("NguoiNhanHSo");
            this.Property(t => t.NgayHenTra).HasColumnName("NgayHenTra");
            this.Property(t => t.MaLoaiHs).HasColumnName("MaLoaiHs");
            this.Property(t => t.TT_XuLy).HasColumnName("TT_XuLy");
            this.Property(t => t.DuongDanAnh).HasColumnName("DuongDanAnh");
            this.Property(t => t.ChatLuongAnh).HasColumnName("ChatLuongAnh");
            this.Property(t => t.NgayThuNhanAnh).HasColumnName("NgayThuNhanAnh");
            this.Property(t => t.NguoiThuNhanAnh).HasColumnName("NguoiThuNhanAnh");
            this.Property(t => t.SoGPLXDaCo).HasColumnName("SoGPLXDaCo");
            this.Property(t => t.HangGPLXDaCo).HasColumnName("HangGPLXDaCo");
            this.Property(t => t.DonViCapGPLXDaCo).HasColumnName("DonViCapGPLXDaCo");
            this.Property(t => t.NoiCapGPLXDaCo).HasColumnName("NoiCapGPLXDaCo");
            this.Property(t => t.NgayCapGPLXDaCo).HasColumnName("NgayCapGPLXDaCo");
            this.Property(t => t.NgayHHGPLXDaCo).HasColumnName("NgayHHGPLXDaCo");
            this.Property(t => t.NgayTTGPLXDaCo).HasColumnName("NgayTTGPLXDaCo");
            this.Property(t => t.DonViHocLX).HasColumnName("DonViHocLX");
            this.Property(t => t.NamHocLX).HasColumnName("NamHocLX");
            this.Property(t => t.HangGPLX).HasColumnName("HangGPLX");
            this.Property(t => t.SoNamLX).HasColumnName("SoNamLX");
            this.Property(t => t.SoKmLXAnToan).HasColumnName("SoKmLXAnToan");
            this.Property(t => t.GiayCNSK).HasColumnName("GiayCNSK");
            this.Property(t => t.LyDoCapDoi).HasColumnName("LyDoCapDoi");
            this.Property(t => t.MucDichCapDoi).HasColumnName("MucDichCapDoi");
            this.Property(t => t.NoiDungSH).HasColumnName("NoiDungSH");
            this.Property(t => t.MaKhoaHoc).HasColumnName("MaKhoaHoc");
            this.Property(t => t.HangDaoTao).HasColumnName("HangDaoTao");
            this.Property(t => t.SoGiayCNTN).HasColumnName("SoGiayCNTN");
            this.Property(t => t.SoCCN).HasColumnName("SoCCN");
            this.Property(t => t.MaBC1).HasColumnName("MaBC1");
            this.Property(t => t.BC1_TuoiTS).HasColumnName("BC1_TuoiTS");
            this.Property(t => t.BC1_ThamNien).HasColumnName("BC1_ThamNien");
            this.Property(t => t.MaBC2).HasColumnName("MaBC2");
            this.Property(t => t.KetQuaBC2).HasColumnName("KetQuaBC2");
            this.Property(t => t.MaLyDoTCBC2).HasColumnName("MaLyDoTCBC2");
            this.Property(t => t.MaKySH).HasColumnName("MaKySH");
            this.Property(t => t.SoBD).HasColumnName("SoBD");
            this.Property(t => t.LanSH).HasColumnName("LanSH");
            this.Property(t => t.SoQDSH).HasColumnName("SoQDSH");
            this.Property(t => t.NgayQDSH).HasColumnName("NgayQDSH");
            this.Property(t => t.KetQua_LyThuyet).HasColumnName("KetQua_LyThuyet");
            this.Property(t => t.NhanXet_LyThuyet).HasColumnName("NhanXet_LyThuyet");
            this.Property(t => t.KetQua_Hinh).HasColumnName("KetQua_Hinh");
            this.Property(t => t.NhanXet_Hinh).HasColumnName("NhanXet_Hinh");
            this.Property(t => t.KetQua_Duong).HasColumnName("KetQua_Duong");
            this.Property(t => t.NhanXet_Duong).HasColumnName("NhanXet_Duong");
            this.Property(t => t.KetQuaSH).HasColumnName("KetQuaSH");
            this.Property(t => t.SoQDTT).HasColumnName("SoQDTT");
            this.Property(t => t.NgayQDTT).HasColumnName("NgayQDTT");
            this.Property(t => t.NguoiKy).HasColumnName("NguoiKy");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NguoiSua).HasColumnName("NguoiSua");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.NgaySua).HasColumnName("NgaySua");
            this.Property(t => t.SoGPLXTmp).HasColumnName("SoGPLXTmp");
            this.Property(t => t.NgayKTBC1).HasColumnName("NgayKTBC1");
            this.Property(t => t.NguoiKTBC1).HasColumnName("NguoiKTBC1");
            this.Property(t => t.NgayKTBC2).HasColumnName("NgayKTBC2");
            this.Property(t => t.NguoiKTBC2).HasColumnName("NguoiKTBC2");
            this.Property(t => t.MaIn).HasColumnName("MaIn");
            this.Property(t => t.KetQuaDoiSanhTW).HasColumnName("KetQuaDoiSanhTW");
            this.Property(t => t.GhiChuKQDSTW).HasColumnName("GhiChuKQDSTW");
            this.Property(t => t.ChuKy).HasColumnName("ChuKy");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.MaHTCap).HasColumnName("MaHTCap");
            this.Property(t => t.IDs).HasColumnName("IDs");
            this.Property(t => t.TT_XuLy_Old).HasColumnName("TT_XuLy_Old");
            this.Property(t => t.KQ_BC1).HasColumnName("KQ_BC1");
            this.Property(t => t.KQ_BC1_GhiChu).HasColumnName("KQ_BC1_GhiChu");
            this.Property(t => t.Transfer_flag).HasColumnName("Transfer_flag");
            this.Property(t => t.NamcapLandau).HasColumnName("NamcapLandau");
            this.Property(t => t.MaTrichNgang).HasColumnName("MaTrichNgang");
            this.Property(t => t.DiaChiTrenGplx).HasColumnName("DiaChiTrenGplx");
            this.Property(t => t.CoQuanQuanLyGplx).HasColumnName("CoQuanQuanLyGplx");
            this.Property(t => t.DiaChiTrenGplx_ChiTiet).HasColumnName("DiaChiTrenGplx_ChiTiet");
            this.Property(t => t.SOSERI_GPLX_DACO).HasColumnName("SOSERI_GPLX_DACO");
            this.Property(t => t.IN_GPLX).HasColumnName("IN_GPLX");

            // Relationships
            this.HasOptional(t => t.DM_DonViGTVT)
                .WithMany(t => t.NguoiLX_HoSo)
                .HasForeignKey(d => d.MaCSDT);
            this.HasRequired(t => t.DM_DonViGTVT1)
                .WithMany(t => t.NguoiLX_HoSo1)
                .HasForeignKey(d => d.MaSoGTVT);
            this.HasRequired(t => t.DM_DonViGTVT2)
                .WithMany(t => t.NguoiLX_HoSo2)
                .HasForeignKey(d => d.MaDVNhanHSo);
            this.HasOptional(t => t.DM_HangDT)
                .WithMany(t => t.NguoiLX_HoSo)
                .HasForeignKey(d => d.HangDaoTao);
            this.HasRequired(t => t.DM_HangGPLX)
                .WithMany(t => t.NguoiLX_HoSo)
                .HasForeignKey(d => d.HangGPLX);
            this.HasOptional(t => t.DM_HTCapGPLX)
                .WithMany(t => t.NguoiLX_HoSo)
                .HasForeignKey(d => d.MaHTCap);
            this.HasRequired(t => t.DM_LoaiHSo)
                .WithMany(t => t.NguoiLX_HoSo)
                .HasForeignKey(d => d.MaLoaiHs);
            this.HasOptional(t => t.DM_NoiDungSH)
                .WithMany(t => t.NguoiLX_HoSo)
                .HasForeignKey(d => d.NoiDungSH);
            this.HasRequired(t => t.DM_TrangThai)
                .WithMany(t => t.NguoiLX_HoSo)
                .HasForeignKey(d => d.TT_XuLy);
            this.HasOptional(t => t.KhoaHoc)
                .WithMany(t => t.NguoiLX_HoSo)
                .HasForeignKey(d => d.MaKhoaHoc);
            this.HasRequired(t => t.NguoiLX)
                .WithOptional(t => t.NguoiLX_HoSo);

        }
    }
}
