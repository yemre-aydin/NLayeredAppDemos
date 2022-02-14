using NorthwindEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//burada null filtreyi uygulMk Orunda değil anlamında
        //kullanıcı bir parametre verirse filtreleme yapmak isterse Expression ifadesini kullanıyoruz
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity );

    }
}
