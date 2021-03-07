
using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using Core.Utilities.Security.Jwt.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;

namespace ConsoleUI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());
            
            

           
            


            bool exit = true;
            while (exit)
            {

                Console.Write
                    (
                    "            <<<<<<<<<<<<Rent A Car>>>>>>>>>>>>    \n *************************************************\n"+
                    "         Sisteme Hoş Geldiniz , Lütfen Yapmak İstediğiniz İşlemi Belirtin\n" +
                    "       1.Araç İşlemleri\n"+
                    "       2.Kira İşlemleri\n"+
                    "       3.Kullanıcı İşlemleri\n"+
                    "       4.Çıkış\n"+
                    "           Seçiminiz : "              

                    );
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

                if (number == 1)
                {
                    Console.Write
                        (
                        "        <<<<<<<<<<<<Rent A Car>>>>>>>>>>>>    \n *************************************************\n"+
                        "       1.Araba Ekle\n"+
                        "       2.Araba Sil\n"+
                        "       3.Renk Ekle\n"+
                        "       4.Araba Renklerini Listele\n"+
                        "       5.Renk Sil\n"+
                        "       6.Marka Ekle\n"+
                        "       7.Araba Markalarını Listele\n"+
                        "       8.Marka Sil\n"+
                        "       9.Ana Menüye Dön\n"+
                        "       10.Çıkış\n"+
                        "           Seçiminiz : "
                        );
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

                    switch (number2)
                    {
                        case 1:
                            AddingCar(carManager, brandManager, colorManager);

                            break;

                        case 3:
                            AddColor(colorManager);

                            break;

                        case 6:
                            AddBrand(brandManager);

                            break;

                        case 7:
                            GetAllBrand(brandManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 4:
                            GetAllColor(colorManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 2:
                            CarDelete(carManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 5:
                            ColorDelete(colorManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 8:
                            BrandDelete(brandManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 9:
                            break;

                        case 10:
                            exit = false;
                            break;

                    }
                }

                if (number == 2)
                {
                    Console.Write
                       (
                       "        <<<<<<<<<<<<Rent A Car>>>>>>>>>>>>    \n *************************************************\n" +
                       "       1.Kiralık Arabaları Listele\n"+
                       "       2.Araba Kirala\n"+   
                       "       3.Ana Menüye Dön\n" +
                       "       4.Çıkış\n"+
                       "           Seçiminiz :  "

                       );
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

                    switch (number3)
                    {
                        case 2:
                            AddingRental(rentalManager, carManager);
                            break;

                        case 1:
                            GetAllCar(carManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 3:
                            break;

                        case 4:
                            exit = false;
                            break;


                    }

                }

                if (number == 3)
                {
                    Console.Write
                       (
                       "        <<<<<<<<<<<<Rent A Car>>>>>>>>>>>>    \n *************************************************\n" +       
                       "       1.Ana Menüye Dön\n" +
                       "       2.Çıkış\n"+
                       "           Seçiminiz : "
                       );
                    int number4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

                    switch (number4)
                    {
                        case 1:
                            break;

                        case 2:
                            exit = false;
                            break;
                    }
                }

                switch (number)
                {
                    case 4:
                        exit = false;
                        break;
                        
                }
                                                                  
            }

        }

        private static void AddingRental(RentalManager rentalManager,CarManager carManager)
        {
            Console.WriteLine("                    <<<<<<     HOŞ GELDİNİZ     >>>>>>>");
            Console.WriteLine(" ");
            Console.WriteLine("             Araba Listesinden Bir Araba Seçiniz      ");
            GetAllCar(carManager);

            Console.Write("     Araba ID : ");
            int carId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("             Müşteri ID giriniz      ");
            Console.Write("     Müşteri ID :");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Rental rentalAdd = new Rental { CarId = carId, CustomerId = customerId };
            rentalManager.RentCar(rentalAdd);

            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
            Console.ReadKey();

        }


        private static void  AddingCar(CarManager carManager,BrandManager brandManager,ColorManager colorManager)
        {
            Console.WriteLine("<<<<<< Araç özelliklerini belirtiniz   >>>>>>");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     Renk Listesi     ");
            GetAllColor(colorManager);

            Console.Write("     Renk Id : ");
            int colorId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("     Marka Listesi");
            GetAllBrand(brandManager);

            Console.Write("     Marka Id : ");
            int brandId = Convert.ToInt32(Console.ReadLine());

            Console.Write("     Araç Modeli : ");
            string desciription = Console.ReadLine();

            Console.Write("     Model Yılı : ");
            int modelYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("     Araç Plakası : "); 
            string carName = Console.ReadLine();

            Console.Write("     Günlük Ücret : ");
            decimal dailyPrice = Convert.ToDecimal(Console.ReadLine());


            Car carAdd = new Car { BrandId = brandId, ColorId = colorId, CarName = carName, ModelYear = modelYear, DailyPrice = dailyPrice, Desciription = desciription };
            carManager.Add(carAdd);

            Console.WriteLine("   ");
            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
            Console.ReadKey();

            

        }

        private static void AddBrand(BrandManager brandManager)
        {
            Console.Write("     Marka ismini belirtiniz : ");
            string brandName = Console.ReadLine();

            Brand brandAdd = new Brand { BrandName = brandName };
            brandManager.Add(brandAdd);
            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
            Console.ReadKey();
        }

        private static void AddColor(ColorManager colorManager)
        {
            Console.Write("     Renk ismini belirtiniz : "); 
            string colorName = Console.ReadLine();
            
            Color colorAdd = new Color { ColorName = colorName };
            colorManager.Add(colorAdd);
            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
            Console.ReadKey();
        }

        private static void GetAllColor(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine($"Renk ID : {color.ColorId}\n Renk Ismi : {color.ColorName}");
            }
        }

        private static void GetAllBrand(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine($" Marka ID : {brand.BrandId}\n Marka Ismi : {brand.BrandName}");
            }
        }

        private static void GetAllCar(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine($"Araç Id : {car.CarId}\n Marka : {car.BrandName}\n Model : {car.Desciription}\n Renk : {car.ColorName}\n");
            }
        }

        private static void CarDelete(CarManager carManager)
        {
            Console.WriteLine("                    <<<<<<     HOŞ GELDİNİZ     >>>>>>>");
            Console.WriteLine(" ");
            Console.WriteLine("             Mevcut Araç Listesi Getiriliyor... , Silmek istediğiniz araçın ID'sini şeçiniz.    ");
            GetAllCar(carManager);

            Console.WriteLine(" ");
            Console.Write("         Silinecek Araç ID : ");
            int carDeleteById = Convert.ToInt32(Console.ReadLine());
            carManager.Delete(carManager.GetByCarId(carDeleteById).Data);

        }

        private static void ColorDelete(ColorManager colorManager)
        {
            Console.WriteLine("                    <<<<<<     HOŞ GELDİNİZ     >>>>>>>");
            Console.WriteLine(" ");
            Console.WriteLine("             Mevcut Renk Listesi Getiriliyor... , Silmek istediğiniz Rengin ID'sini şeçiniz.    ");
            GetAllColor(colorManager);

            Console.WriteLine(" ");
            Console.Write("         Silinecek Renk ID : ");
            int colorDeleteById = Convert.ToInt32(Console.ReadLine());
            colorManager.Delete(colorManager.GetById(colorDeleteById).Data);
        }

        private static void BrandDelete(BrandManager brandManager)
        {
            Console.WriteLine("                    <<<<<<     HOŞ GELDİNİZ     >>>>>>>");
            Console.WriteLine(" ");
            Console.WriteLine("             Mevcut Marka Listesi Getiriliyor... , Silmek istediğiniz Marka ID'sini şeçiniz.    ");
            GetAllBrand(brandManager);

            Console.WriteLine(" ");
            Console.Write("          Silinecek Marka ID : ");
            int brandDeleteById = Convert.ToInt32(Console.ReadLine());
            brandManager.Delete(brandManager.GetById(brandDeleteById).Data);


        }




    }

}
