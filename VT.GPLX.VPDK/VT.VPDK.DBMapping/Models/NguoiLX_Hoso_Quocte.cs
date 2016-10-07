using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class NguoiLX_Hoso_Quocte
    {
        public string MaDK { get; set; }
        public string NOI_SINH { get; set; }
        public string ANH_CHU_KY { get; set; }
        public System.DateTime LASTUPDATED { get; set; }
        public string SO_SERI { get; set; }
        public virtual NguoiLX_HoSo NguoiLX_HoSo { get; set; }
    }
}
