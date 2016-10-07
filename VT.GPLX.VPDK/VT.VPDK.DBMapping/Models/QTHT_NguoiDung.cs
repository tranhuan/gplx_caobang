using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class QTHT_NguoiDung
    {
        public QTHT_NguoiDung()
        {
            this.QTHT_NSD_Quyen_CN = new List<QTHT_NSD_Quyen_CN>();
            this.QTHT_NSD_NhomNSD = new List<QTHT_NSD_NhomNSD>();
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string HoTen { get; set; }
        public string SoCMND { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
        public string Prefix { get; set; }
        public virtual ICollection<QTHT_NSD_Quyen_CN> QTHT_NSD_Quyen_CN { get; set; }
        public virtual ICollection<QTHT_NSD_NhomNSD> QTHT_NSD_NhomNSD { get; set; }
    }
}
