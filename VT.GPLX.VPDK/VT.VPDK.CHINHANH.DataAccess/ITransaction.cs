using System;

namespace VT.VPDK.CHINHANH.DataAccess
{
    /// <summary>
    /// Interface Transaction
    /// </summary>
    public interface ITransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
