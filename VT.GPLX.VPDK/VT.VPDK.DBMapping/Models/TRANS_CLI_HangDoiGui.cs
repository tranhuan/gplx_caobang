using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class TRANS_CLI_HangDoiGui
    {
        public TRANS_CLI_HangDoiGui()
        {
            this.TRANS_CLI_NhatKyGui = new List<TRANS_CLI_NhatKyGui>();
        }

        public string Id { get; set; }
        public string NoiGui { get; set; }
        public string NoiNhan { get; set; }
        public string DuongDan { get; set; }
        public Nullable<int> KickThuocFile { get; set; }
        public string TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public System.DateTime NgayTao { get; set; }
        public string KieuDuLieu { get; set; }
        public virtual ICollection<TRANS_CLI_NhatKyGui> TRANS_CLI_NhatKyGui { get; set; }
        public virtual TRANS_LoaiDuLieu TRANS_LoaiDuLieu { get; set; }
    }
}
