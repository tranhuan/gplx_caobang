using System;

namespace VT.VPDK.SOGTVT.DataAccess
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
