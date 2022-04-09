using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //where, generic constraint yapmak için var
    //class, referans tipi belirtir
    //IEntity, T değişkeni sadece IEntity ya da onu implement eden bir data olabilir demek
    //new(), datayı newlenebilir bir tipte olmasını belirtir yani bu yüzden sadece IEntity'yi implement eden classdan veri gelebilir
    public interface IEntityRepository<T> where T:class,IEntity,new()
    { 
        List<T> GetAll(Expression<Func<T,bool>> filter= null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
