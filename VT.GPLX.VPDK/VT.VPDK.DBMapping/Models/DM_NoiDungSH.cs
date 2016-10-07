using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class DM_NoiDungSH
    {
        public DM_NoiDungSH()
        {
            this.NguoiLX_HoSo = new List<NguoiLX_HoSo>();
        }

        public int MaNoiDungSH { get; set; }
        public string TenNoiDungSH { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public Nullable<decimal> LePhiSatHach { get; set; }
        public virtual ICollection<NguoiLX_HoSo> NguoiLX_HoSo { get; set; }
    }
}
