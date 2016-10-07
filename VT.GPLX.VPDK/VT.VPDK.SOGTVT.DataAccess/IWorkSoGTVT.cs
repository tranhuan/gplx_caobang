using System;
using VT.VPDK.SOGTVT.Models;
using VT.VPDK.SOGTVT.DataAccess.Repository;

namespace VT.VPDK.SOGTVT.DataAccess
{
    /// <summary>
    /// Interface UnitOfWork
    /// UnitOfWork đứng ra quản lý toàn bộ các Repository và các transaction trong 1 phiên làm việc
    /// </summary>
    public interface IWorkSoGTVT : IDisposable
    {
        void Save();
        ITransaction BeginTransaction();
        void EndTransaction(ITransaction transaction);

        #region PHẦN DÀNH CHO KHAI BÁO CÁC IREPOSITORY

        INguoiLXRepository NguoiLXs { get; }
        INguoiLX_HoSoRepository NguoiLX_HoSos { get; }
        IQTHT_ThamSoHTRepository QTHT_ThamSoHTs { get; }
        INguoiLXHS_GiayToRepository NguoiLXHS_GiayTos { get; }
        INguoiLX_Hoso_DichVuRepository NguoiLX_Hoso_DichVus { get; }
        IDM_DVHCRepository DM_DVHCs { get; }
        IDM_DonViGTVTRepository DM_DonViGTVTs { get; }
        #endregion PHẦN DÀNH CHO KHAI BÁO CÁC IREPOSITORY
    }
}
