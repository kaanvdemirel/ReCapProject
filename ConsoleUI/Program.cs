using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;



BrandManager brandManager = new BrandManager(new EfBrandDal());
ColorManager colorManager = new ColorManager(new EfColorDal());
CarManager carManager = new CarManager(new EfCarDal());




foreach (var car in carManager.AddCar())
{


    


}