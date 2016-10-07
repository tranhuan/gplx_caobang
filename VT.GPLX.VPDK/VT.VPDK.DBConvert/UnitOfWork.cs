using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT.VPDK.CHINHANH.DataAccess;
using VT.VPDK.SOGTVT.DataAccess;

namespace VT.VPDK.DBConvert
{
    public class UnitOfWork
    {
        //public static string config_chinhanh = "";
        //public static string config_sogtvt = "";

        public static WorkChiNhanh workChiNhanhs
        {
            get
            {
                return new WorkChiNhanh();
            }
        }

        public static WorkSoGTVT workSoGTVTs
        {
            get
            {
                return new WorkSoGTVT();
            }
        }
        //public static WorkChiNhanh mWorkChiNhanh()
        //{
        //    gplx_vpdkContext.nameOrConnectString = config_chinhanh;
        //    WorkChiNhanh work = new WorkChiNhanh();
        //    return work;
        //}
        //public static WorkSoGTVT mWorkChiNhanh()
        //{
        //    gplx_vpdkContext.nameOrConnectString = config_sogtvt;
        //    WorkSoGTVT work = new WorkSoGTVT();
        //    return work;
        //}
        
    }
}
