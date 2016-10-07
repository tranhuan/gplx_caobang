using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Configuration;
using System.Windows.Forms;
using VT.VPDK.DBMapping.Models;
using System.Reflection;
using VT.GPLX.VPDK.Mapping;
using System.Globalization;

namespace VT.GPLX.VPDK.Utils
{
    public class CommonReadXml
    {
        public static NguoiLX CreateNguoiLXfromXmlNode(XmlNode xmlNode)
        {
            NguoiLX nguoiLXGPLX = new NguoiLX();
            nguoiLXGPLX.MaDK = xmlNode["MADK"].InnerText.Trim().ToString();
            nguoiLXGPLX.DonViNhanHSo = xmlNode["DV_NHAN_HS"].InnerText.Trim().ToString();
            nguoiLXGPLX.HoDemNLX = xmlNode["HO_DEM_NLX"].InnerText.Trim().ToString();
            nguoiLXGPLX.TenNLX = xmlNode["TEN_NLX"].InnerText.Trim().ToString();
            nguoiLXGPLX.HoVaTen = xmlNode["HO_VA_TEN"].InnerText.Trim().ToString();
            nguoiLXGPLX.MaQuocTich = xmlNode["MA_QUOC_TICH"].InnerText.Trim().ToString();
            nguoiLXGPLX.NgaySinh = xmlNode["NGAY_SINH"].InnerText.Trim().ToString();
            nguoiLXGPLX.NoiTT = xmlNode["NOI_TT"].InnerText.Trim().ToString();
            nguoiLXGPLX.NoiTT_MaDVHC = xmlNode["NOI_TT_MA_DVHC"].InnerText.Trim().ToString();
            nguoiLXGPLX.NoiTT_MaDVQL = xmlNode["NOI_TT_MA_DVQL"].InnerText.Trim().ToString();
            nguoiLXGPLX.NoiCT = xmlNode["NOI_CT"].InnerText.Trim().ToString();
            nguoiLXGPLX.NoiCT_MaDVHC = xmlNode["NOI_CT_MA_DVHC"].InnerText.Trim().ToString();
            nguoiLXGPLX.NoiCT_MaDVQL = xmlNode["NOI_CT_MA_DVQL"].InnerText.Trim().ToString();
            nguoiLXGPLX.SoCMT = xmlNode["SO_CMT"].InnerText.Trim().ToString();
            nguoiLXGPLX.NgayCapCMT = checkStringToDateTimeOrNull(xmlNode["NGAY_CAP_CMT"].InnerText.Trim().ToString());
            nguoiLXGPLX.NoiCapCMT = xmlNode["NOI_CAP_CMT"].InnerText.Trim().ToString();
            nguoiLXGPLX.GhiChu = xmlNode["GHI_CHU"].InnerText.Trim().ToString();
            nguoiLXGPLX.TrangThai = checkStringToBoolean(xmlNode["TRANG_THAI"].InnerText.Trim().ToString());
            nguoiLXGPLX.NguoiTao = xmlNode["NGUOI_TAO"].InnerText.Trim().ToString();
            nguoiLXGPLX.NguoiSua = xmlNode["NGUOI_SUA"].InnerText.Trim().ToString();
            nguoiLXGPLX.NgayTao = checkStringToDateTimeNotNull(xmlNode["NGAY_TAO"].InnerText.Trim().ToString());
            nguoiLXGPLX.NgaySua = checkStringToDateTimeNotNull(xmlNode["NGAY_SUA"].InnerText.Trim().ToString());
            nguoiLXGPLX.GioiTinh = xmlNode["GIOI_TINH"].InnerText.Trim().ToString();
            nguoiLXGPLX.HoVaTenIn = xmlNode["HO_VA_TEN_IN"].InnerText.Trim().ToString();
            nguoiLXGPLX.SO_CMND_CU = xmlNode["SO_CMND_CU"].InnerText.Trim().ToString();
            return nguoiLXGPLX;
        }

