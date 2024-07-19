using Business.Abstract;
using Core.Entities;
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

        public void Add(Car car)
        {

            if (car.Name.Length>=2 && car.DailyPrice>0)
            {
                _carDal.Add(car);

            }
            else
            {

                Console.WriteLine("Araba ismi en az 2 harfden oluşmalı ve fiyatı sıfırdan büyük olmalıdır" +
                    "lütfen tekrar deneyiniz.");
            }
            
        }

        public void Delete(Car car)
        {
           _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId==id);
        }

        public List<Car> GetByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();

        }

        public void Update(Car car)
        {
            _carDal.Update(car);    
        }
    }
}
