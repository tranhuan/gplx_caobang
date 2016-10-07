using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class TRANS_CLI_HangDoiNhan
    {
        public TRANS_CLI_HangDoiNhan()
        {
            this.TRANS_CLI_NhatKyNhan = new List<TRANS_CLI_NhatKyNhan>();
        }

        public string Id { get; set; }
        public string NoiGui { get; set; }
        public string NoiNhan { get; set; }
        public string DuongDan { get; set; }
        public int KickThuocFile { get; set; }
        public string TrangThai { get; set; }
        public string NguoiGui { get; set; }
        public string NguoiNhan { get; set; }
        public System.DateTime NgayNhan { get; set; }
        public string KieuDuLieu { get; set; }
        public virtual ICollection<TRANS_CLI_NhatKyNhan> TRANS_CLI_NhatKyNhan { get; set; }
        public virtual TRANS_LoaiDuLieu TRANS_LoaiDuLieu { get; set; }
    }
}
