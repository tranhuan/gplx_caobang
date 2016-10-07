using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using VT.GPLX.VPDK.Utils;
//using VT.VPDK.CHINHANH.Models;
using VT.VPDK.CHINHANH.DataAccess;
//using VT.VPDK.SOGTVT.Models;
using VT.VPDK.SOGTVT.DataAccess;
using VT.VPDK.DBConvert;
using VT.VPDK.DBMapping.Models;
using VT.VPDK.DBMapping.ModelsOther;
using Viettel.ReadJP2.LibJP2;
using log4net;

namespace VT.GPLX.VPDK.Presenation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //
        private static readonly ILog log = LogManager.GetLogger(typeof(frmMain));
        //
        public static string IMG_PATH_VPDK_CHINHANH = "";
        public static string IMG_PATH_VPDK_SOGTVT = "";
        //
        public static string IMG_DUONGDAN_ANH_TOANTHAN = "";
        public static string IMG_DUONGDAN_ANH_BANGGPLX = "";
        //
        public List<NguoiLX_NguoiLX_HoSo> lstNguoiLX = null;
        //
        public static string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\XUATFILEXML\\";
        //
        private void frmMain_Load(object sender, EventArgs e)
        {
            //bool a = Boolean.Parse("");
            //bool b = Boolean.Parse("false");
            //bool C = Boolean.Parse("true");
            //var date1 = CommonReadXml.checkStringToDateTimeOrNull("");
            //var date2 = CommonReadXml.checkStringToDateTimeNotNull("");

            log.Info("BAT DAU " + DateTime.Now.ToString());
            clear();
            //
            bool exists = System.IO.Directory.Exists(appPath);
            if (!exists)
                System.IO.Directory.CreateDirectory(appPath);
            //
            dgvDanhSachDongBo.AutoGenerateColumns = false;
            //design check all

            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            dgvDanhSachDongBo.CellPainting += new DataGridViewCellPaintingEventHandler(dgvThongTinChiTietLoIn_CellPainting);

            //
            //dtpDenNgay.Value = DateTime.Now;
            //dtpTuNgay.Value = new DateTime(2015, 3, 12);
            if ((File.Exists(frmCauHinhHeThong.ConfigfileNameChinhanh) == false) ||
                (File.Exists(frmCauHinhHeThong.ConfigfileNameSogtvt) == false))
            {
                frmCauHinhHeThong frm = new frmCauHinhHeThong();
                frm.ShowDialog();
            }
            cboGioiTinh.SelectedIndex = 0;
            SetConnect();
            //
            loadDuongDanAnh();
            //
            dgvDanhSachGiayTo.AutoGenerateColumns = false;
        }
        //
        CheckBox HeaderCheckBox = null;
        #region THIẾT KẾ BUTTON CHECK ALL DATAGRIDVIEW
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Size = new Size(15, 15);

            this.dgvDanhSachDongBo.Controls.Add(HeaderCheckBox);
        }

        private void dgvThongTinChiTietLoIn_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }
        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            //Get the column header cell bounds
            Rectangle oRectangle = this.dgvDanhSachDongBo.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPoint = new Point();

            oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2 + 1;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2 + 1;

            //Change the location of the CheckBox to make it stay on the header
            HeaderCheckBox.Location = oPoint;
        }
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            HeaderCheckBoxClick((CheckBox)sender);
        }
        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            //bool enableInGPLX = true;
            foreach (DataGridViewRow Row in dgvDanhSachDongBo.Rows)
            {
                ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HCheckBox.Checked;

            }
            dgvDanhSachDongBo.RefreshEdit();
        }

        #endregion END

        private void loadDuongDanAnh()
        {
            IMG_PATH_VPDK_SOGTVT = UnitOfWork.workSoGTVTs.QTHT_ThamSoHTs.GetByKey(CauHinhHeThong.IMG_PATH_VPDK).GiaTriTS;
            IMG_PATH_VPDK_CHINHANH = UnitOfWork.workChiNhanhs.QTHT_ThamSoHTs.GetByKey(CauHinhHeThong.IMG_PATH_VPDK).GiaTriTS;
            //
            QTHT_ThamSoHT THAMSO_ANH_TOANTHAN = UnitOfWork.workChiNhanhs.QTHT_ThamSoHTs.GetByKey(CauHinhHeThong.DUONGDAN_ANH_TOANTHAN);
            QTHT_ThamSoHT THAMSO_ANH_BANGGPLX = UnitOfWork.workChiNhanhs.QTHT_ThamSoHTs.GetByKey(CauHinhHeThong.DUONGDAN_ANH_BANGGPLX);
            if (null == THAMSO_ANH_TOANTHAN)
            {
                //MessageBox.Show("Chưa kết nối đến thư mục ảnh toàn thân. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IMG_DUONGDAN_ANH_TOANTHAN = THAMSO_ANH_TOANTHAN.GiaTriTS;
            }
            if (null == THAMSO_ANH_TOANTHAN)
            {
                //MessageBox.Show("Chưa kết nối đến thư mục ảnh gplx. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IMG_DUONGDAN_ANH_BANGGPLX = THAMSO_ANH_BANGGPLX.GiaTriTS;
            }
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCauHinhHeThong frm = new frmCauHinhHeThong();
            frm.ShowDialog();
            if (CommonUtils.CheckForm(this))
            {
                MessageBox.Show("Đóng chương trình để cập nhận thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SetConnect();
            UnitOfWork unit = new UnitOfWork();
        }

        /// <summary>
        /// Lấy danh sách trên mày trạm (56)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            NguoiLX nguoilx = new NguoiLX();
            nguoilx.HoVaTen = txtHovaTen.Text.Trim();
            nguoilx.SoCMT = txtSoCMND.Text.Trim();
            nguoilx.MaDK = txtMaDK.Text.Trim();
            DateTime fromDate = this.dtpTuNgay.GetDateTimeNullableValue() == null ?
                Convert.ToDateTime("1753-01-01") :
                dtpTuNgay.GetDateTimeValue();
            DateTime toDate = this.dtpDenNgay.GetDateTimeNullableValue() == null ?
                DateTime.Now.AddYears(1) :
                CommonUtils.formatDDMMYYYY(dtpDenNgay.Value).AddDays(1);
            //try
            //{
            lstNguoiLX = UnitOfWork.workChiNhanhs.NguoiLXs.Find_NguoiLX_NguoiLX_HoSo(nguoilx, fromDate, toDate).ToList();
            dgvDanhSachDongBo.DataSource = lstNguoiLX;
            if (dgvDanhSachDongBo.Rows.Count > 0)
            {
                xpPanel2.Caption = "Danh sách đồng bộ : " + dgvDanhSachDongBo.Rows.Count + " hồ sơ";
                updateInfo(0);
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            this.Cursor = Cursors.Default;
            MessageBox.Show("Đã tìm kiếm xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDongBo_Click(object sender, EventArgs e)
        {
            try
            {
                DongBoDuLieu();
                MessageBox.Show("Đã đồng bộ xong CSDL");
            }
            catch (Exception ex)
            {
                log.Debug(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        
        public void DongBoDuLieu()
        {
            if (dgvDanhSachDongBo.Rows.Count <= 0)
            {
                return;
            }
            for (int i = 0; i < dgvDanhSachDongBo.Rows.Count; i++)
            {
                bool isChecked = (bool)dgvDanhSachDongBo[0, i].EditedFormattedValue;
                if (isChecked == false)
                {
                    continue;
                }
                DataGridViewRow row = dgvDanhSachDongBo.Rows[i];
                string madk = CommonUtils.getDataFromCell(row, "MaDK");
                NguoiLX nguoilx_chinhanh = UnitOfWork.workChiNhanhs.NguoiLXs.GetByKey(madk);
                //Kiem tra neu madk,sogplx cu, socmnd da ton tai thi sinh madk moi
                NguoiLX nguoilx_sogtvt = UnitOfWork.workSoGTVTs.NguoiLXs.GetByKey(madk);
                //da ton tai madk trong ban nguoilx
                //kiem tra sogplxcu, socmnd
                if (null != nguoilx_sogtvt)
                {
                    if (nguoilx_sogtvt.SoCMT.Equals(nguoilx_chinhanh.SoCMT) ||
                        nguoilx_sogtvt.SO_CMND_CU.Equals(nguoilx_chinhanh.SO_CMND_CU) ||
                        nguoilx_sogtvt.NguoiLX_HoSo.SoGPLXDaCo.Equals(nguoilx_chinhanh.NguoiLX_HoSo.SoGPLXDaCo))
                    {
                        MessageBox.Show("Người lái xe : " + nguoilx_chinhanh.HoVaTen + ", Số CMND : " + nguoilx_chinhanh.SoCMT +
                            Environment.NewLine + "Có mã đăng ký " + nguoilx_chinhanh.MaDK + " Đã tồn tại trong CSDL");
                        continue;
                    }
                    else
                    {
                        MessageBox.Show("Trùng mã đăng ký trong VPDK");
                    }
                    //sinh madk moi
                    // madk = CommonUtils.newMaDK(madk);
                }
                //su ly madk da dc validate
                InsertOrUpdate(madk);

            }
        }

        private void btnXuatFileXml_Click(object sender, EventArgs e)
        {
            //string pass = DecryptEncrypt.Decrypt("cZ25wCwz/Wt50Kf43TZXeh8z6RVm6zNTQ2uDdyu2Fk+padr56nv+ddj3fq6Pj4ZO+zNqMmTV7TxnU93hKuOJQ99FiwyRm8On1tPcN+xmaTg1IZwEjN7Pge6kI1LVsOsA8u+EI0MXED9twbSscp8eydROkHaUqaNDXIqkRqY9hrY=");
            //MessageBox.Show(pass);
            try
            {
                XuatFileXml();
                MessageBox.Show("Xuất file thành công !!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Xuất file lỗi  " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void XuatFileXml()
        {
            if (dgvDanhSachDongBo.Rows.Count <= 0)
            {
                return;
            }
            List<NguoiLX> lstNguoiLX = new List<NguoiLX>();
            List<NguoiLX_HoSo> lstNguoiLXHoSo = new List<NguoiLX_HoSo>();
            List<NguoiLXHS_GiayTo> lstGiayTo = new List<NguoiLXHS_GiayTo>();

            for (int i = 0; i < dgvDanhSachDongBo.Rows.Count; i++)
            {
                bool isChecked = (bool)dgvDanhSachDongBo[0, i].EditedFormattedValue;
                if (isChecked == false)
                {
                    continue;
                }
                DataGridViewRow row = dgvDanhSachDongBo.Rows[i];
                string madk = CommonUtils.getDataFromCell(row, "MaDK");
                NguoiLX nguoilx = UnitOfWork.workChiNhanhs.NguoiLXs.GetByKey(madk);
                NguoiLX_HoSo nguoilxhoso = UnitOfWork.workChiNhanhs.NguoiLX_HoSos.GetByKey(madk);
                List<NguoiLXHS_GiayTo> lstgt = UnitOfWork.workChiNhanhs.NguoiLXHS_GiayTos.GetByMaDK(madk).ToList<NguoiLXHS_GiayTo>();

                lstNguoiLX.Add(nguoilx);
                lstNguoiLXHoSo.Add(nguoilxhoso);
                foreach (NguoiLXHS_GiayTo gt in lstgt)
                {
                    lstGiayTo.Add(gt);
                }
            }
            string resultXml = CommonUtils.CreateFileStringXml(lstNguoiLX, lstNguoiLXHoSo, lstGiayTo);
            string filename = appPath + "GPLX_VPDK_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xml";
            log.Info(resultXml);
            CommonUtils.XuatFileXml(filename, resultXml);
        }

        private void InsertOrUpdate(string madk)
        {
            NguoiLX nguoilx = UnitOfWork.workChiNhanhs.NguoiLXs.GetByKey(madk);
            NguoiLX_HoSo nguoiLX_HoSo = nguoilx.NguoiLX_HoSo;
            NguoiLX_Hoso_DichVu nguoiLX_HoSo_DichVu = nguoiLX_HoSo.NguoiLX_Hoso_DichVu;
            ICollection<NguoiLXHS_GiayTo> icollection_NguoiLXHS_GiayTo = nguoiLX_HoSo.NguoiLXHS_GiayTo;
            //insert nguoilx
            nguoilx = InsertOrUpdate_NguoiLX(nguoilx);
            //insert nguoilx_hoso
            nguoiLX_HoSo = InsertOrUpdate_NguoiLX_HoSo(nguoiLX_HoSo);
            //insert nguoilx_hoso_dichvu
            nguoiLX_HoSo_DichVu = InsertOrUpdate_NguoiLX_HoSo_DichVu(nguoiLX_HoSo_DichVu);

            if (nguoilx != null && nguoiLX_HoSo != null)
            {
                UnitOfWork.workSoGTVTs.NguoiLXs.AddOrUpdate(nguoilx);
                UnitOfWork.workSoGTVTs.NguoiLX_HoSos.AddOrUpdate(nguoiLX_HoSo);
                //insert nguoilxhs_giayto
                InsertOrUpdate_NguoiLXHS_GiayTo(icollection_NguoiLXHS_GiayTo.ToList());
            }
        }

        private NguoiLX InsertOrUpdate_NguoiLX(NguoiLX nguoilx)
        {
            if (null == nguoilx)
            {
                return null;
            }
            //NguoiLX newNguoiLX = CommonUtils.MappingNguoiLX(nguoilx);
            //UnitOfWork.workSoGTVTs.NguoiLXs.AddOrUpdate(newNguoiLX);
            return CommonUtils.MappingNguoiLX(nguoilx);
        }
        private void InsertOrUpdate_NguoiLXHS_GiayTo(List<NguoiLXHS_GiayTo> lstNguoiLXHS_GiayTo)
        {
            if (null == lstNguoiLXHS_GiayTo)
            {
                return;
            }
            foreach (NguoiLXHS_GiayTo nglx in lstNguoiLXHS_GiayTo)
            {
                NguoiLXHS_GiayTo newNguoiLX = CommonUtils.MappingNguoiLXHS_GiayTo(nglx);
                UnitOfWork.workSoGTVTs.NguoiLXHS_GiayTos.AddOrUpdate(newNguoiLX);
            }
        }
        private NguoiLX_Hoso_DichVu InsertOrUpdate_NguoiLX_HoSo_DichVu(NguoiLX_Hoso_DichVu nguoiLX_HoSo_DichVu)
        {
            if (null == nguoiLX_HoSo_DichVu)
            {
                return null;
            }
            return CommonUtils.MappingNguoiLX_Hoso_DichVu(nguoiLX_HoSo_DichVu);
            //NguoiLX_Hoso_DichVu newNguoiLX = CommonUtils.MappingNguoiLX_Hoso_DichVu(nguoiLX_HoSo_DichVu);
            //UnitOfWork.workSoGTVTs.NguoiLX_Hoso_DichVus.AddOrUpdate(newNguoiLX);
        }
        private NguoiLX_HoSo InsertOrUpdate_NguoiLX_HoSo(NguoiLX_HoSo nguoilx_hoso_chinhanh)
        {
            if (null == nguoilx_hoso_chinhanh)
            {
                return null;
            }
            //
            string newDuongDanAnh = ReplaceDuongDanAnh(nguoilx_hoso_chinhanh.DuongDanAnh);
            if (string.IsNullOrEmpty(newDuongDanAnh) || newDuongDanAnh.Equals(nguoilx_hoso_chinhanh.DuongDanAnh))
            {
                return null;
            }
            //
            if (FileIO.MoveFiles(nguoilx_hoso_chinhanh.DuongDanAnh, IMG_PATH_VPDK_SOGTVT))
            {
                nguoilx_hoso_chinhanh.DuongDanAnh = newDuongDanAnh;
                return CommonUtils.MappingNguoiLXHoSo(nguoilx_hoso_chinhanh);
                //NguoiLX_HoSo newNguoiLX = CommonUtils.MappingNguoiLXHoSo(nguoilx_hoso_chinhanh);
                //UnitOfWork.workSoGTVTs.NguoiLX_HoSos.AddOrUpdate(newNguoiLX);
            }
            else
            {
                MessageBox.Show("Kiểm tra đường dẫn ảnh hồ sơ" + nguoilx_hoso_chinhanh.NguoiLX.HoVaTen);
            }
            return null;
        }
        private string ReplaceDuongDanAnh(string DuongDanAnh)
        {
            string[] arrDuongDanAnh = DuongDanAnh.Split('\\');
            string folder = Path.Combine(arrDuongDanAnh[arrDuongDanAnh.Length - 2], arrDuongDanAnh[arrDuongDanAnh.Length - 1]);
            return Path.Combine(IMG_PATH_VPDK_SOGTVT, folder);
        }
        private void SetConnect()
        {
            SetConnect(frmCauHinhHeThong.ConfigfileNameChinhanh, frmCauHinhHeThong.contextNameChinhanh);
            SetConnect(frmCauHinhHeThong.ConfigfileNameSogtvt, frmCauHinhHeThong.contextNameSogtvt);
        }
        private void SetConnect(string ConfigFile, string ContextName)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(ConfigFile);
            XmlNode xmlNodeChild = xml.FirstChild.FirstChild;
            string DiaChiMayChuQT = CommonUtils.Decrypt(xmlNodeChild.ChildNodes[0].InnerText);
            string TenCSDLQT = CommonUtils.Decrypt(xmlNodeChild.ChildNodes[1].InnerText);
            string TaiKhoanQT = CommonUtils.Decrypt(xmlNodeChild.ChildNodes[2].InnerText);
            string MatKhauQT = CommonUtils.Decrypt(xmlNodeChild.ChildNodes[3].InnerText);
            CommonUtils.SetFileConnect(ContextName, DiaChiMayChuQT, TenCSDLQT, TaiKhoanQT, MatKhauQT);
        }
        private void dgvDanhSachDongBo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                if (dgvDanhSachDongBo.Columns[e.ColumnIndex].Name == "chk" && dgvDanhSachDongBo.CurrentCell is DataGridViewCheckBoxCell)
                {
                    checkOrUncheckCell(e.RowIndex);
                }
                updateInfo(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void checkOrUncheckCell(int RowIndex)
        {
            if (RowIndex == -1)
            {
                return;
            }
            bool isChecked = (bool)dgvDanhSachDongBo[0, RowIndex].EditedFormattedValue;
            if (isChecked == false)
            {
                dgvDanhSachDongBo.Rows[RowIndex].Cells["chk"].Value = "true";
                //khi chọn checkbox

            }
            else
            {
                dgvDanhSachDongBo.Rows[RowIndex].Cells["chk"].Value = "false";

            }
            dgvDanhSachDongBo.EndEdit();
        }
        private void txtNguoiNhanDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void updateInfo(int RowIndex)
        {
            clear();
            DataGridViewRow row = new DataGridViewRow(); //Trường hợp không có dữ liệu thì hiển thị ""
            if (null != lstNguoiLX &&
                    0 <= RowIndex && lstNguoiLX.Count > RowIndex)
            {
                row = dgvDanhSachDongBo.Rows[RowIndex];
            }
            string madk = CommonUtils.getDataFromCell(row, "MaDK");

            NguoiLX nguoilx = UnitOfWork.workChiNhanhs.NguoiLXs.GetByKey(madk);
            if (null == nguoilx)
            {
                return;
            }
            NguoiLX_HoSo nguoiLX_HoSo = nguoilx.NguoiLX_HoSo;
            NguoiLX_Hoso_DichVu nguoiLX_HoSo_DichVu = nguoiLX_HoSo.NguoiLX_Hoso_DichVu;

            ICollection<NguoiLXHS_GiayTo> lstNguoiLXHS_GiayTo = nguoiLX_HoSo.NguoiLXHS_GiayTo;

            txtHovaTenDetail.Text = nguoilx.HoVaTen;
            txtTenInDetail.Text = nguoilx.HoVaTenIn;
            if (!string.IsNullOrEmpty(nguoilx.NgaySinh))
            {
                dtpNgaySinhDetail.Value = CommonUtils.ConvertToDateYYYYMMDD(nguoilx.NgaySinh);
            }
            if (nguoilx.GioiTinh.Equals("F"))
            {
                cboGioiTinh.SelectedIndex = 1;
            }
            txtSoCMNDDetail.Text = nguoilx.SoCMT;
            if (!string.IsNullOrEmpty(nguoilx.NoiCapCMT))
            {
                DM_DonViGTVT dm_DonViGTVT = UnitOfWork.workChiNhanhs.DM_DonViGTVTs.GetByKey(nguoilx.NoiCapCMT);
                txtNoiCapCMNDDetail.Text = dm_DonViGTVT.TenDV;
            }

            if (nguoilx.NgayCapCMT.HasValue)
            {
                dtpNgayCapDetail.Value = nguoilx.NgayCapCMT.Value;
            }
            txtSoCMNDCuDetail.Text = nguoilx.SO_CMND_CU;

            if (!string.IsNullOrEmpty(nguoilx.NoiCT_MaDVHC))
            {
                DM_DVHC dmDVHC = UnitOfWork.workChiNhanhs.DM_DVHCs.GetByKey(nguoilx.NoiCT_MaDVHC);
                txtDiaChiNoiCTDetail.Text = dmDVHC.TenDayDu;
                //
                txtDiaChiDKHKDetail.Text = dmDVHC.TenDayDu;
                if (null != nguoiLX_HoSo.NguoiLX_Hoso_DichVu)
                {
                    txtDiaChiDVCCDetail.Text = dmDVHC.TenDayDu;
                }

            }
            txtChiTietDKHKDetail.Text = nguoilx.NoiTT;
            if (null != nguoiLX_HoSo.NguoiLX_Hoso_DichVu)
            {
                chkSuDungGPLX.Checked = true;
                txtNguoiNhanDetail.Text = nguoiLX_HoSo_DichVu.TEN;
                txtDienThoaiDetail.Text = nguoiLX_HoSo_DichVu.DIEN_THOAI;
                txtChiTietDVCDetail.Text = nguoiLX_HoSo_DichVu.DIACHI;

            }
            if (lstNguoiLXHS_GiayTo.Count > 0)
            {
                dgvDanhSachGiayTo.DataSource = lstNguoiLXHS_GiayTo;
            }
            pbAnhCaNhan.Image = LibRead.GetBitMap(nguoiLX_HoSo.DuongDanAnh);
            //
            setImageAnhTT(nguoiLX_HoSo);
            //
            setImageAnhGPLX(nguoiLX_HoSo);
        }
        private void setLabelDuongDanAnhBangGPLX(string path, bool chk)
        {
            if (!chk)
            {
                lblDuongDanAnhBangGPLX.ForeColor = Color.Red;
                lblDuongDanAnhBangGPLX.Font = new System.Drawing.Font(this.Font, FontStyle.Bold);
                lblDuongDanAnhBangGPLX.Text = "Không tồn tại folder ảnh bằng gplx " + path;
            }
            else
            {
                lblDuongDanAnhBangGPLX.ForeColor = Color.Black;
                lblDuongDanAnhBangGPLX.Font = new System.Drawing.Font(this.Font, FontStyle.Regular);
                lblDuongDanAnhBangGPLX.Text = "ảnh bằng GPLX " + path;
            }

        }
        private void setImageAnhGPLX(NguoiLX_HoSo nguoiLX_HoSo)
        {

            if (!string.IsNullOrEmpty(IMG_DUONGDAN_ANH_BANGGPLX))
            {
                string folder = CommonUtils.GetFolderFile(nguoiLX_HoSo.DuongDanAnh);
                if (null == folder)
                {
                    return;
                }
                string direcFolder = Path.Combine(IMG_DUONGDAN_ANH_BANGGPLX, folder);
                string fileName = CommonUtils.GetFileNameFile(nguoiLX_HoSo.DuongDanAnh);
                string names = fileName.Split('.')[0];
                if (!Directory.Exists(direcFolder))
                {
                    //MessageBox.Show("Không tồn tại folder ảnh bằng gplx" + Environment.NewLine + direcFolder);
                    setLabelDuongDanAnhBangGPLX(direcFolder, false);
                    pbAnhBangGPLX.Image = null;
                }
                else
                {
                    setLabelDuongDanAnhBangGPLX(direcFolder, true);
                    string[] fileNames = Directory.GetFiles(direcFolder);
                    foreach (string item in fileNames)
                    {
                        if (item.Contains(names))
                        {
                            fileName = item;
                            break;
                        }
                    }
                    string PathFullFile = Path.Combine(direcFolder, fileName);
                    pbAnhBangGPLX.Image = LibRead.GetBitMap(PathFullFile);
                }

                //string DuongDanAnhToanThan = Path.Combine(IMG_DUONGDAN_ANH_TOANTHAN, CommonUtils.GetTenAnhChanDung(nguoiLX_HoSo.DuongDanAnh));
                //pbAnhToanThan.Image = LibRead.GetBitMap(DuongDanAnhToanThan);
            }
            else
            {
                pbAnhToanThan.Image = null;
            }
        }
        private void setLabelDuongDanAnhChanDung(string path, bool chk)
        {

            if (!chk)
            {
                lblDuongDanAnhChanDung.ForeColor = Color.Red;
                lblDuongDanAnhChanDung.Font = new System.Drawing.Font(this.Font, FontStyle.Bold);
                lblDuongDanAnhChanDung.Text = "Không tồn tại folder ảnh tt " + path;
            }
            else
            {
                lblDuongDanAnhChanDung.ForeColor = Color.Black;
                lblDuongDanAnhChanDung.Font = new System.Drawing.Font(this.Font, FontStyle.Regular);
                lblDuongDanAnhChanDung.Text = "ảnh tt " + path;
            }
        }
        private void setImageAnhTT(NguoiLX_HoSo nguoiLX_HoSo)
        {
            if (!string.IsNullOrEmpty(IMG_DUONGDAN_ANH_TOANTHAN))
            {
                string folder = CommonUtils.GetFolderFile(nguoiLX_HoSo.DuongDanAnh);
                if (null == folder)
                {
                    return;
                }
                string direcFolder = Path.Combine(IMG_DUONGDAN_ANH_TOANTHAN, folder);
                string fileName = CommonUtils.GetFileNameFile(nguoiLX_HoSo.DuongDanAnh);
                string names = fileName.Split('.')[0];
                if (!Directory.Exists(direcFolder))
                {
                    //MessageBox.Show("Không tồn tại folder ảnh toàn thân" + Environment.NewLine + direcFolder);
                    setLabelDuongDanAnhChanDung(direcFolder, false);
                    pbAnhToanThan.Image = null;
                }
                else
                {
                    setLabelDuongDanAnhChanDung(direcFolder, true);
                    string[] fileNames = Directory.GetFiles(direcFolder);
                    foreach (string item in fileNames)
                    {
                        if (item.Contains(names))
                        {
                            fileName = item;
                            break;
                        }
                    }
                    string PathFullFile = Path.Combine(direcFolder, fileName);
                    pbAnhToanThan.Image = LibRead.GetBitMap(PathFullFile);
                }

                //string DuongDanAnhToanThan = Path.Combine(IMG_DUONGDAN_ANH_TOANTHAN, CommonUtils.GetTenAnhChanDung(nguoiLX_HoSo.DuongDanAnh));
                //pbAnhToanThan.Image = LibRead.GetBitMap(DuongDanAnhToanThan);
            }
            else
            {
                pbAnhToanThan.Image = null;
            }
        }
        private void clear()
        {
            lblDuongDanAnhBangGPLX.Text = "";
            lblDuongDanAnhBangGPLX.Font = new System.Drawing.Font(this.Font, FontStyle.Regular);
            lblDuongDanAnhChanDung.Text = "";
            lblDuongDanAnhChanDung.Font = new System.Drawing.Font(this.Font, FontStyle.Regular);
            txtHovaTenDetail.Text = string.Empty;
            txtTenInDetail.Text = string.Empty;
            //dtpNgaySinhDetail.Value = null;
            txtSoCMNDDetail.Text = string.Empty;
            txtNoiCapCMNDDetail.Text = string.Empty;
            txtSoCMNDCuDetail.Text = string.Empty;
            txtDiaChiNoiCTDetail.Text = string.Empty;
            txtDiaChiChiTietDetail.Text = string.Empty;
            txtDiaChiDKHKDetail.Text = string.Empty;
            txtChiTietDKHKDetail.Text = string.Empty;

            chkSuDungGPLX.Checked = false;
            txtNguoiNhanDetail.Text = string.Empty;
            txtDienThoaiDetail.Text = string.Empty;
            txtDiaChiDVCCDetail.Text = string.Empty;
            txtChiTietDVCDetail.Text = string.Empty;
            dgvDanhSachGiayTo.DataSource = null;
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfoVersion frm = new frmInfoVersion();
            frm.ShowDialog();
        }

        private void ràSoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaSoatThongTin frm = new frmRaSoatThongTin();
            frm.Show();
        }

        private void dgvDanhSachDongBo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                updateInfo(dgvDanhSachDongBo.CurrentCell.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvDanhSachDongBo_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                updateInfo(dgvDanhSachDongBo.CurrentCell.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDanhSachDongBo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < dgvDanhSachDongBo.Rows.Count)
            {
                dgvDanhSachDongBo.Rows[e.RowIndex].Cells[1].Value = e.RowIndex + 1;
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)       // Ctrl-S Save
            {
                // Do what you want here
                e.SuppressKeyPress = true;  // Stops bing! Also sets handled which stop event bubbling
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                dgvDanhSachDongBo.SelectAll();
            }
        }

        private void dgvDanhSachDongBo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char SPACE_KEY = ' ';
            if (SPACE_KEY == e.KeyChar)
            {
                if (dgvDanhSachDongBo.Rows.Count <= 0)
                {
                    return;
                }
                int RowIndex = dgvDanhSachDongBo.CurrentCell.RowIndex;
                if (RowIndex < 0)
                {
                    return;
                }
                //dgvDanhSachDongBo.Rows[RowIndex].Cells["chk"].Value = "true";
                checkOrUncheckCell(RowIndex);
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.Info("KET THUC " + DateTime.Now.ToString());
        }

        private void btnReadXml_Click(object sender, EventArgs e)
        {
            List<NguoiLX> lstNguoiLX = new List<NguoiLX>();
            List<NguoiLX_HoSo> lstNguoiLXHoSo = new List<NguoiLX_HoSo>();
            List<NguoiLXHS_GiayTo> lstNguoiLXGiayTo = new List<NguoiLXHS_GiayTo>();

            string path = appPath + "GPLX_VPDK_20161006180539.xml";
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode_nguoilx, xmlnode_nguoilx_hoso, xmlnode_nguoilx_giayto;
            int i = 0;
            string str = null;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode_nguoilx = xmldoc.GetElementsByTagName("NGUOI_LX");
            xmlnode_nguoilx_hoso = xmldoc.GetElementsByTagName("NGUOILX_HOSO");
            xmlnode_nguoilx_giayto = xmldoc.GetElementsByTagName("GIAY_TO");
            //Get list NguoiLX
            for (i = 0; i <= xmlnode_nguoilx.Count - 1; i++)
            {
                lstNguoiLX.Add(CommonReadXml.CreateNguoiLXfromXmlNode(xmlnode_nguoilx[i]));
                //xmlnode_nguoilx[i].ChildNodes.Item(0).InnerText.Trim();
                //str = xmlnode_nguoilx[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode_nguoilx[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode_nguoilx[i].ChildNodes.Item(2).InnerText.Trim();
                
                //MessageBox.Show(xmlnode_nguoilx[i]["MADK"].InnerText.Trim().ToString());
            }
            
            //Get list NguoiLX_Hoso
            for (i = 0; i <= xmlnode_nguoilx_hoso.Count - 1; i++)
            {
                lstNguoiLXHoSo.Add(CommonReadXml.CreateNguoiLXHoSofromXmlNode(xmlnode_nguoilx[i]));
            }
            //Get list NguoiLX_GiayTo
            for (i = 0; i <= xmlnode_nguoilx_giayto.Count - 1; i++)
            {
                lstNguoiLXGiayTo.Add(CommonReadXml.CreateGiayTofromXmlNode(xmlnode_nguoilx[i]));
            }
            //
            string a ="";
        }
    }
}
