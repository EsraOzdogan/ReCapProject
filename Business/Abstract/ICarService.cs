﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int ıd);
        List<Car> GetAllByColorId(int ıd);
        List<Car> GetAllByDailyPrice(decimal min);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        List<CarDetailDto> GetCarDetails();


    }
}
