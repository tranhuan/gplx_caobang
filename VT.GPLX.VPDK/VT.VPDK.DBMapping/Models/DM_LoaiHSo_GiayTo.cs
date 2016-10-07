using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class DM_LoaiHSo_GiayTo
    {
        public int MaGT { get; set; }
        public int MaLoaiHS { get; set; }
        public string MaHangGPLX { get; set; }
        public string TenGT { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
    }
}
