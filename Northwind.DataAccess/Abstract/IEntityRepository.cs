using Norhwind.Entities.Abstract;
using Norhwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new() // T: class, IEntity'den kalıtım almış, newlenebiliriz olmalı.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //Kullanıcı isterse filtreli arar, isterse filtresiz direkt arar.
        T Get(Expression<Func<T, bool>> filter); // Sadece filtreli arama yapabilir.
        void Delete(T entity);
        void Add(T entity);
        void Update(T entity);
    }
}
