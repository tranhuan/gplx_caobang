using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class DM_TrangThai
    {
        public DM_TrangThai()
        {
            this.NguoiLX_HoSo = new List<NguoiLX_HoSo>();
        }

        public string MaTT { get; set; }
        public string TenTT { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public virtual ICollection<NguoiLX_HoSo> NguoiLX_HoSo { get; set; }
    }
}
