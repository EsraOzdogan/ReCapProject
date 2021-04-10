using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            var carManager = new CarManager(new EfCarDal());
            //Car car = new Car
            //{
            //    Name = "aaa",
            //    BrandId = 1,
            //    ColorId = 2,
            //    ModelYear = 2016,
            //    DailyPrice = 500,
            //    Description = "2. el."
            //};
            //carManager.Add(car);
            //carManager.Update(car);
            //carManager.Delete(car);
            /*carManager.GetAll().Data.ForEach(p => Console.WriteLine(p.Name));
            carManager.GetCarDetails().Data.ForEach(p =>
                Console.WriteLine("{0} {1} {2} {3}", p.CarName, p.BrandName, p.ColorName, p.DailyPrice));
            */
            Console.WriteLine("Hello World!");
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            /*foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }*/

            /*foreach (var product in productManager.GetAllByCategoryId(2))  //2 numaralı categoryidye sahip ürünleri  ver
            {
                Console.WriteLine(product.ProductName);
            }*/
            /*foreach (var car in carManager.GetAllByDailyPrice(0) && carManager.GetAllByCarName('as'))  //min 10 max50 fiyatasahip ürünleri  ver
            {
                Console.WriteLine(car.CarName);
            }*/


            foreach (var car in carManager.GetAllByColorId(4))
            {
                Console.WriteLine(car.Description);
                carManager.Add(car);
            }
        }
    }
}
