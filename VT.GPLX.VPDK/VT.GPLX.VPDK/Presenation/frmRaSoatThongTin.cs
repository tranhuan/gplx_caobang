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
using VT.VPDK.SOGTVT.DataAccess;
using VT.VPDK.DBConvert;
using VT.VPDK.DBMapping.Models;
using Viettel.ReadJP2.LibJP2;

namespace VT.GPLX.VPDK.Presenation
{
    public partial class frmRaSoatThongTin : Form
    {
        public frmRaSoatThongTin()
        {
            InitializeComponent();
        }
        public List<NguoiLX> lstNguoiLX = null;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            NguoiLX nguoilx = new NguoiLX();
            nguoilx.HoVaTen = txtHovaTen.Text.Trim();
            nguoilx.SoCMT = txtSoCMND.Text.Trim();
            DateTime fromDate = this.dtpTuNgay.GetDateTimeNullableValue() == null ?
                Convert.ToDateTime("1753-01-01") :
                dtpTuNgay.GetDateTimeValue();
            DateTime toDate = this.dtpDenNgay.GetDateTimeNullableValue() == null ?
                DateTime.Now.AddYears(1) :
                CommonUtils.formatDDMMYYYY(dtpDenNgay.Value).AddDays(1);
            try
            {
                lstNguoiLX = UnitOfWork.workSoGTVTs.NguoiLXs.Find(nguoilx, fromDate, toDate).ToList();
                dgvDanhSachRaSoat.DataSource = lstNguoiLX;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
            MessageBox.Show("Đã tìm kiếm xong");
        }
    }
}
