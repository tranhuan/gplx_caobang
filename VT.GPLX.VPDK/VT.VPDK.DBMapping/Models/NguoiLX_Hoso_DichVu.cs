using System;
using System.Collections.Generic;

namespace VT.VPDK.DBMapping.Models
{
    public partial class NguoiLX_Hoso_DichVu
    {
        public string MADK { get; set; }
        public string MADK_DVCC3 { get; set; }
        public string TEN { get; set; }
        public string DIEN_THOAI { get; set; }
        public string MA_DVHC { get; set; }
        public string DIACHI { get; set; }
        public Nullable<int> TRANG_THAI { get; set; }
        public string LYDO { get; set; }
        public Nullable<System.DateTime> LASTUPDATED { get; set; }
        public virtual NguoiLX_HoSo NguoiLX_HoSo { get; set; }
    }
}
