using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car {CarId=14,BrandId=3,ColorId=1,DailyPrice=2500,ModelYear=2020,Desciription="GTR35" });
            //carManager.Add(new Car {CarId=14,BrandId=3,ColorId=1,DailyPrice=0,ModelYear=2020,Desciription="G" });
            //Not : Comment edilmiş kısım hatalı Add metotu kullanımına örnektir.Comment açılıp kontrol edilebilir.



            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Desciription);
            }





        }
    }
}
