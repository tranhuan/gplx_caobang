using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class TRANS_CLI_NhatKyNhan
    {
        public string Id { get; set; }
        public string IdInputFile { get; set; }
        public string NguoiThaoTac { get; set; }
        public System.DateTime NgayThaoTac { get; set; }
        public string ThongBao { get; set; }
        public string TrangThai { get; set; }
        public virtual TRANS_CLI_HangDoiNhan TRANS_CLI_HangDoiNhan { get; set; }
    }
}
