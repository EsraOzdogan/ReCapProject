using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> //hangi tabloyu verirsem onun için IEntityRepository interfaceinin içindeki foksiyonları yapıyor.Yani T parametresine TEntity gidiyor
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //IDısposable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //addedEntity değişken,var duruma göre herhangi bir veri tipi olur, referans yakala
                addedEntity.State = EntityState.Added; //ekleme yapılcak
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //addedEntity değişken,var duruma göre herhangi bir veri tipi olur, referans yakala
                deletedEntity.State = EntityState.Deleted; //silme yapılcak
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter) //tek data getiricek
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList() //evet ise    //select * from products yapıp listeye çeviriyo
                    : context.Set<TEntity>().Where(filter).ToList(); //hayır ise
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //addedEntity değişken,var duruma göre herhangi bir veri tipi olur, referans yakala
                updatedEntity.State = EntityState.Modified; //güncelleme yapılcak
                context.SaveChanges();
            }
        }
    }
}
