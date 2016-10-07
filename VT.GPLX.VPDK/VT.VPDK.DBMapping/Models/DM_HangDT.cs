using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class DM_HangDT
    {
        public DM_HangDT()
        {
            this.KhoaHocs = new List<KhoaHoc>();
            this.NguoiLX_HoSo = new List<NguoiLX_HoSo>();
        }

        public string MaHangDT { get; set; }
        public string TenHangDT { get; set; }
        public string HangGPLX { get; set; }
        public string SoVBPL { get; set; }
        public Nullable<int> TuoiHV { get; set; }
        public Nullable<int> ThamNien { get; set; }
        public Nullable<int> KmLXAT { get; set; }
        public string DKSH { get; set; }
        public string MucTieuDT { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public virtual ICollection<KhoaHoc> KhoaHocs { get; set; }
        public virtual ICollection<NguoiLX_HoSo> NguoiLX_HoSo { get; set; }
    }
}
