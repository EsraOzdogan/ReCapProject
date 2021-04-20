using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
  /*  public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;  //Global değişkenler _ ile tanımlanır
        //constructor void vs yok direkt class isimli
        public InMemoryCarDal()
        {
            //Oracle,Sql Server, Postgres , MongoDb bunlardan geliyomuş gibi simulation edildi.
            _cars = new List<Car>
            {
                new Car{CarId=1,CarName= "Ford", BrandId=1, ColorId=1, ModelYear=2000, DailyPrice=15, Description="Son model"},
                new Car{CarId=2, CarName= "Toyota", BrandId=1, ColorId=4, ModelYear=2005, DailyPrice=500, Description="Sahibinden"},
                new Car{CarId=3, CarName= "Bmw",BrandId=2, ColorId=6, ModelYear=2020, DailyPrice=1500, Description="Hasarsız"},
                new Car{CarId=4, CarName= "Ferrari",BrandId=2, ColorId=2, ModelYear=1995, DailyPrice=150, Description="Cilasız"},
                new Car{CarId=5, CarName= "Bmw",BrandId=2, ColorId=3, ModelYear=2016, DailyPrice=85, Description="2. El"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            //foreach(takma isim, if)
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList(); //where içinde bulunan şarta uyan tüm elemanları liste yapıp döndürür
            //where=foreach
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarName = car.CarName;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;


        }
    }*/
}
