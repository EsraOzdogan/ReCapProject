using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByColorId(int ıd)
        {
            return _carDal.GetAll(c => c.ColorId == ıd);
        }

        public List<Car> GetCarsByBrandId(int ıd)
        {
            return _carDal.GetAll(c => c.BrandId == ıd);
        }

        /*public List<Car> GetAllByCarName(string minname)
        {
            return _carDal.GetAll(c => c.CarName >= minname);
        }
        */
        public List<Car> GetAllByDailyPrice(decimal min)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min);
        }

        public void Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
                _carDal.Add(car);
            else
                Console.WriteLine("Eklenemedi");
        }
    }
}
