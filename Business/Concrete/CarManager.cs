using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IDataResult<List<Car>> GetAll()
        {
            //return _carDal.GetAll();
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id));

        }

        public IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
           // return _carDal.GetAll(c => c.ColorId == colorId);
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));// her p için pnin categorydsi benım categoryıdme(ıd) eşitse filtrele

        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            //return _carDal.GetAll(c => c.BrandId == brandId);
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));// her p için pnin categorydsi benım categoryıdme(ıd) eşitse filtrele

        }

        /*public List<Car> GetAllByCarName(string minname)
        {
            return _carDal.GetAll(c => c.CarName >= minname);
        }
        */
        public IDataResult<List<Car>> GetAllByDailyPrice(decimal min)
        {
            //iş kodları
            //Yetkisi var mı?
            //if (min<0)
            //{
            //    return new ErrorDataResult<List<Car>>(Messages.CarDailyPriceInvalid);

            //}
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            // _carDal.Add(car);
            //if (car.CarName.Length < 2)
            //{
            //    //magic strings, hep aynı string
            //    return new ErrorResult(Messages.CarNameInvalid);
            //}

            //ValidationTools.Validate(new CarValidator(), car);

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAddded);
        }

        [ValidationAspect(typeof(CarValidator))]

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [ValidationAspect(typeof(CarValidator))]

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);

        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());

        }

       
    }
}
