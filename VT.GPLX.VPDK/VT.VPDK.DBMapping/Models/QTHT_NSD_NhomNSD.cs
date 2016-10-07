using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class QTHT_NSD_NhomNSD
    {
        public string IdUser { get; set; }
        public string IdGroup { get; set; }
        public string GhiChu { get; set; }
        public virtual QTHT_NguoiDung QTHT_NguoiDung { get; set; }
        public virtual QTHT_NhomNSD QTHT_NhomNSD { get; set; }
    }
}
