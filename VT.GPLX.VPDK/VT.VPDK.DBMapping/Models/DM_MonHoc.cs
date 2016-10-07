using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class DM_MonHoc
    {
        public int MaMH { get; set; }
        public string TenMH { get; set; }
        public string VPPL { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
    }
}
