using Business.Concrete;
using DataAccess.Concrete;

CarManager carManager = new CarManager(new InMemoryProductDal());


foreach (var car in carManager.GetAll()) 
{
    Console.WriteLine(car.Description);
}