using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint -- generic kısıt 
    //class -- referans tip olabilir
    //IEntity olabilir veya IEntitiy'yi implement eden bir nesne olabilir
    // instance'ı oluşturulabilir olmalıdır. IEntity newlenemediği için, elemek için yaptık
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
