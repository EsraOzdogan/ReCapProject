using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager: IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal carDal)
        {
            _brandDal = carDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            //return _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);

        }

        public IDataResult<List<Brand>> GetAllByBrandId(int ıd)
        {
            //return _brandDal.GetAll(b => b.Id == ıd);
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(b => b.Id == ıd));

        }


        public IResult Add(Brand brand)
        {
            // _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);

        }
        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);

        }
        public IResult Update(Brand brand)
        {
             _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);


        }
    }
}
