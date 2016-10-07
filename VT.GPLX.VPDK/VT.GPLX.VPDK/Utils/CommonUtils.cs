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
    public class CommonUtils
    {
        //public static string folderAnhToanThan = "AnhTT";
        //public static string folderAnhToanThan = "AnhBangGPLX";

        public static DateTime formatDDMMYYYY(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day);
        }
        public static DateTime ConvertToDateYYYYMMDD(string yyyymmdd)
        {
            return DateTime.ParseExact(yyyymmdd,
                                        "yyyyMMdd",
                                        CultureInfo.InvariantCulture,
                                        DateTimeStyles.None);
        }

        public static bool CheckForm(Form frm)
        {
            bool check = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form itemFc in fc)
            {
                if (frm.Equals(itemFc))
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        public static string GetFolderFile(string DuongDanAnhChanDung)
        {
            if (string.IsNullOrEmpty(DuongDanAnhChanDung))
            {
                return null;
            }
            string[] arrDuongDanAnh = DuongDanAnhChanDung.Split('\\');
            string folder = arrDuongDanAnh[arrDuongDanAnh.Length - 2];
            return folder;
        }
        public static string GetFileNameFile(string DuongDanAnhChanDung)
        {
            if (string.IsNullOrEmpty(DuongDanAnhChanDung))
            {
                return null;
            }
            string[] arrDuongDanAnh = DuongDanAnhChanDung.Split('\\');
            string fileName = arrDuongDanAnh[arrDuongDanAnh.Length - 1];
            return fileName;
        }
        public static string GetTenAnhChanDung(string DuongDanAnhChanDung)
        {
            if (string.IsNullOrEmpty(DuongDanAnhChanDung))
            {
                return null;
            }
            string[] arrDuongDanAnh = DuongDanAnhChanDung.Split('\\');
            string folder = arrDuongDanAnh[arrDuongDanAnh.Length - 2];
            string fileName = arrDuongDanAnh[arrDuongDanAnh.Length - 1];
            return Path.Combine(folder,fileName);
        }
        
        public static NguoiLX MappingNguoiLX(NguoiLX nguoilx)
        {
            NguoiLX newNguoiLX = new NguoiLX();
            Type newTypeNguoiLX = typeof(NguoiLX);
            Type typeNguoilx = nguoilx.GetType();
            // Get the public properties.
            PropertyInfo[] arrTypeNguoilx = typeNguoilx.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo[] arrNewTypeNguoiLX = newTypeNguoiLX.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo item in arrTypeNguoilx)
            {
                //Console.WriteLine(item.GetValue(nguoilx));
                foreach (PropertyInfo newItem in arrNewTypeNguoiLX)
                {
                    if (item.Name == newItem.Name)
                    {
                        newItem.SetValue(newNguoiLX, item.GetValue(nguoilx));
                        //Console.WriteLine(item.Name + "==" + newItem.GetValue(newNguoiLX) + "=========" + item.GetValue(nguoilx));
                        break;
                    }
                }
            }
            NotSetEntites_NguoiLX(newNguoiLX);

            return newNguoiLX;
        }

        public static NguoiLX_HoSo MappingNguoiLXHoSo(NguoiLX_HoSo nguoilx)
        {

            NguoiLX_HoSo newNguoiLXHoSo = new NguoiLX_HoSo();
            Type newTypeNguoiLX = typeof(NguoiLX_HoSo);
            Type typeNguoilx = nguoilx.GetType();
            // Get the public properties.
            PropertyInfo[] arrTypeNguoilx = typeNguoilx.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            PropertyInfo[] arrNewTypeNguoiLX = newTypeNguoiLX.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo item in arrTypeNguoilx)
            {
                //Console.WriteLine(item.GetValue(nguoilx));
                foreach (PropertyInfo newItem in arrNewTypeNguoiLX)
                {
                    if (item.Name == newItem.Name)
                    {
                        newItem.SetValue(newNguoiLXHoSo, item.GetValue(nguoilx));
                        //Console.WriteLine(item.Name + "==" + newItem.GetValue(newNguoiLXHoSo) + "=========" + item.GetValue(nguoilx));
                        break;
                    }
                }
            }
            NotSetEntites_NguoiLX_HoSo(newNguoiLXHoSo);
            return newNguoiLXHoSo;
        }

        public static NguoiLX_Hoso_DichVu MappingNguoiLX_Hoso_DichVu(NguoiLX_Hoso_DichVu nguoilx)
        {
            
            NguoiLX_Hoso_DichVu newNguoiLX = new NguoiLX_Hoso_DichVu();
            Type newTypeNguoiLX = typeof(NguoiLX_Hoso_DichVu);
            Type typeNguoilx = nguoilx.GetType();
            // Get the public properties.
            PropertyInfo[] arrTypeNguoilx = typeNguoilx.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo[] arrNewTypeNguoiLX = newTypeNguoiLX.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo item in arrTypeNguoilx)
            {
                //Console.WriteLine(item.GetValue(nguoilx));
                foreach (PropertyInfo newItem in arrNewTypeNguoiLX)
                {
                    if (item.Name == newItem.Name)
                    {
                        newItem.SetValue(newNguoiLX, item.GetValue(nguoilx));
                        //Console.WriteLine(item.Name + "==" + newItem.GetValue(newNguoiLX) + "=========" + item.GetValue(nguoilx));
                        break;
                    }
                }
            }
            NotSetEntites_NguoiLX_HoSo_DichVu(newNguoiLX);
            return newNguoiLX;
        }
        
        public static NguoiLXHS_GiayTo MappingNguoiLXHS_GiayTo(NguoiLXHS_GiayTo nguoilx) 
        {
            NguoiLXHS_GiayTo newNguoiLX = new NguoiLXHS_GiayTo();
            Type newTypeNguoiLX = typeof(NguoiLXHS_GiayTo);
            Type typeNguoilx = nguoilx.GetType();
            // Get the public properties.
            PropertyInfo[] arrTypeNguoilx = typeNguoilx.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo[] arrNewTypeNguoiLX = newTypeNguoiLX.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo item in arrTypeNguoilx)
            {
                //Console.WriteLine(item.GetValue(nguoilx));
                foreach (PropertyInfo newItem in arrNewTypeNguoiLX)
                {
                    if (item.Name == newItem.Name)
                    {
                        newItem.SetValue(newNguoiLX, item.GetValue(nguoilx));
                        //Console.WriteLine(item.Name + "==" + newItem.GetValue(newNguoiLX) + "=========" + item.GetValue(nguoilx));
                        break;
                    }
                }
            }
            NotSetEntites_NguoiLXHS_GiayTo(newNguoiLX);
            return newNguoiLX;
        }

        public static T MappingObject<T>(T obj) where T:class
        {
            T newT = default(T);
            Type newTypeT = typeof(T);
            Type typeT = obj.GetType();
            PropertyInfo[] arrTypeT = typeT.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo[] arrNewTypeT = newTypeT.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo item in arrTypeT)
            {
                foreach (PropertyInfo newItem in arrNewTypeT)
                {
                    if (item.Name == newItem.Name)
                    {
                        newItem.SetValue(newT, item.GetValue(obj));
                        break;
                    }
                }
            }
            return newT;
        }


        public static void NotSetEntites_NguoiLX(NguoiLX lx)
        {
            lx.DM_DonViGTVT = null;
            lx.DM_DVHC = null;
            lx.DM_DVHC1 = null;
            lx.DM_QuocTich = null;
            lx.NguoiLX_HoSo = null; 
        }
        public static void NotSetEntites_NguoiLX_HoSo(NguoiLX_HoSo lx)
        {
            lx.DM_DonViGTVT = null;
            lx.DM_DonViGTVT1 = null;
            lx.DM_DonViGTVT2 = null;
            lx.DM_HangDT = null;
            lx.DM_HangGPLX = null;
            lx.DM_HTCapGPLX = null;
            lx.DM_LoaiHSo = null;
            lx.DM_NoiDungSH = null;
            lx.DM_TrangThai = null;
            lx.KhoaHoc = null;
            lx.NguoiLX = null;
            lx.NguoiLX_Hoso_DichVu = null;
            lx.NguoiLX_Hoso_Quocte = null;
            lx.NguoiLXHS_GiayTo = null;
        }
        public static void NotSetEntites_NguoiLX_HoSo_DichVu(NguoiLX_Hoso_DichVu nguoiLX_HoSo_DichVu)
        {
            nguoiLX_HoSo_DichVu.NguoiLX_HoSo = null;
        }
        public static void NotSetEntites_NguoiLXHS_GiayTo(NguoiLXHS_GiayTo nguoiLXHS_GiayTo)
        {
            nguoiLXHS_GiayTo.DM_GiayTo = null;
            nguoiLXHS_GiayTo.NguoiLX_HoSo = null;
        }
        
        public static string newMaDK(string MaDKcu)
        {
            string[] arrMadk = MaDKcu.Split('-');
            return arrMadk[0] + "-" + arrMadk[1] + "-" + DateTime.Now.ToString("HHmmss");
        }
        public static string newTenAnh(string tenAnh)//991-20151021-105833.jp2
        {
            string[] arrDuongDanAnh = tenAnh.Split('-');
            return arrDuongDanAnh[0] + "-" + arrDuongDanAnh[1] + "-" + DateTime.Now.ToString("HHmmss")+".jp2";
        }
        public static string newDuongDanAnh(string DuongDanAnh)//991-20151021-105833.jp2
        {
            string[] arrDuongDanAnh = DuongDanAnh.Split('\\');
            arrDuongDanAnh[arrDuongDanAnh.Length - 1] = newTenAnh(arrDuongDanAnh[arrDuongDanAnh.Length - 1]);
            return Path.Combine(arrDuongDanAnh);
        }
        public static void CreateFileXml(string fileName, string xmlName, string dataSource,
            string initialCatalog, string uid, string password)
        {
            string gplx_vpdk = "<xml><" + xmlName + " Name = '" + xmlName + "' >" +
                "<DataSource>" + dataSource + "</DataSource>" +
                "<InitialCatalog>" + initialCatalog + " </InitialCatalog>" +
                "<Uid>" + uid + " </Uid>" +
                "<Password>" + password + " </Password>"
                + "</" + xmlName + "></xml>";

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(gplx_vpdk);
            xdoc.Save(fileName);
        }

        public static string CreateOpenHeaderXml(string MaGiaoDich,string MaDonViGui,
            string TenDonViGui,string NgayGui,string NguoiGui,string TongSoBanGhi)
        {

            string gplx_vpdk_header = "<HEADER>"+
                "<MA_GIAO_DICH>" + MaGiaoDich + "</MA_GIAO_DICH>" +
                "<MA_DV_GUI>" + MaDonViGui + " </MA_DV_GUI>" +
                "<TEN_DV_GUI>" + TenDonViGui + " </TEN_DV_GUI>" +
                "<NGAY_GUI>" + NgayGui + " </NGAY_GUI>" +
                "<NGUOI_GUI>" + NguoiGui + " </NGUOI_GUI>" +
                "<TONG_SO_BAN_GHI>" + TongSoBanGhi + " </TONG_SO_BAN_GHI>" +
                "<BODY>";
            return gplx_vpdk_header;
        }

        public static string CreateCloseHeaderXml()
        {
            return "</BODY></HEADER > ";
        }

        public static string CreateNguoiLXToXml(NguoiLX nguoilx)
        {
            string XmlNguoilx = "<NGUOI_LX>" +
                                "<MADK>" + nguoilx.MaDK + "</MADK>" +
                                "<DV_NHAN_HS>" + nguoilx.DonViNhanHSo + "</DV_NHAN_HS>" +
                                "<HO_DEM_NLX>" + nguoilx.HoDemNLX + "</HO_DEM_NLX>" +
                                "<TEN_NLX>" + nguoilx.TenNLX + "</TEN_NLX>" +
                                "<HO_VA_TEN>" + nguoilx.HoVaTen + "</HO_VA_TEN>" +
                                "<MA_QUOC_TICH>" + nguoilx.MaQuocTich + "</MA_QUOC_TICH>" +
                                "<NGAY_SINH>" + nguoilx.NgaySinh + "</NGAY_SINH>" +
                                "<NOI_TT>" + nguoilx.NoiTT + "</NOI_TT>" +
                                "<NOI_TT_MA_DVHC>" + nguoilx.NoiTT_MaDVHC + "</NOI_TT_MA_DVHC>" +
                                "<NOI_TT_MA_DVQL>" + nguoilx.NoiTT_MaDVQL + "</NOI_TT_MA_DVQL>" +
                                "<NOI_CT>" + nguoilx.NoiCT + "</NOI_CT>" +
                                "<NOI_CT_MA_DVHC>" + nguoilx.NoiCT_MaDVHC + "</NOI_CT_MA_DVHC>" +
                                "<NOI_CT_MA_DVQL>" + nguoilx.NoiCT_MaDVQL + "</NOI_CT_MA_DVQL>" +
                                "<SO_CMT>" + nguoilx.SoCMT + "</SO_CMT>" +
                                "<NGAY_CAP_CMT>" + nguoilx.NgayCapCMT + "</NGAY_CAP_CMT>" +
                                "<NOI_CAP_CMT>" + nguoilx.NoiCapCMT + "</NOI_CAP_CMT>" +
                                "<GHI_CHU>" + nguoilx.GhiChu + "</GHI_CHU>" +
                                "<TRANG_THAI>" + nguoilx.TrangThai + "</TRANG_THAI>" +
                                "<NGUOI_TAO>" + nguoilx.NguoiTao + "</NGUOI_TAO>" +
                                "<NGUOI_SUA>" + nguoilx.NguoiSua + "</NGUOI_SUA>" +
                                "<NGAY_TAO>" + nguoilx.NgayTao + "</NGAY_TAO>" +
                                "<NGAY_SUA>" + nguoilx.NgaySua + "</NGAY_SUA>" +
                                "<GIOI_TINH>" + nguoilx.GioiTinh + "</GIOI_TINH>" +
                                "<HO_VA_TEN_IN>" + nguoilx.HoVaTenIn + "</HO_VA_TEN_IN>" +
                                "<SO_CMND_CU>" + nguoilx.SO_CMND_CU + "</SO_CMND_CU>" +
                                "</NGUOI_LX>";
            return XmlNguoilx;
        }

        public static string CreateListNguoiLXToXml(List<NguoiLX> lstNguoiLX)
        {
            string result = "";
            foreach(NguoiLX nguoilx in lstNguoiLX)
            {
                result = result + CreateNguoiLXToXml(nguoilx);
            }
            return result;
        }

        public static string CreateNguoiLXHoSoToXml(NguoiLX_HoSo nguoilx)
        {
            string XmlNguoilxHoSo = "<NGUOILX_HOSO>" +
                                    "<MADK>" + nguoilx.MaDK + "</MADK>" +
                                    "<SOHOSO>" + nguoilx.SoHoSo + "</SOHOSO>" +
                                    "<MACSDT>" + nguoilx.MaCSDT + "</MACSDT>" +
                                    "<MASOGTVT>" + nguoilx.MaSoGTVT + "</MASOGTVT>" +
                                    "<MADVNHANHSO>" + nguoilx.MaDVNhanHSo + "</MADVNHANHSO>" +
                                    "<NGAYNHANHSO>" + nguoilx.NgayNhanHSo + "</NGAYNHANHSO>" +
                                    "<NGUOINHANHSO>" + nguoilx.NguoiNhanHSo + "</NGUOINHANHSO>" +
                                    "<NGAYHENTRA>" + nguoilx.NgayHenTra + "</NGAYHENTRA>" +
                                    "<MALOAIHS>" + nguoilx.MaLoaiHs + "</MALOAIHS>" +
                                    "<TT_XULY>" + nguoilx.TT_XuLy + "</TT_XULY>" +
                                    "<DUONGDANANH>" + ConvertBitmapToBase64(Viettel.ReadJP2.LibJP2.LibRead.GetBitMap(nguoilx.DuongDanAnh)) + "</DUONGDANANH>" +
                                    "<CHATLUONGANH>" + nguoilx.ChatLuongAnh + "</CHATLUONGANH>" +
                                    "<NGAYTHUNHANANH>" + nguoilx.NgayThuNhanAnh + "</NGAYTHUNHANANH>" +
                                    "<NGUOITHUNHANANH>" + nguoilx.NguoiThuNhanAnh + "</NGUOITHUNHANANH>" +
                                    "<SOGPLXDACO>" + nguoilx.SoGPLXDaCo + "</SOGPLXDACO>" +
                                    "<HANGGPLXDACO>" + nguoilx.HangGPLXDaCo + "</HANGGPLXDACO>" +
                                    "<DONVICAPGPLXDACO>" + nguoilx.DonViCapGPLXDaCo + "</DONVICAPGPLXDACO>" +
                                    "<NOICAPGPLXDACO>" + nguoilx.NoiCapGPLXDaCo + "</NOICAPGPLXDACO>" +
                                    "<NGAYCAPGPLXDACO>" + nguoilx.NgayCapGPLXDaCo + "</NGAYCAPGPLXDACO>" +
                                    "<NGAYHHGPLXDACO>" + nguoilx.NgayHHGPLXDaCo + "</NGAYHHGPLXDACO>" +
                                    "<NGAYTTGPLXDACO>" + nguoilx.NgayTTGPLXDaCo + "</NGAYTTGPLXDACO>" +
                                    "<DONVIHOCLX>" + nguoilx.DonViHocLX + "</DONVIHOCLX>" +
                                    "<NAMHOCLX>" + nguoilx.NamHocLX + "</NAMHOCLX>" +
                                    "<HANGGPLX>" + nguoilx.HangGPLX + "</HANGGPLX>" +
                                    "<SONAMLX>" + nguoilx.SoNamLX + "</SONAMLX>" +
                                    "<SOKMLXANTOAN>" + nguoilx.SoKmLXAnToan + "</SOKMLXANTOAN>" +
                                    "<GIAYCNSK>" + nguoilx.GiayCNSK + "</GIAYCNSK>" +
                                    "<LYDOCAPDOI>" + nguoilx.LyDoCapDoi + "</LYDOCAPDOI>" +
                                    "<MUCDICHCAPDOI>" + nguoilx.MucDichCapDoi + "</MUCDICHCAPDOI>" +
                                    "<NOIDUNGSH>" + nguoilx.NoiDungSH + "</NOIDUNGSH>" +
                                    "<MAKHOAHOC>" + nguoilx.MaKhoaHoc + "</MAKHOAHOC>" +
                                    "<HANGDAOTAO>" + nguoilx.HangDaoTao + "</HANGDAOTAO>" +
                                    "<SOGIAYCNTN>" + nguoilx.SoGiayCNTN + "</SOGIAYCNTN>" +
                                    "<SOCCN>" + nguoilx.SoCCN + "</SOCCN>" +
                                    "<MABC1>" + nguoilx.MaBC1 + "</MABC1>" +
                                    "<BC1_TUOITS>" + nguoilx.BC1_TuoiTS + "</BC1_TUOITS>" +
                                    "<BC1_THAMNIEN>" + nguoilx.BC1_ThamNien + "</BC1_THAMNIEN>" +
                                    "<MABC2>" + nguoilx.MaBC2 + "</MABC2>" +
                                    "<KETQUABC2>" + nguoilx.KetQuaBC2 + "</KETQUABC2>" +
                                    "<MALYDOTCBC2>" + nguoilx.MaLyDoTCBC2 + "</MALYDOTCBC2>" +
                                    "<MAKYSH>" + nguoilx.MaKySH + "</MAKYSH>" +
                                    "<SOBD>" + nguoilx.SoBD + "</SOBD>" +
                                    "<LANSH>" + nguoilx.LanSH + "</LANSH>" +
                                    "<SOQDSH>" + nguoilx.SoQDSH + "</SOQDSH>" +
                                    "<NGAYQDSH>" + nguoilx.NgayQDSH + "</NGAYQDSH>" +
                                    "<KETQUA_LYTHUYET>" + nguoilx.KetQua_LyThuyet + "</KETQUA_LYTHUYET>" +
                                    "<NHANXET_LYTHUYET>" + nguoilx.NhanXet_LyThuyet + "</NHANXET_LYTHUYET>" +
                                    "<KETQUA_HINH>" + nguoilx.KetQua_Hinh + "</KETQUA_HINH>" +
                                    "<NHANXET_HINH>" + nguoilx.NhanXet_Hinh + "</NHANXET_HINH>" +
                                    "<KETQUA_DUONG>" + nguoilx.KetQua_Duong + "</KETQUA_DUONG>" +
                                    "<NHANXET_DUONG>" + nguoilx.NhanXet_Duong + "</NHANXET_DUONG>" +
                                    "<KETQUASH>" + nguoilx.KetQuaSH + "</KETQUASH>" +
                                    "<SOQDTT>" + nguoilx.SoQDTT + "</SOQDTT>" +
                                    "<NGAYQDTT>" + nguoilx.NgayQDTT + "</NGAYQDTT>" +
                                    "<NGUOIKY>" + nguoilx.NguoiKy + "</NGUOIKY>" +
                                    "<GHICHU>" + nguoilx.GhiChu + "</GHICHU>" +
                                    "<NGUOITAO>" + nguoilx.NguoiTao + "</NGUOITAO>" +
                                    "<NGUOISUA>" + nguoilx.NguoiSua + "</NGUOISUA>" +
                                    "<NGAYTAO>" + nguoilx.NgayTao + "</NGAYTAO>" +
                                    "<NGAYSUA>" + nguoilx.NgaySua + "</NGAYSUA>" +
                                    "<SOGPLXTMP>" + nguoilx.SoGPLXTmp + "</SOGPLXTMP>" +
                                    "<NGAYKTBC1>" + nguoilx.NgayKTBC1 + "</NGAYKTBC1>" +
                                    "<NGUOIKTBC1>" + nguoilx.NguoiKTBC1 + "</NGUOIKTBC1>" +
                                    "<NGAYKTBC2>" + nguoilx.NgayKTBC2 + "</NGAYKTBC2>" +
                                    "<NGUOIKTBC2>" + nguoilx.NguoiKTBC2 + "</NGUOIKTBC2>" +
                                    "<MAIN>" + nguoilx.MaIn + "</MAIN>" +
                                    "<KETQUADOISANHTW>" + nguoilx.KetQuaDoiSanhTW + "</KETQUADOISANHTW>" +
                                    "<GHICHUKQDSTW>" + nguoilx.GhiChuKQDSTW + "</GHICHUKQDSTW>" +
                                    "<CHUKY>" + nguoilx.ChuKy + "</CHUKY>" +
                                    "<TRANGTHAI>" + nguoilx.TrangThai + "</TRANGTHAI>" +
                                    "<MAHTCAP>" + nguoilx.MaHTCap + "</MAHTCAP>" +
                                    "<IDS>" + nguoilx.IDs + "</IDS>" +
                                    "<TT_XULY_OLD>" + nguoilx.TT_XuLy_Old + "</TT_XULY_OLD>" +
                                    "<KQ_BC1>" + nguoilx.KQ_BC1 + "</KQ_BC1>" +
                                    "<KQ_BC1_GHICHU>" + nguoilx.KQ_BC1_GhiChu + "</KQ_BC1_GHICHU>" +
                                    "<TRANSFER_FLAG>" + nguoilx.Transfer_flag + "</TRANSFER_FLAG>" +
                                    "<NAMCAPLANDAU>" + nguoilx.NamcapLandau + "</NAMCAPLANDAU>" +
                                    "<MATRICHNGANG>" + nguoilx.MaTrichNgang + "</MATRICHNGANG>" +
                                    "<DIACHITRENGPLX>" + nguoilx.DiaChiTrenGplx + "</DIACHITRENGPLX>" +
                                    "<COQUANQUANLYGPLX>" + nguoilx.CoQuanQuanLyGplx + "</COQUANQUANLYGPLX>" +
                                    "<DIACHITRENGPLX_CHITIET>" + nguoilx.DiaChiTrenGplx_ChiTiet + "</DIACHITRENGPLX_CHITIET>" +
                                    "<IN_GPLX>" + nguoilx.IN_GPLX + "</IN_GPLX>" +
                                    "<SOSERI_GPLX_DACO>" + nguoilx.SOSERI_GPLX_DACO + "</SOSERI_GPLX_DACO>" +
                                    "</NGUOILX_HOSO>";
            return XmlNguoilxHoSo;
        }


        public static string CreateListNguoiLXHoSoToXml(List<NguoiLX_HoSo> lstNguoiLXHoSo)
        {
            string result = "";
            foreach (NguoiLX_HoSo nguoilx in lstNguoiLXHoSo)
            {
                result = result + CreateNguoiLXHoSoToXml(nguoilx);
            }
            return result;
        }

        public static string CreateGiayToToXml(NguoiLXHS_GiayTo giayto)
        {
            string gplx_vpdk_header = "<GIAY_TO>" +
                    "<MADK>" + giayto.MaDK + "</MADK>" +
                    "<MAGT>" + giayto.MaGT + "</MAGT>" +
                    "<SOHOSO>" + giayto.SoHoSo + "</SOHOSO>" +
                    "<TEN_NLX>" + giayto.TenGT + "</TEN_NLX>" +
                    "<TRANGTHAI>" + giayto.TrangThai + "</TRANGTHAI>" +
                    "</GIAY_TO>";
            return gplx_vpdk_header;
        }

        public static string CreateListGiayToToXml(List<NguoiLXHS_GiayTo> lstGiayTo)
        {
            string result = "";
            foreach (NguoiLXHS_GiayTo giayto in lstGiayTo)
            {
                result = result + CreateGiayToToXml(giayto);
            }
            return result;
        }

        public static string CreateFileStringXml(List<NguoiLX> lstNguoiLX, List<NguoiLX_HoSo> lstNguoiLXHoSo, List<NguoiLXHS_GiayTo> lstGiayTo)
        {
            StringBuilder str = new StringBuilder("");
            str.Append(CreateOpenHeaderXml("","","",DateTime.Now.ToString(),"",lstNguoiLX.Count.ToString()));
            str.Append(CreateListNguoiLXToXml(lstNguoiLX));
            str.Append(CreateListNguoiLXHoSoToXml(lstNguoiLXHoSo));
            str.Append(CreateListGiayToToXml(lstGiayTo));
            str.Append(CreateCloseHeaderXml());
            return str.ToString();
        }

        public static void XuatFileXml(string filename, string data)
        {
            XmlDocument xdoc = new XmlDocument();
            XmlNode docNode = xdoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xdoc.AppendChild(docNode);
            xdoc.LoadXml(data);
            xdoc.Save(filename);
            
        }

        public static void SetFileConnect(string contextName, string _DiaChiMayChu, string _TenCSDL, 
            string _Uid, string _pw)
        {
            string connectionStringQT = @"Data Source=" + _DiaChiMayChu + ";Initial Catalog=" + _TenCSDL + ";UID=" + _Uid + ";password=" + _pw + ";";
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings[contextName].ConnectionString = connectionStringQT;
            config.Save();

            ConfigurationManager.RefreshSection("connectionStrings");
        }
        public static bool IsServerConnected(string connectString)
        {
            using (var sqlConnection = new System.Data.SqlClient.SqlConnection(connectString))
            {
                try
                {
                    sqlConnection.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

        }
        public static string getDataFromCell(DataGridViewRow row, string CellName)
        {
            string result = "";
            try
            {
                if (null != row && null != row.Cells[CellName])
                {
                    result = (row.Cells[CellName].FormattedValue == null) ? "" :
                        row.Cells[CellName].FormattedValue.ToString();
                }
            }
            catch (Exception ex) { }
            return result;
        }
        public static byte[] ConvertPasswordToByte(string s)
        {
            try
            {
                return new UnicodeEncoding().GetBytes(s);
            }
            catch //(Exception ex)
            {
                return new byte[0];
            }
        }
        private static byte[] Encrypt(string publickey, byte[] encrypted)
        {
            byte[] rgb = encrypted;
            try
            {
                RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(new CspParameters()
                {
                    ProviderType = 1
                });
                cryptoServiceProvider.FromXmlString(publickey);
                return cryptoServiceProvider.Encrypt(rgb, false);
            }
            catch //(Exception ex)
            {
                return (byte[])null;
            }
        }
        public static string Encrypt(string password)
        {
            try
            {
                return Convert.ToBase64String(Encrypt("<RSAKeyValue><Modulus>lcDIE9z4TWy3FzL7Ae1Un5pq20Xhp8zoeFooDp3jZud5TMfPXMKyALwS4ctOtyfBAMD/Talj1mTLZzMfaKA5KsQzhNKFAskNrKGGUh8TEiCx/1/ur3esgSF4+whJELMvnyurvogZ1paA0u2dSaO/ov7rLmOp10MNjz5y7SW8wkk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", ConvertPasswordToByte(password)));
            }
            catch //(Exception ex)
            {
                return string.Empty;
            }
        }
        public static string Decrypt(string stringDecrypt)
        {
            try
            {
                return ConvertPasswordToString(Decrypt("<RSAKeyValue><Modulus>lcDIE9z4TWy3FzL7Ae1Un5pq20Xhp8zoeFooDp3jZud5TMfPXMKyALwS4ctOtyfBAMD/Talj1mTLZzMfaKA5KsQzhNKFAskNrKGGUh8TEiCx/1/ur3esgSF4+whJELMvnyurvogZ1paA0u2dSaO/ov7rLmOp10MNjz5y7SW8wkk=</Modulus><Exponent>AQAB</Exponent><P>xpPj7FSsq9nXCtBv2252xIyM+Sr5s+AzAhxrdhOF77d0hBurr6DRtS7weIXHKH/jM+fnZIo47w/QUX197K1ppw==</P><Q>wQ6MuM1Sgq1Q7ntn6LBe6NNgK6xQwIekp2OgDH8BspoxLNvaC/E3vmWAexmFtEpYyorCCZ/T76htST2bAScSjw==</Q><DP>waqCY37BWGkAHP/j17IICvC4nFmZZiCGHszw0RuBSKU28ZC7BHJnk7jPtftinND9GSZWuetEU4KsvI0TPrxxiQ==</DP><DQ>XjYpei3IrDjEG/1hEe6wAlLUxbtLlQkc0wsNGcwJGg2hHdEUMWu/1kxWTLyBwR/fAMiCNIwosvWwj2Ne90sIBQ==</DQ><InverseQ>VxF87dPsDH5Lfy4dhfwm1ooirNHtMssqtMERjznW3spJJ3CP9MEu94/LiyBYNaXg0znMLASjjdEsjboSKKraaA==</InverseQ><D>BvsQmJRxYrKRqlwvBTz59+Kr3oLYbQkJQSr6uQu1IQPjTKf3y5wrzgr2Wl4u0izhO1bDz+v4gnL6ZFomuarWX0y6epVPC0j1wlNRPojk37iEd+MXSRco6Tl1ejzicGs/3bRRmGA4aGCbYknUBCeGIwILnC8RgO7CZ2bZV+QvSK0=</D></RSAKeyValue>", Convert.FromBase64String(stringDecrypt)));
            }
            catch //(Exception ex)
            {
                return string.Empty;
            }
        }
        private static byte[] Decrypt(string privatekey, byte[] decrypted)
        {
            byte[] rgb = decrypted;
            try
            {
                RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(new CspParameters()
                {
                    ProviderType = 1
                });
                cryptoServiceProvider.FromXmlString(privatekey);
                return cryptoServiceProvider.Decrypt(rgb, false);
            }
            catch //(Exception ex)
            {
                return (byte[])null;
            }
        }
        private static string ConvertPasswordToString(byte[] arrByte)
        {
            try
            {
                return new UnicodeEncoding().GetString(arrByte);
            }
            catch //(Exception ex)
            {
                return string.Empty;
            }
        }
        public static string ConvertBitmapToBase64(Bitmap bmp)
        {
            if(bmp == null)
            {
                return "";
            }
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] imageBytes = stream.ToArray();
            return Convert.ToBase64String(imageBytes);
        }
    }
}