        public static NguoiLX_HoSo CreateNguoiLXHoSofromXmlNode(XmlNode xmlNode)
        {
            NguoiLX_HoSo nguoiLXHoSo = new NguoiLX_HoSo();
            nguoiLXHoSo.BC1_ThamNien = checkStringToBoolean(xmlNode["BC1_THAMNIEN"].InnerText.Trim().ToString());
            nguoiLXHoSo.BC1_TuoiTS = checkStringToBoolean(xmlNode["BC1_TUOITS"].InnerText.Trim().ToString());
            nguoiLXHoSo.ChatLuongAnh = int.Parse(xmlNode["CHATLUONGANH"].InnerText.Trim().ToString());
            nguoiLXHoSo.ChuKy = xmlNode["CHUKY"].InnerText.Trim().ToString();
            nguoiLXHoSo.CoQuanQuanLyGplx = xmlNode["COQUANQUANLYGPLX"].InnerText.Trim().ToString();
            nguoiLXHoSo.DiaChiTrenGplx_ChiTiet = xmlNode["DIACHITRENGPLX_CHITIET"].InnerText.Trim().ToString();
            nguoiLXHoSo.DiaChiTrenGplx = xmlNode["DIACHITRENGPLX"].InnerText.Trim().ToString();
            nguoiLXHoSo.DonViCapGPLXDaCo = xmlNode["DONVICAPGPLXDACO"].InnerText.Trim().ToString();
            nguoiLXHoSo.DonViHocLX = xmlNode["DONVIHOCLX"].InnerText.Trim().ToString();
            nguoiLXHoSo.DuongDanAnh = xmlNode["DUONGDANANH"].InnerText.Trim().ToString();
            nguoiLXHoSo.GhiChu = xmlNode["GHICHU"].InnerText.Trim().ToString();
            nguoiLXHoSo.GhiChuKQDSTW = xmlNode["GHICHUKQDSTW"].InnerText.Trim().ToString();
            nguoiLXHoSo.GiayCNSK =checkStringToBoolean( xmlNode["GIAYCNSK"].InnerText.Trim().ToString());
            nguoiLXHoSo.HangDaoTao = xmlNode["HANGDAOTAO"].InnerText.Trim().ToString();
            nguoiLXHoSo.HangGPLX = xmlNode["HANGGPLX"].InnerText.Trim().ToString();
            nguoiLXHoSo.HangGPLXDaCo = xmlNode["HANGGPLXDACO"].InnerText.Trim().ToString();
            nguoiLXHoSo.IDs = int.Parse(xmlNode["IDS"].InnerText.Trim().ToString());
            nguoiLXHoSo.IN_GPLX = int.Parse(xmlNode["IN_GPLX"].InnerText.Trim().ToString());
            nguoiLXHoSo.KetQua_Duong = int.Parse(xmlNode["KETQUA_DUONG"].InnerText.Trim().ToString());
            nguoiLXHoSo.KetQua_Hinh = int.Parse(xmlNode["KETQUA_HINH"].InnerText.Trim().ToString());
            nguoiLXHoSo.KetQua_LyThuyet = int.Parse(xmlNode["KETQUA_LYTHUYET"].InnerText.Trim().ToString());
            nguoiLXHoSo.KetQuaBC2 = checkStringToBoolean(xmlNode["KETQUABC2"].InnerText.Trim().ToString());
            nguoiLXHoSo.KetQuaDoiSanhTW = checkStringToBoolean(xmlNode["KETQUADOISANHTW"].InnerText.Trim().ToString());
            nguoiLXHoSo.KetQuaSH = xmlNode["KETQUASH"].InnerText.Trim().ToString();
            nguoiLXHoSo.KQ_BC1_GhiChu = xmlNode["KQ_BC1_GHICHU"].InnerText.Trim().ToString();
            nguoiLXHoSo.KQ_BC1 = checkStringToBoolean(xmlNode["KQ_BC1"].InnerText.Trim().ToString());
            nguoiLXHoSo.LanSH = int.Parse(xmlNode["LANSH"].InnerText.Trim().ToString());
            nguoiLXHoSo.LyDoCapDoi = xmlNode["LYDOCAPDOI"].InnerText.Trim().ToString();
            nguoiLXHoSo.MaBC1 = xmlNode["MABC1"].InnerText.Trim().ToString();
            nguoiLXHoSo.MaBC2 = xmlNode["MABC2"].InnerText.Trim().ToString();
            nguoiLXHoSo.MaCSDT = xmlNode["MACSDT"].InnerText.Trim().ToString();
            nguoiLXHoSo.MaDVNhanHSo = xmlNode["MADVNHANHSO"].InnerText.Trim().ToString();
            nguoiLXHoSo.MaHTCap = xmlNode["MAHTCAP"].InnerText.Trim().ToString();
            nguoiLXHoSo.MaIn = xmlNode["MAIN"].InnerText.Trim().ToString();
            nguoiLXHoSo.MaKhoaHoc = xmlNode["MAKHOAHOC"].InnerText.Trim().ToString();
            nguoiLXHoSo.MaKySH = xmlNode["MAKYSH"].InnerText.Trim().ToString();
            nguoiLXHoSo.MaLoaiHs = int.Parse(xmlNode["MALOAIHS"].InnerText.Trim().ToString());
            nguoiLXHoSo.MaLyDoTCBC2 = int.Parse(xmlNode["MALYDOTCBC2"].InnerText.Trim().ToString());
            nguoiLXHoSo.MaSoGTVT = xmlNode["MASOGTVT"].InnerText.Trim().ToString();
            nguoiLXHoSo.MaTrichNgang = xmlNode["MATRICHNGANG"].InnerText.Trim().ToString();
            nguoiLXHoSo.MucDichCapDoi = xmlNode["MUCDICHCAPDOI"].InnerText.Trim().ToString();
            nguoiLXHoSo.NamcapLandau = xmlNode["NAMCAPLANDAU"].InnerText.Trim().ToString();
            nguoiLXHoSo.NamHocLX = int.Parse(xmlNode["NAMHOCLX"].InnerText.Trim().ToString());
            nguoiLXHoSo.NgayCapGPLXDaCo = xmlNode["NGAYCAPGPLXDACO"].InnerText.Trim().ToString();
            nguoiLXHoSo.NgayHenTra = checkStringToDateTimeOrNull(xmlNode["NGAYHENTRA"].InnerText.Trim().ToString());
            nguoiLXHoSo.NgayHHGPLXDaCo = xmlNode["NGAYHHGPLXDACO"].InnerText.Trim().ToString();
            nguoiLXHoSo.NgayKTBC1 = checkStringToDateTimeOrNull(xmlNode["NGAYKTBC1"].InnerText.Trim().ToString());
            nguoiLXHoSo.NgayKTBC2 = checkStringToDateTimeOrNull(xmlNode["NGAYKTBC2"].InnerText.Trim().ToString());
            nguoiLXHoSo.NgayNhanHSo = checkStringToDateTimeNotNull(xmlNode["NGAYNHANHSO"].InnerText.Trim().ToString());
            nguoiLXHoSo.NgayQDSH = checkStringToDateTimeOrNull(xmlNode["NGAYQDSH"].InnerText.Trim().ToString());
            nguoiLXHoSo.NgayQDTT = checkStringToDateTimeOrNull(xmlNode["NGAYQDTT"].InnerText.Trim().ToString());
            nguoiLXHoSo.NgaySua = checkStringToDateTimeNotNull(xmlNode["NGAYSUA"].InnerText.Trim().ToString());
            nguoiLXHoSo.NgayTao = checkStringToDateTimeNotNull(xmlNode["NGAYTAO"].InnerText.Trim().ToString());
            nguoiLXHoSo.NgayThuNhanAnh =  checkStringToDateTimeOrNull( xmlNode["NGAYTHUNHANANH"].InnerText.Trim().ToString());
            nguoiLXHoSo.NgayTTGPLXDaCo = xmlNode["NGAYTTGPLXDACO"].InnerText.Trim().ToString();
            nguoiLXHoSo.NguoiKTBC1 = xmlNode["NGUOIKTBC1"].InnerText.Trim().ToString();
            nguoiLXHoSo.NguoiKTBC2 = xmlNode["NGUOIKTBC2"].InnerText.Trim().ToString();
            nguoiLXHoSo.NguoiKy = xmlNode["NGUOIKY"].InnerText.Trim().ToString();
            nguoiLXHoSo.NguoiNhanHSo = xmlNode["NGUOINHANHSO"].InnerText.Trim().ToString();
            nguoiLXHoSo.NguoiSua = xmlNode["NGUOISUA"].InnerText.Trim().ToString();
            nguoiLXHoSo.NguoiTao = xmlNode["NGUOITAO"].InnerText.Trim().ToString();
            nguoiLXHoSo.NguoiThuNhanAnh = xmlNode["NGUOITHUNHANANH"].InnerText.Trim().ToString();
            nguoiLXHoSo.NhanXet_Duong = xmlNode["NHANXET_DUONG"].InnerText.Trim().ToString();
            nguoiLXHoSo.NhanXet_Hinh = xmlNode["NHANXET_HINH"].InnerText.Trim().ToString();
            nguoiLXHoSo.NhanXet_LyThuyet = xmlNode["NHANXET_LYTHUYET"].InnerText.Trim().ToString();
            nguoiLXHoSo.NoiCapGPLXDaCo = xmlNode["NOICAPGPLXDACO"].InnerText.Trim().ToString();
            nguoiLXHoSo.NoiDungSH = int.Parse(xmlNode["NOIDUNGSH"].InnerText.Trim().ToString());
            nguoiLXHoSo.SoBD = xmlNode["SOBD"].InnerText.Trim().ToString();
            nguoiLXHoSo.SoCCN = xmlNode["SOCCN"].InnerText.Trim().ToString();
            nguoiLXHoSo.SoGiayCNTN = xmlNode["SOGIAYCNTN"].InnerText.Trim().ToString();
            nguoiLXHoSo.SoGPLXDaCo = xmlNode["SOGPLXDACO"].InnerText.Trim().ToString();
            nguoiLXHoSo.SoGPLXTmp = xmlNode["SOGPLXTMP"].InnerText.Trim().ToString();
            nguoiLXHoSo.SoHoSo = xmlNode["SOHOSO"].InnerText.Trim().ToString();
            nguoiLXHoSo.SoKmLXAnToan = int.Parse(xmlNode["SOKMLXANTOAN"].InnerText.Trim().ToString());
            nguoiLXHoSo.SoNamLX = int.Parse(xmlNode["SONAMLX"].InnerText.Trim().ToString());
            nguoiLXHoSo.SoQDSH = xmlNode["SOQDSH"].InnerText.Trim().ToString();
            nguoiLXHoSo.SoQDTT = xmlNode["SOQDTT"].InnerText.Trim().ToString();
            nguoiLXHoSo.SOSERI_GPLX_DACO = xmlNode["SOSERI_GPLX_DACO"].InnerText.Trim().ToString();
            nguoiLXHoSo.TrangThai = checkStringToBoolean(xmlNode["TRANGTHAI"].InnerText.Trim().ToString());
            nguoiLXHoSo.Transfer_flag = int.Parse(xmlNode["TRANSFER_FLAG"].InnerText.Trim().ToString());
            nguoiLXHoSo.TT_XuLy_Old = xmlNode["TT_XULY_OLD"].InnerText.Trim().ToString();
            nguoiLXHoSo.TT_XuLy = xmlNode["TT_XULY"].InnerText.Trim().ToString();
            nguoiLXHoSo.MaDK = xmlNode["MADK"].InnerText.Trim().ToString();

            return nguoiLXHoSo;
        }
        public static NguoiLXHS_GiayTo CreateGiayTofromXmlNode(XmlNode xmlNode)
        {
            NguoiLXHS_GiayTo giayTo = new NguoiLXHS_GiayTo();
            giayTo.MaDK = xmlNode["MADK"].InnerText.Trim().ToString();
            giayTo.MaGT = int.Parse(xmlNode["MAGT"].InnerText.Trim().ToString());
            giayTo.SoHoSo = xmlNode["SOHOSO"].InnerText.Trim().ToString();
            giayTo.TenGT = xmlNode["TEN_NLX"].InnerText.Trim().ToString();
            giayTo.TrangThai = checkStringToBoolean(xmlNode["TRANGTHAI"].InnerText.Trim().ToString());
           
            return giayTo;
        }
        public static bool checkStringToBoolean(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return false;
            }
            else if (value.ToLower() == "false")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static DateTime? checkStringToDateTimeOrNull(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return null;
            }
            else
            {
                return DateTime.Parse(value);
            }
        }
        public static DateTime checkStringToDateTimeNotNull(string value)
        {
            return DateTime.Parse(value);
        }
    }
}
