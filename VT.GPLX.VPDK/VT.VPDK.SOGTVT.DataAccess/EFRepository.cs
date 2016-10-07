using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
//using Viettel.DBMapping.Models;
using VT.VPDK.SOGTVT.Models;

namespace VT.VPDK.SOGTVT.DataAccess
{
    /// <summary>
    /// Repository là thành phần chính tương tác đến CSDL
    /// EFRepository là repository cơ bản nhất, bản thân nó chứa các thành phần cơ bản từ IRepository với một vài thao tác tương tác ban đầu
    /// </summary>
    /// <typeparam name="T"> Model ánh xạ từ các bảng trong CSDL </typeparam>
    public class EFRepository<T> : IRepository<T> where T : class
    {
        protected gplx_vpdkContext DbContext;
        protected DbSet<T> DbSet;

        public EFRepository(DbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new Exception("EFRepository::initialize::dbContext::Canot null");
            }
            this.DbContext = (gplx_vpdkContext)dbContext;
            this.DbSet = this.DbContext.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return this.DbSet;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return this.DbSet.Where(predicate);
        }

        public T GetById(int id)
        {
            string tableName = DbContext.GetTableName<T>();
            string keyName = DbContext.GetTableKeyName<T>();
            var query = string.Format("SELECT * FROM {0} WHERE {1} = @Id", tableName, keyName);
            return DbSet.SqlQuery(query, new SqlParameter("Id", id)).FirstOrDefault();
        }

        public void Delete(T entity)
        {
            this.DbContext.Entry(entity).State = EntityState.Deleted;
            Save();
        }

        public void Add(T entity)
        {
            this.DbContext.Entry(entity).State = EntityState.Added;
            Save();
        }

        public void Update(T entity)
        {
            this.DbContext.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public int Save()
        {
            return DbContext.SaveChanges();
        }
    }
}
