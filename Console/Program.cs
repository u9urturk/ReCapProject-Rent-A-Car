
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
            GetCarDetailsTest();  
            //GetCarAddTest();
        }

        private static void GetCarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { BrandId = 2, ColorId = 2, DailyPrice = 500, ModelYear = 2019, Desciription = "Fiesta", CarName = "54DTO35" });
            Console.WriteLine("                            ");
            Console.WriteLine("YENİ ARAÇ SİSTEME EKLENDİ...");
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");
            //carManager.Add(new Car {BrandId=3,ColorId=1,DailyPrice=0,ModelYear=2020,Desciription="G",CarName="34SSD54" });
            //Not : Comment edilmiş kısım hatalı Add metotu kullanımına örnektir.Comment açılıp kontrol edilebilir.

            Console.WriteLine("<<<<<<<<<<<<<<      ARAÇ LİSTESİ VE DETAYLARI GETİRİLİYOR...        >>>>>>>>>>>>>>>>");
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Araç ID : " + car.CarId + "\n" +
                                  "Araç Plakası : " + car.CarName + "\n" +
                                  "Marka   : " + car.BrandName + "\n" +
                                  "Renk    : " + car.ColorName + "\n" +
                                  "Günlük ücret : " + car.DailyPrice + "\n" +
                                  "Açıklama : " + car.Desciription + "\n" +
                                  "****************************************************************");

            }
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");
            Console.WriteLine("<<<<<<<<<<<<<        HERHANGİ BİR TUŞA BASILARAK LİSTEDEN ÇIKILABİLİR..         >>>>>>>>>>>>>>>>");
        }


        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("<<<<<<<<<<<<<<      ARAÇ LİSTESİ VE DETAYLARI GETİRİLİYOR...        >>>>>>>>>>>>>>>>");
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");





            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Araç Plakası : " + car.CarName + "\n" +
                                  "Marka   : " + car.BrandName + "\n" +
                                  "Renk    : " + car.ColorName + "\n" +
                                  "Günlük ücret : " + car.DailyPrice + "\n" +
                                  "Açıklama : " + car.Desciription);
            }
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");
            Console.WriteLine("<<<<<<<<<<<<<        HERHANGİ BİR TUŞA BASILARAK LİSTEDEN ÇIKILABİLİR..         >>>>>>>>>>>>>>>>");
        }
    }
}
