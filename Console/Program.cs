
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
            //GetCarDetailsTest();  
            GetCarAddTest();
        }

        private static void GetCarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("                            ");
            Console.WriteLine("YENİ ARAÇ SİSTEME EKLENiYOR...");
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");

            var result1 = carManager.Add(new Car { BrandId = 6, ColorId = 4, DailyPrice =0, ModelYear = 2019, Desciription = "Yeni ", CarName = "34OOP35" });
            if (result1.Success==true)
            {
                Console.WriteLine(result1.Message);
                Console.WriteLine("<<<<<<<<<<<<<<      ARAÇ LİSTESİ VE DETAYLARI GETİRİLİYOR...        >>>>>>>>>>>>>>>>");
                Console.WriteLine("                            ");
                Console.WriteLine("                            ");
                Console.WriteLine("                            ");
                Console.WriteLine("                            ");
                var result = carManager.GetCarDetails();

                if (result.Success == true)
                {

                    foreach (var car in result.Data)
                    {
                        Console.WriteLine("Araç Plakası : " + car.CarName + "\n" +
                                      "Marka   : " + car.BrandName + "\n" +
                                      "Renk    : " + car.ColorName + "\n" +
                                      "Günlük ücret : " + car.DailyPrice + "\n" +
                                      "Açıklama : " + car.Desciription);
                    }
                    Console.WriteLine(result.Message);
                }
                else
                {
                    Console.WriteLine(result.Message);
                }
            }
            else
            {
                Console.WriteLine(result1.Message);
                
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



            var result = carManager.GetCarDetails();

            if (result.Success==true)   
            {
                
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Araç Plakası : " + car.CarName + "\n" +
                                  "Marka   : " + car.BrandName + "\n" +
                                  "Renk    : " + car.ColorName + "\n" +
                                  "Günlük ücret : " + car.DailyPrice + "\n" +
                                  "Açıklama : " + car.Desciription);
                    Console.WriteLine("**********************************************");
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");
            Console.WriteLine("<<<<<<<<<<<<<        HERHANGİ BİR TUŞA BASILARAK LİSTEDEN ÇIKILABİLİR..         >>>>>>>>>>>>>>>>");
        }
    }
}
