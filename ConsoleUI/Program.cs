using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfProductDal()) ;



foreach (var car in carManager.GetByBrandId(5))
{
    Console.WriteLine(car.Name);
}



