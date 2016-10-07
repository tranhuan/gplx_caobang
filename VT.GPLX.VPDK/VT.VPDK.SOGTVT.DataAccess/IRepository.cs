using System;
using System.Linq;
using System.Linq.Expressions;

namespace VT.VPDK.SOGTVT.DataAccess
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Tìm kiếm
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Lấy ra một bản ghi từ id (thường là khóa chính của bảng đó) có thể là kiểu int, string hoặc khác
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Xóa một bản ghi
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// Thêm mới một bản ghi
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Cập nhập bản ghi đã tồn tại
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Chuyển dữ liệu lên CSDL
        /// </summary>
        /// <returns></returns>
        /// 
        int Save();
    }
}
