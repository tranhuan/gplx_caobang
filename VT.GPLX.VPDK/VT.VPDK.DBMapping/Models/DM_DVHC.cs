using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class DM_DVHC
    {
        public DM_DVHC()
        {
            this.NguoiLXes = new List<NguoiLX>();
            this.NguoiLXes1 = new List<NguoiLX>();
            this.NguoiLX_GPLX = new List<NguoiLX_GPLX>();
        }

        public string MaDvhc { get; set; }
        public string MaDVQL { get; set; }
        public string MaDV { get; set; }
        public string TenDvhc { get; set; }
        public string TenNganGon { get; set; }
        public string TenDayDu { get; set; }
        public string LoaiDvhc { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public virtual ICollection<NguoiLX> NguoiLXes { get; set; }
        public virtual ICollection<NguoiLX> NguoiLXes1 { get; set; }
        public virtual ICollection<NguoiLX_GPLX> NguoiLX_GPLX { get; set; }
    }
}
