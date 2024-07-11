using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal:ICarDal
    {
        List<Brand> _brands;
        List<Car> _cars;

        public InMemoryProductDal()
        {
                _cars = new List<Car>
                {
                    new Car{Id=1,BrandId=1,ColorId=1,ModelYear="2016",Description="Painted",
                        DailyPrice=200000},

                    new Car{Id=2,BrandId=1,ColorId=2,ModelYear="2024",Description="Accident Free",
                        DailyPrice=200000},

                    new Car{Id=3,BrandId=1,ColorId=3,ModelYear="2002",Description="Serious Accident",
                        DailyPrice=200000},

                    new Car{Id=4,BrandId=2,ColorId=3,ModelYear="2012",Description="Slightly Accident",
                        DailyPrice=200000},

                    new Car{Id=5,BrandId=2,ColorId=4,ModelYear="2020",Description="Spotless",
                        DailyPrice=200000}

                };    
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetByBrandId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Car GetByColorId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {

            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);


            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
                











        }

        Car IEntityRepository<Car>.GetByBrandId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
