using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class QTHT_NhomCN
    {
        public string IdGroup { get; set; }
        public string IdFunction { get; set; }
        public string GhiChu { get; set; }
        public virtual QTHT_ChucNang QTHT_ChucNang { get; set; }
        public virtual QTHT_NhomNSD QTHT_NhomNSD { get; set; }
    }
}
