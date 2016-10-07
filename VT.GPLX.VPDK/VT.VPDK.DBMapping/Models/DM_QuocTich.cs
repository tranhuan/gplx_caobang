using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class DM_QuocTich
    {
        public DM_QuocTich()
        {
            this.NguoiLXes = new List<NguoiLX>();
            this.NguoiLX_GPLX = new List<NguoiLX_GPLX>();
        }

        public string Ma { get; set; }
        public string TenEN { get; set; }
        public string TenVN { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public virtual ICollection<NguoiLX> NguoiLXes { get; set; }
        public virtual ICollection<NguoiLX_GPLX> NguoiLX_GPLX { get; set; }
    }
}
