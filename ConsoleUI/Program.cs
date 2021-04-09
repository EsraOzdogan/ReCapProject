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
            CarManager carManager= new CarManager(new EfCarDal());
           
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


            foreach (var car in carManager.GetCarsByColorId(4)) {
                Console.WriteLine(car.Description);
                carManager.Add(car);
            }

         

            Console.WriteLine("Hello World!");
        }
    }
}
