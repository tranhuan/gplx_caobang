using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class QTHT_ThamSoHT
    {
        public string MaTS { get; set; }
        public string DonViSuDung { get; set; }
        public string TenTS { get; set; }
        public string GiaTriTS { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public bool IsUpdate { get; set; }
    }
}
