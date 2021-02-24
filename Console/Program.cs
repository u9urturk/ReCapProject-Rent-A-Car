
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
            //GetRentAddTest();
            //UserAddAndGetAllTest();
            //CustomerAddAndGetAllTest();
            //RentCarTest();

        }

        private static void RentCarTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.RentCar(new Rental
            {
                CarId = 3,
                CustomerId = 2,
                RentDate = new DateTime(2021, 02, 28),




            });

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);

                var result1 = rentalManager.GetRentalDetails();
                if (result1.Success == true)
                {
                    foreach (var r in result1.Data)
                    {
                        Console.WriteLine("Kira ID:" + r.Id + "\n" +
                                           "Müşteri Ad Soyad : " + r.CustomerName + r.CustomerLastName + "\n" +
                                           "Müşteri Email : " + r.CustomerEmail + "\n" +
                                           "Şirket Adı : " + r.CustomerCumpany + "\n" +
                                           "Araç Plaka : " + r.CarName + "\n" +
                                           "Araç Markası : " + r.CarBrand + "\n" +
                                           "Araç Model : " + r.CarModel + "\n" +
                                           "Günlük Kiralama Ücreti : " + r.DailyRentPrice);
                        Console.WriteLine("************************************************************************");
                    }

                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerAddAndGetAllTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer { UserId = 2, CompanyName = "Şirket 1 " });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                var result1 = customerManager.GetAll();
                if (result1.Success == true)
                {
                    foreach (var customer in result1.Data)
                    {
                        Console.WriteLine("Müşteri ID : " + customer.UserId + "\n" +
                                          "Şirket Adı : " + customer.CompanyName);
                    }
                }
            }
        }

        private static void UserAddAndGetAllTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { FirstName = "Seda", LastName = "Seker", Email = "seda@mail.com", Password = "4444" });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                var result1 = userManager.GetAll();
                if (result1.Success == true)
                {
                    foreach (var user in result1.Data)
                    {
                        Console.WriteLine("Kullanıcı ID : " + user.Id + "\n" +
                                          "Kullanıcı Adı: " + user.FirstName + "\n" +
                                          "Kullanıcı Soyadı : " + user.LastName + "\n" +
                                          "Kullanıcı Email : " + user.Email + "\n" +
                                          "Kullanıcı Şifre : " + user.Password);
                        Console.WriteLine("************************************************************");
                        

                    }

                    
                }
            }
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
