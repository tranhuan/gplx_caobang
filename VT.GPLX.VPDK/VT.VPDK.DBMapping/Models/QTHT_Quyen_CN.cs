using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class QTHT_Quyen_CN
    {
        public string IdRole { get; set; }
        public string IdFunction { get; set; }
        public string Ghichu { get; set; }
        public virtual QTHT_ChucNang QTHT_ChucNang { get; set; }
        public virtual QTHT_Quyen QTHT_Quyen { get; set; }
    }
}
