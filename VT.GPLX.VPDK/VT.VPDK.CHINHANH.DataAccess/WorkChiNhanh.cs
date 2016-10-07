using System;
using VT.VPDK.CHINHANH.Models;
using VT.VPDK.DBMapping.Models;
using VT.VPDK.CHINHANH.DataAccess.Repository;

namespace VT.VPDK.CHINHANH.DataAccess
{
    public class WorkChiNhanh : IWorkChiNhanh
    {
        /// <summary>
        /// Context kết nối đến CSDL
        /// Khi áp dụng framework này, BẠN PHẢI THAY fwContext BẰNG CONTEXT CỦA BẠN
        /// </summary>
        private gplx_vpdkContext _context;

        public gplx_vpdkContext Context
        {
            get { return this._context; }
            set { this._context = value; }
        }
        
        public WorkChiNhanh()
        {
            InitializeContext();
        }

        /// <summary>
        /// Khởi tạo kết nối
        /// </summary>
        protected void InitializeContext()
        {
            _context = new gplx_vpdkContext();
            _context.Configuration.LazyLoadingEnabled = true;
        }

        #region REPOSITORY

        public INguoiLXRepository NguoiLXs
        {
            get
            {
                return new NguoiLXRepository(_context);
            }
        }
        public INguoiLX_HoSoRepository NguoiLX_HoSos
        {
            get
            {
                return new NguoiLX_HoSoRepository(_context);
            }
        }
        public IQTHT_ThamSoHTRepository QTHT_ThamSoHTs
        {
            get
            {
                return new QTHT_ThamSoHTRepository(_context);
            }
        }
        public INguoiLXHS_GiayToRepository NguoiLXHS_GiayTos
        {
            get
            {
                return new NguoiLXHS_GiayToRepository(_context);
            }
        }
        public IDM_DVHCRepository DM_DVHCs
        {
            get
            {
                return new DM_DVHCRepository(_context);
            }
        }
        public IDM_DonViGTVTRepository DM_DonViGTVTs
        {
            get
            {
                return new DM_DonViGTVTRepository(_context);
            }
        }
        #endregion

        #region TRANSACTION
        /// <summary>
        /// Lấy thông tin về transaction hiện tai
        /// </summary>
        /// <returns></returns>
        public ITransaction BeginTransaction()
        {
            return new Transaction(this);
        }

        /// <summary>
        /// Kết thúc trangsactions
        /// </summary>
        /// <param name="transaction"></param>
        public void EndTransaction(ITransaction transaction)
        {
            if (transaction != null)
            {
                (transaction as IDisposable).Dispose();
                transaction = null;
            }
        }
        #endregion TRANSACTION

        #region SAVE AND DISPOSE DATA

        /// <summary>
        /// Lưu dữ liệu xuống server
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        /// <summary>
        /// Lưu vào giải phóng kết nối
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion SAVE AND DISPOSE DATA
    }
}
