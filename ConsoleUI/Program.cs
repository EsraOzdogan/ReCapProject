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

            ColorTest();
            DtoTest();
            Console.WriteLine("Hello World!");
        }




        private static void DtoTest()
        {
            var carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "  " + car.BrandName + "  " + car.ColorName + "  " + car.DailyPrice);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Id);
            }
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
