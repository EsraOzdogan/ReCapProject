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
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal carDal)
        {
            _colorDal = carDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            //return _colorDal.GetAll();

            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorsListed);
        }

        public IDataResult<List<Color>> GetAllByColorId(int ıd)
        {
            //return _colorDal.GetAll(c => c.Id == ıd);
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(c => c.Id == ıd));// her p için pnin categorydsi benım categoryıdme(ıd) eşitse filtrele

        }


        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);

        }
        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);

        }
        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);

        }
    }
}
