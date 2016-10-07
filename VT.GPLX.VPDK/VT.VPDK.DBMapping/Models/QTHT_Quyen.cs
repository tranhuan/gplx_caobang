using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class QTHT_Quyen
    {
        public QTHT_Quyen()
        {
            this.QTHT_Quyen_CN = new List<QTHT_Quyen_CN>();
            this.QTHT_NSD_Quyen_CN = new List<QTHT_NSD_Quyen_CN>();
        }

        public string IdRole { get; set; }
        public string Name { get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<QTHT_Quyen_CN> QTHT_Quyen_CN { get; set; }
        public virtual ICollection<QTHT_NSD_Quyen_CN> QTHT_NSD_Quyen_CN { get; set; }
    }
}
