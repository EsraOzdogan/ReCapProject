using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int ıd);
        List<Car> GetCarsByColorId(int ıd);
        //List<Car> GetAllByCarName(string minname);
        List<Car> GetAllByDailyPrice(decimal min);
        void Add(Car car);
    }
}
