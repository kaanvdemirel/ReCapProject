using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

       ICarDal _productDal;

        public CarManager(ICarDal productDal)
        {
            _productDal = productDal;
        }

        public List<Car> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Car> GetByBrandId(int id)
        {
            return _productDal.GetAll(p=>p.BrandId==id);
        }

        public List<Car> GetByColorId(int id)
        {
            return _productDal.GetAll(p => p.ColorId == id);
        }
    }
}
