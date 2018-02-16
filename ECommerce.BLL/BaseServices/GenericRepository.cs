using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DAL.Data.Context;
using ECommerce.DAL.Model;

namespace ECommerce.BLL.BaseServices
{
   public class GenericRepository<TEntity>:IRepository<TEntity>,IDisposable where TEntity:BaseEntity 
   {
       protected DbContext _context;
       private bool _disposed;

     

        public GenericRepository()
        {
            _context = new ApplicationDbContext();
            
        }
       // TEntity = ECommerce.DAL>Data>Context> ApplicationDbContext deki tablo isimleri yani veri tabanındaki tablo isimleri 
        public virtual void Insert(TEntity entity)
       {
           entity.IsActive = true;
           _context.Set<TEntity>().Add(entity); 
       }

       public void Delete(object id)
       {
           var entity = _context.Set<TEntity>().Find(id);

           if (entity !=null)
           {
               entity.IsActive = false;
               entity.IsDelete = true;
           }
       }

       public void Remove(object id)
       {
           var entity = _context.Set<TEntity>().Find(id);
           _context.Set<TEntity>().Remove(entity);
       }

       public int Save()
       {
           return _context.SaveChanges();
            
        }

       public IEnumerable<TEntity> GetList()
       {
           return _context.Set<TEntity>().Where(x=>x.IsActive && !x.IsDelete).ToList();
       }

       public IQueryable<TEntity> GetListQueryable()
       {
           return _context.Set<TEntity>().Where(x => x.IsActive && !x.IsDelete).AsQueryable();

        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> _lamda)
        {
            return _context.Set<TEntity>().Where(x => x.IsActive && !x.IsDelete).Where(_lamda).ToList();
        }

      

       public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> _lamda)
       {
           return _context.Set<TEntity>().FirstOrDefault(_lamda);
       }

       public bool Any(Expression<Func<TEntity, bool>> _lamda)
       {
           return _context.Set<TEntity>().Any(_lamda);
        }

       public void Dispose(bool disposing)
       {
           if (disposing)
           {
               Dispose();
               _disposed = true;
           } 
        }

       public void Dispose() // ram üzerindeki verileri silecek bu sayede proje daha hızlı çalışacak zaman aşımı olmayacak *Garabge connection*
       {
           _context.Dispose(); // database üzerindeki bağlantıyı kesmek için
            GC.SuppressFinalize(this); // Generic Repository deki tüm sınıfları ram üzerniden silmek için
       }
   }
}
