using System;
using VT.VPDK.CHINHANH.Models;
using VT.VPDK.CHINHANH.DataAccess.Repository;

namespace VT.VPDK.CHINHANH.DataAccess
{
    /// <summary>
    /// Interface UnitOfWork
    /// UnitOfWork đứng ra quản lý toàn bộ các Repository và các transaction trong 1 phiên làm việc
    /// </summary>
    public interface IWorkChiNhanh : IDisposable
    {
        void Save();
        ITransaction BeginTransaction();
        void EndTransaction(ITransaction transaction);

        #region PHẦN DÀNH CHO KHAI BÁO CÁC IREPOSITORY

        INguoiLXRepository NguoiLXs { get; }
        INguoiLX_HoSoRepository NguoiLX_HoSos { get; }
        IQTHT_ThamSoHTRepository QTHT_ThamSoHTs { get; }
        INguoiLXHS_GiayToRepository NguoiLXHS_GiayTos { get; }
        IDM_DVHCRepository DM_DVHCs { get; }
        IDM_DonViGTVTRepository DM_DonViGTVTs { get; }
        #endregion PHẦN DÀNH CHO KHAI BÁO CÁC IREPOSITORY
    }
}
