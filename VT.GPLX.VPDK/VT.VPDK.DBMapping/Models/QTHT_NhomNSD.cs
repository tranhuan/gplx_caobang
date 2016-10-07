using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class QTHT_NhomNSD
    {
        public QTHT_NhomNSD()
        {
            this.QTHT_NhomCN = new List<QTHT_NhomCN>();
            this.QTHT_NSD_NhomNSD = new List<QTHT_NSD_NhomNSD>();
        }

        public string IdGroup { get; set; }
        public string TenNhom { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> UseFlag { get; set; }
        public virtual ICollection<QTHT_NhomCN> QTHT_NhomCN { get; set; }
        public virtual ICollection<QTHT_NSD_NhomNSD> QTHT_NSD_NhomNSD { get; set; }
    }
}
