using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class QTHT_NSD_Quyen_CN
    {
        public QTHT_NSD_Quyen_CN()
        {
            this.QTHT_Quyen = new List<QTHT_Quyen>();
        }

        public string UserName { get; set; }
        public string IdRole { get; set; }
        public string IdFunction { get; set; }
        public string GhiChu { get; set; }
        public virtual QTHT_ChucNang QTHT_ChucNang { get; set; }
        public virtual QTHT_NguoiDung QTHT_NguoiDung { get; set; }
        public virtual ICollection<QTHT_Quyen> QTHT_Quyen { get; set; }
    }
}
