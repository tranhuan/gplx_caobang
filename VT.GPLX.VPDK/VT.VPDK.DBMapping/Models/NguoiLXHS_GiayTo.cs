using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class NguoiLXHS_GiayTo
    {
        public int MaGT { get; set; }
        public string MaDK { get; set; }
        public string SoHoSo { get; set; }
        public string TenGT { get; set; }
        public bool TrangThai { get; set; }
        public virtual DM_GiayTo DM_GiayTo { get; set; }
        public virtual NguoiLX_HoSo NguoiLX_HoSo { get; set; }
    }
}
