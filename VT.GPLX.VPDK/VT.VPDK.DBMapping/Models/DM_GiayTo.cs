using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class DM_GiayTo
    {
        public DM_GiayTo()
        {
            this.NguoiLXHS_GiayTo = new List<NguoiLXHS_GiayTo>();
        }

        public int MaGT { get; set; }
        public string TenGT { get; set; }
        public string TenGTEN { get; set; }
        public string SoVBPL { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public virtual ICollection<NguoiLXHS_GiayTo> NguoiLXHS_GiayTo { get; set; }
    }
}
