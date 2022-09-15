using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint -- generic kısıt 
    //class -- referanst tip olabilir
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
