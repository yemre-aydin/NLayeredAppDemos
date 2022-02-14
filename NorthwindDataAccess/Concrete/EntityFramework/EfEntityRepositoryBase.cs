using NorthwindDataAccess.Abstract;
using NorthwindEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>where TEntity : class,IEntity, new()
                                                                                       where TContext:DbContext,new()
    {//tabloya gönderilecek bütün operasyonları(insert, update,delete,select ) için metotlarımızı  burada yazmış oluyoruz
        public void Add(TEntity entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity=context.Entry(entity);//insert update operasyonları için kullanılıyor
                                    //Entry metodu sayaseinde ilgili nesneye erilişecek kodu yazabiliyoruz
                addedEntity.State = EntityState.Added;//veritabanında bir nesnem var bu yeni bir nesne var bulamayacağı için yeni ekle diyoruz
                context.SaveChanges();//ve kaydet yapıyoruz

            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context= new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);//filtreye göre datayı getireceğiz

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return filter==null?context.Set<TEntity>().ToList():context.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {//var veritabanında durumunu update olarak çalııştır diyoruz
                var updateEntity=context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
