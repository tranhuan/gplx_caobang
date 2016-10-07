using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class QTHT_ChucNang
    {
        public QTHT_ChucNang()
        {
            this.QTHT_ChucNang1 = new List<QTHT_ChucNang>();
            this.QTHT_NhomCN = new List<QTHT_NhomCN>();
            this.QTHT_NSD_Quyen_CN = new List<QTHT_NSD_Quyen_CN>();
            this.QTHT_Quyen_CN = new List<QTHT_Quyen_CN>();
        }

        public string IdFunction { get; set; }
        public string IdParentFunction { get; set; }
        public string FunctionName { get; set; }
        public string Assemply { get; set; }
        public string UserControlPath { get; set; }
        public string ImagePath { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> OderBy { get; set; }
        public virtual ICollection<QTHT_ChucNang> QTHT_ChucNang1 { get; set; }
        public virtual QTHT_ChucNang QTHT_ChucNang2 { get; set; }
        public virtual ICollection<QTHT_NhomCN> QTHT_NhomCN { get; set; }
        public virtual ICollection<QTHT_NSD_Quyen_CN> QTHT_NSD_Quyen_CN { get; set; }
        public virtual ICollection<QTHT_Quyen_CN> QTHT_Quyen_CN { get; set; }
    }
}
