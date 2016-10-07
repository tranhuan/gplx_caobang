using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class TRANS_LoaiDuLieu
    {
        public TRANS_LoaiDuLieu()
        {
            this.TRANS_CLI_HangDoiGui = new List<TRANS_CLI_HangDoiGui>();
            this.TRANS_CLI_HangDoiNhan = new List<TRANS_CLI_HangDoiNhan>();
        }

        public string Id { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public string DangSuDung { get; set; }
        public virtual ICollection<TRANS_CLI_HangDoiGui> TRANS_CLI_HangDoiGui { get; set; }
        public virtual ICollection<TRANS_CLI_HangDoiNhan> TRANS_CLI_HangDoiNhan { get; set; }
    }
}
