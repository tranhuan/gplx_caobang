using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class DVCC3_GPLX
    {
        public long IDs { get; set; }
        public string MaDK { get; set; }
        public string SoGPLXDaCo { get; set; }
        public string HangGPLXDaCo { get; set; }
        public string NoiCapGPLXDaCo { get; set; }
        public string NgayCapGPLXDaCo { get; set; }
        public string NgayHHGPLXDaCo { get; set; }
        public string NgayTTGPLXDaCo { get; set; }
        public string SoSeri { get; set; }
        public Nullable<int> idx { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    }
}
