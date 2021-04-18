using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    { 

        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetAllByColorId(int colorId);
        IDataResult<List<Car>> GetAllByBrandId(int brandId);
        IDataResult<List<Car>> GetAllByDailyPrice(decimal min);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        //IDataResult<List<CarDetailDto>> GetCarDetailsByBrandName(string brandName);
        //IDataResult<List<CarDetailDto>> GetCarDetailsByColorName(string colorName);
        //IDataResult<List<CarDetailDto>> GetCarDetailsByBrandNameAndColorName(string brandName, string colorName);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

    }
}
