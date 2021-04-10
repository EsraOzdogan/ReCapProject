using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        /* public void Add(Car entity)
         {
             using (ReCapProjectContext context = new ReCapProjectContext())
             {
                 var addedEntity = context.Entry(entity); //addedEntity değişken,var duruma göre herhangi bir veri tipi olur, referans yakala
                 addedEntity.State = EntityState.Added; //ekleme yapılcak
                 context.SaveChanges();
             }
         }

         public void Delete(Car entity)
         {
             using (ReCapProjectContext context = new ReCapProjectContext())
             {
                 var deletedEntity = context.Entry(entity);
                 deletedEntity.State = EntityState.Deleted;
                 context.SaveChanges();
             }
         }

         public Car Get(Expression<Func<Car, bool>> filter)
         {
             using (ReCapProjectContext context = new ReCapProjectContext())
             {
                 return context.Set<Car>().SingleOrDefault(filter);
             }
         }

         public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
         {
             using (ReCapProjectContext context = new ReCapProjectContext())
             {
                 return filter == null
                     ? context.Set<Car>().ToList() 
                     : context.Set<Car>().Where(filter).ToList(); //hayır ise
             }
         }

         public void Update(Car entity)
         {
             using (ReCapProjectContext context = new ReCapProjectContext())
             {
                 var updatedEntity = context.Entry(entity);
                 updatedEntity.State = EntityState.Modified;
                 context.SaveChanges();
             }
         }*/





        /*public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,  //products tablosundaki productId2i ProductIdye eşitle
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }*/

        public List<CarDetailDto> GetCarDetails()
        {
            using (var context = new ReCapProjectContext())
            {
                var result = from p in context.Cars
                             join b in context.Brands
                                 on p.BrandId equals b.Id
                             join c in context.Colors
                                 on p.ColorId equals c.Id
                             select new CarDetailDto
                             {
                                 Id = p.CarId,
                                 CarName = p.CarName,
                                 BrandName = b.Name,
                                 ColorName = c.Name,
                                 DailyPrice = p.DailyPrice,
                                 ModelYear = p.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
