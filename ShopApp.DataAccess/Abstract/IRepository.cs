using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id);
        T GetOne(Expression<Func<T, bool>> filter); // ilk kaydı alır
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null); // bütün kayıtları alır

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
