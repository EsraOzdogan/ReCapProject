using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //hepsini getir  ürünleri listele //fitreye göre listeleme için expression
        //filter=null tüm dataları getir
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //List<T> GetAllByCategory(int categoryId); yukarda expression ile ürünleri kategoriye göre listele,ürünleri fiyata göre listele
        //şu fiyat araında getiri yapıyor,o yüzden buna ihtiyaç yok
    }
}
