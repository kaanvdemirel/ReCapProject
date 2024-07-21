using Business.Abstract;
using Business.Constants;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

       ICarDal _carDal;

        public CarManager(ICarDal productDal)
        {
            _carDal = productDal;
        }

        public IResult Add(Car car)
        {
           

            if (car.Name.Length<2)
            {
                return new ErrorResult(Messages.InvalidCarName);
            }
            else
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);

            }

            
           
            
        }

        public void Delete(Car car)
        {
           _carDal.Delete(car);
        }

        public IDataResult<List<Car>> GetAll()
        {

            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            else
            {

            }
            {


                return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
            }
            
        }

        public IDataResult<List<Car>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p=>p.BrandId==id));
        }

        public IDataResult<List<Car>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());

        }

        public void Update(Car car)
        {
            _carDal.Update(car);    
        }
    }
}
