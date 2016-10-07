using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VT.GPLX.VPDK.Utils;
using System.Xml;
using System.Configuration;
using System.IO;

namespace VT.GPLX.VPDK.Presenation
{
    public partial class frmCauHinhHeThong : Form
    {
        public static bool isConfig = false;
        public frmCauHinhHeThong()
        {
            
            InitializeComponent();
        }

        public const string contextNameChinhanh = "gplx_vpdk_chinhanhContext";
        public const string contextNameSogtvt = "gplx_vpdk_sogtvtContext";
        public const string ConfigfileNameSogtvt = "Config_SoGTVT.xml";
        public const string ConfigfileNameChinhanh = "Config_ChiNhanh.xml";

        private void frmCauHinhHeThong_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveDD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiaChiMayChuDD.Text.Trim()))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChiMayChuDD.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenCSDLDD.Text.Trim()))
            {
                MessageBox.Show("Tên CSDL không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenCSDLDD.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenTaiKhoanDD.Text.Trim()))
            {
                MessageBox.Show("Tài khoản không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTaiKhoanDD.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhauDD.Text.Trim()))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauDD.Focus();
                return;
            }
            string connectionStringChiNhanh = @"Data Source=" + txtDiaChiMayChuDD.Text + ";Initial Catalog=" + txtTenCSDLDD.Text + ";UID=" + txtTenTaiKhoanDD.Text + ";password=" + txtMatKhauDD.Text + ";";
            if (CommonUtils.IsServerConnected(connectionStringChiNhanh))
            {
                CreateFileXmlCHINHANH();
                MessageBox.Show("Lưu thành công !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kết nối thất bại !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveCD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiaChiMayChuCD.Text.Trim()))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChiMayChuCD.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenCSDLCD.Text.Trim()))
            {
                MessageBox.Show("Tên CSDL không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenCSDLCD.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenTaiKhoanCD.Text.Trim()))
            {
                MessageBox.Show("Tài khoản không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTaiKhoanCD.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhauCD.Text.Trim()))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCD.Focus();
                return;
            }
            string connectionStringSoGTVT = @"Data Source=" + txtDiaChiMayChuCD.Text + ";Initial Catalog=" + txtTenCSDLCD.Text + ";UID=" + txtTenTaiKhoanCD.Text + ";password=" + txtMatKhauCD.Text + ";";
            if (CommonUtils.IsServerConnected(connectionStringSoGTVT))
            {
                CreateFileXmlSOGTVT();
                MessageBox.Show("Lưu thành công !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kết nối thất bại !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xpPanel1_Paint(object sender, PaintEventArgs e)
        {
            if ((File.Exists(frmCauHinhHeThong.ConfigfileNameChinhanh) == true) &&
                (File.Exists(frmCauHinhHeThong.ConfigfileNameSogtvt) == true))
            {
                LoadFileXmlCHINHANH();
                LoadFileXmlSoGTVT();
            }
            
        }

        private void LoadFileXmlCHINHANH()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(ConfigfileNameChinhanh);
            XmlNode xmlNodeChild = xml.FirstChild.FirstChild;
            txtDiaChiMayChuDD.Text = CommonUtils.Decrypt(xmlNodeChild.ChildNodes[0].InnerText);
            txtTenCSDLDD.Text = CommonUtils.Decrypt(xmlNodeChild.ChildNodes[1].InnerText);
            txtTenTaiKhoanDD.Text = CommonUtils.Decrypt(xmlNodeChild.ChildNodes[2].InnerText);
            txtMatKhauDD.Text = CommonUtils.Decrypt(xmlNodeChild.ChildNodes[3].InnerText);
            CommonUtils.SetFileConnect(contextNameChinhanh, txtDiaChiMayChuDD.Text.Trim(), txtTenCSDLDD.Text.Trim(), txtTenTaiKhoanDD.Text.Trim(), txtMatKhauDD.Text.Trim());
        }
        private void CreateFileXmlCHINHANH()
        {
            string vpdk_chinhanh = "VPDK_CHINHANH";
            string dataSource = CommonUtils.Encrypt(txtDiaChiMayChuDD.Text.Trim());
            string initialCatalog = CommonUtils.Encrypt(txtTenCSDLDD.Text.Trim());
            string uid = CommonUtils.Encrypt(txtTenTaiKhoanDD.Text.Trim());
            string password = CommonUtils.Encrypt(txtMatKhauDD.Text.Trim());
            CommonUtils.CreateFileXml(ConfigfileNameChinhanh, vpdk_chinhanh, dataSource, initialCatalog, uid, password);
            CommonUtils.SetFileConnect(contextNameChinhanh, dataSource, initialCatalog, uid, password);
        }
        private void LoadFileXmlSoGTVT()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(ConfigfileNameSogtvt);
            XmlNode xmlNodeChild = xml.FirstChild.FirstChild;
            txtDiaChiMayChuCD.Text = CommonUtils.Decrypt(xmlNodeChild.ChildNodes[0].InnerText);
            txtTenCSDLCD.Text = CommonUtils.Decrypt(xmlNodeChild.ChildNodes[1].InnerText);
            txtTenTaiKhoanCD.Text = CommonUtils.Decrypt(xmlNodeChild.ChildNodes[2].InnerText);
            txtMatKhauCD.Text = CommonUtils.Decrypt(xmlNodeChild.ChildNodes[3].InnerText);
            CommonUtils.SetFileConnect(contextNameSogtvt, txtDiaChiMayChuDD.Text.Trim(), txtTenCSDLDD.Text.Trim(), txtTenTaiKhoanDD.Text.Trim(), txtMatKhauDD.Text.Trim());
        }
        private void CreateFileXmlSOGTVT()
        {
            string vpdk_sogtvt = "VPDK_SOGTVT";
            string dataSource = CommonUtils.Encrypt(txtDiaChiMayChuCD.Text.Trim());
            string initialCatalog = CommonUtils.Encrypt(txtTenCSDLCD.Text.Trim());
            string uid = CommonUtils.Encrypt(txtTenTaiKhoanCD.Text.Trim());
            string password = CommonUtils.Encrypt(txtMatKhauCD.Text.Trim());
            CommonUtils.CreateFileXml(ConfigfileNameSogtvt, vpdk_sogtvt, dataSource, initialCatalog, uid, password);
            CommonUtils.SetFileConnect(contextNameSogtvt, dataSource, initialCatalog, uid, password);
        }

        
    }
}
