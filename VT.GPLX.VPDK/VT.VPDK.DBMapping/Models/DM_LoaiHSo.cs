using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class DM_LoaiHSo
    {
        public DM_LoaiHSo()
        {
            this.NguoiLX_HoSo = new List<NguoiLX_HoSo>();
        }

        public int MaLoaiHs { get; set; }
        public string TenLoaiHs { get; set; }
        public Nullable<int> ThoiHanTraKQ { get; set; }
        public string SoVBPL { get; set; }
        public string DieuKien { get; set; }
        public string YeuCauDTSHLai { get; set; }
        public string MaHTCap { get; set; }
        public Nullable<int> MaNoiDungSH { get; set; }
        public string Nhom { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgaySua { get; set; }
        public string Hanoi { get; set; }
        public string HanoiViettat { get; set; }
        public virtual ICollection<NguoiLX_HoSo> NguoiLX_HoSo { get; set; }
    }
}
