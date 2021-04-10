
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
            OperationClaimManager operationClaimsManager = new OperationClaimManager(new EfOperationClaim());
            UserOperationClaimManager userOperationClaimManager = new UserOperationClaimManager(new EfUserOperationClaimDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            

            
            

           
            

            // Kategoriler İçin Input Oluşumu Ve Metotların Tanımlanması
            bool exit = true;
            while (exit)
            {

                Console.Write
                    (
                    "            <<<<<<<<<<<<Rent A Car>>>>>>>>>>>>    \n *************************************************\n"+
                    "         Sisteme Hoş Geldiniz , Test Etmek İstediğiniz Metot Kategorisini Seçiniz\n" +
                    "       1.Araç İşlemleri\n"+
                    "       2.Kira İşlemleri\n"+
                    "       3.Kullanıcı İşlemleri\n"+
                    "       4.Yetki İşlemleri\n" + 
                    "       5.Çıkış\n"+
                    "           Seçiminiz : "              

                    );
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

                if (number == 1)
                {
                    Console.Write
                        (  
                        "        <<<<<<<<<<<<Rent A Car>>>>>>>>>>>>    \n *************************************************\n"+
                        "    <<<<  METOTLAR   >>>\n************************************************\n"+   
                        "       1.Araba Ekle\n"+
                        "       2.Araba Sil\n"+
                        "       3.Arabaları Listele\n"+
                        "       4.Renk Ekle\n"+
                        "       5.Araba Renklerini Listele\n"+
                        "       6.Renk Sil\n"+
                        "       7.Marka Ekle\n"+
                        "       8.Araba Markalarını Listele\n"+
                        "       9.Marka Sil\n"+
                        "       10.Ana Menüye Dön\n"+
                        "       11.Çıkış\n"+
                        "       12.Test(getCarDetailByColorId)\n"+
                        "       13.Test(GetImageByCarId)\n"+
                        "           Seçiminiz : "
                        );
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

                    switch (number2)
                    {
                        case 13:
                            GetCarImageByCarId(carManager);
                            break;
                        case 12:
                            GetCarByColorId(carManager);
                            break;
                        case 1:
                            AddingCar(carManager, brandManager, colorManager);

                            break;

                        case 3:
                            GetAllCar(carManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 4:
                            AddColor(colorManager);

                            break;

                        case 7:
                            AddBrand(brandManager);

                            break;

                        case 8:
                            GetAllBrand(brandManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 5:
                            GetAllColor(colorManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 2:
                            CarDelete(carManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 6:
                            ColorDelete(colorManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 9:
                            BrandDelete(brandManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 10:
                            break;

                        case 11:
                            exit = false;
                            break;

                    }
                }

                if (number == 2)
                {
                    Console.Write
                       (
                       "        <<<<<<<<<<<<Rent A Car>>>>>>>>>>>>    \n *************************************************\n" +
                       "    <<<<  METOTLAR   >>>\n************************************************\n" +
                       "       1.Kiralık Arabaları Listele\n" +
                       "       2.Mevcut Kira Listesini Getir\n"+
                       "       3.Araba Kirala\n"+
                       "       4.Araç Dönüş İşlemini Başlat\n"+
                       "       5.Ana Menüye Dön\n" +
                       "       6.Çıkış\n"+
                       "           Seçiminiz :  "

                       );
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

                    switch (number3)
                    {
                        case 4:
                            ReturnedCar(rentalManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 2:
                            GetRentalDetails(rentalManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;


                        case 3:
                            RentCar(rentalManager, carManager,customerManager);
                            break;

                        case 1:
                            GetAllCar(carManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 5:
                            break;

                        case 6:
                            exit = false;
                            break;


                    }

                }

                if (number == 3)
                {
                    Console.Write
                       (
                       "        <<<<<<<<<<<<Rent A Car>>>>>>>>>>>>    \n *************************************************\n" +
                       "    <<<<  METOTLAR   >>>\n************************************************\n" +
                       "       1.Kullanıcıları Listele\n" +
                       "       2.Kullanıcıya Yetki Ata \n"+
                       "       3.Kullanıcı Yetkisini Sil\n"+
                       "       4.Ana Menüye Dön\n" +
                       "       5.Çıkış\n"+
                       "           Seçiminiz : "
                       );
                    int number4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

                    switch (number4)
                    {
                        case 1:
                            UserDetail(userManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 2:
                            AddUserClaim(userOperationClaimManager,operationClaimsManager,userManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 3:
                            DeleteUserClaim(userOperationClaimManager,userManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;


                        case 4:
                            break;

                        case 5:
                            exit = false;
                            break;
                    }
                }

                if (number == 4)
                {
                    Console.Write
                       (
                       "        <<<<<<<<<<<<Rent A Car>>>>>>>>>>>>    \n *************************************************\n" +
                       "    <<<<  METOTLAR   >>>\n************************************************\n" +
                       "       1.Yetki Ekle \n" +
                       "       2.Yetki Sil\n" +   
                       "       3.Yetkileri Listele\n"+
                       "       4.Ana Menüye Dön\n" +
                       "       5.Çıkış\n" +
                       "           Seçiminiz : "
                       );
                    int number4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

                    switch (number4)
                    {
                        case 1:
                            ClaimAdd(operationClaimsManager);
                            break;

                        case 2:
                            ClaimDelete(operationClaimsManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 3:
                            GetAllClaims(operationClaimsManager);
                            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
                            Console.ReadKey();
                            break;

                        case 4:
                            break;

                        case 5:
                            exit = false;
                            break;


                    }
                }
                switch (number)
                {
                    case 5:
                        exit = false;
                        break;
                        
                }

            }

        }

        // Input Oluşumu Ve Metot Tasarımı 
        private static void RentCar(RentalManager rentalManager,CarManager carManager,CustomerManager customerManager)
        {
            Console.WriteLine("                    <<<<<<     HOŞ GELDİNİZ     >>>>>>>");
            Console.WriteLine(" ");
            Console.WriteLine("             Araba Listesinden Bir Araba Seçiniz      ");
            GetAllCar(carManager);

            Console.Write("     Araba ID : ");
            int carId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("             Müşteri  Seçiniz      ");
            GetCustomerInfo(customerManager);
            Console.WriteLine("                ");
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


            Car carAdd = new Car { BrandId = brandId, ColorId = colorId, CarName = carName, ModelYear = modelYear, DailyPrice = dailyPrice, Description = desciription };
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
                Console.WriteLine($"     Renk ID : {color.ColorId}\n" +
                                  $"     Renk Ismi : {color.ColorName}");
            }
        }

        private static void GetAllBrand(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine($"     Marka ID : {brand.BrandId}\n" +
                                  $"     Marka Ismi : {brand.BrandName}");
            }
        }

        private static void GetAllCar(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine($"     Araç Id : {car.CarId}\n"+
                                  $"     Plaka : {car.CarName}\n" +
                                  $"     Marka : {car.BrandName}\n " +
                                  $"     Model : {car.Desciription}\n " +
                                  $"     Model yılı : {car.ModelYear}\n" +
                                  $"     Renk : {car.ColorName}\n" +
                                  $"     Günlük Ücret : {car.DailyPrice}\n"+
                                    
                                  "*****************************************");
                                 
            }
        }

        private static void GetCarByColorId(CarManager carManager)
        {
            Console.Write("   colorIdTest  : ");
            int colorbyId = Convert.ToInt32(Console.ReadLine());
            foreach (var car in carManager.GetCarsByColorId(colorbyId).Data)
            {
                Console.WriteLine($"  result   : {car.ColorName}");

            }
        }

        private static void GetCarImageByCarId(CarManager carManager)
        {
            Console.Write("   carIdTest   :");
            int imageByCarId = Convert.ToInt32(Console.ReadLine());
            foreach (var image in carManager.GetImageByCarId(imageByCarId).Data)
            {
                Console.WriteLine($" result :  {image.ImagePath}");
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

        private static void GetAllClaims(OperationClaimManager operationClaimManager)
        {
            foreach (var claim in operationClaimManager.GetAllClaims().Data)
            {
                Console.WriteLine($"     Yetki ID : {claim.Id}\n" +
                                  $"     Yetki Ismi : {claim.Name}");
            }
        }

        private static void ClaimAdd(OperationClaimManager operationClaimsManager)
        {
            Console.Write("    Yetki Ünvan ismini Belirtiniz : ");
            string claimName = Console.ReadLine();

            OperationClaim claimadd = new OperationClaim {Name = claimName  };
            operationClaimsManager.AddClaim(claimadd);
            Console.WriteLine("     İşleminiz başarı ile gerçekleşti , Devam etmek için herhangi bir tuşa basabilirsiniz....");
            Console.ReadKey();
        }

        private static void ClaimDelete(OperationClaimManager operationClaimManager)
        {
            Console.WriteLine("    Yetkiler Getiriliyor , Silmek İstediğiniz Yetkinin ID'sini Seçiniz.  ");
            GetAllClaims(operationClaimManager);
            Console.WriteLine(" ");
            Console.Write("    Silinecek Yetki ID :  ");
            int claimId = Convert.ToInt32(Console.ReadLine());
            operationClaimManager.DeleteClaim(operationClaimManager.GetById(claimId).Data);

        }

       

        private static void AddUserClaim(UserOperationClaimManager userOperationClaimManager,OperationClaimManager operationClaimManager,UserManager userManager)
        {
            Console.WriteLine("Yetki Vereceğiniz Kullanıcıyı Seçiniz, Kullanıcılar Getiriliyor...");
            UserDetail(userManager);
            Console.WriteLine(" ");

            Console.Write("Kullanıcı ID :");
            int userId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yetki Seçiniz , Yetkiler Getiriliyor...");
            GetAllClaims(operationClaimManager);
            Console.WriteLine(" ");

            Console.Write("Yetki ID :");
            int claimId = Convert.ToInt32(Console.ReadLine());

            UserOperationClaim userClaimAdd = new UserOperationClaim { UserId = userId, OperationClaimId = claimId };
            userOperationClaimManager.AddUserClaim(userClaimAdd);
            
        }

        private static void DeleteUserClaim(UserOperationClaimManager userOperationClaimManager,UserManager userManager)
        {
            Console.WriteLine("                    <<<<<<     HOŞ GELDİNİZ     >>>>>>>");
            Console.WriteLine(" ");
            Console.WriteLine("             Mevcut Kullanıcı-Yetki Listesi Getiriliyor... , Hangi kullanıcıdan Yetki Silmek İstiyorsanız Kullanıcı ID Giriniz.    ");
            UserDetail(userManager);

            Console.WriteLine(" ");
            Console.Write("         Yetkisi Silinecek Kullanıcı ID : ");
            int userClaimDeleteByUserId = Convert.ToInt32(Console.ReadLine());
            userOperationClaimManager.DeleteUserClaim(userOperationClaimManager.GetById(userClaimDeleteByUserId).Data);
        }

        private static void UserDetail(UserManager userManager)
        {
            foreach (var user in userManager.GetUserDetail().Data)
            {
                Console.WriteLine($"     Kullanıcı ID : {user.UserId}\n" +
                                  $"     İsim : {user.FirstName}\n" +
                                  $"     Soyisim : {user.LastName}\n" +
                                  $"     Email : {user.Email}\n" +
                                  $"     Kullanıcı Yetkisi : {user.ClaimName}");
            }
        }

        private static void GetRentalDetails(RentalManager rentalManager)
        {
            foreach (var rentalcar in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine($"    Kira ID : {rentalcar.Id}\n"+
                                  $"    Araba ID : {rentalcar.CarId}\n" +
                                  $"    Araç Marka : {rentalcar.CarBrand} - Model : {rentalcar.CarModel} - Plaka : {rentalcar.CarName} \n" +
                                  $"    Günlük Ücret : {rentalcar.DailyRentPrice}\n" +
                                  $"    Müşteri ID : {rentalcar.CustomerId}\n"+
                                  $"    Müşteri İsim -- Soyisim : {rentalcar.CustomerName} -- {rentalcar.CustomerLastName}\n" +
                                  $"    Şirket : {rentalcar.CustomerCompany}\n" +
                                  $"    Müşteri Email : {rentalcar.CustomerEmail}\n" +
                                  $"    Kiralanma Tarihi : {rentalcar.RentDate}\n" +
                                  $"    Dönüş Tarihi : {rentalcar.ReturnDate}\n" 
                                 );
            }
        }

        private static void ReturnedCar(RentalManager rentalManager)
        {
            Console.WriteLine("                    <<<<<<     HOŞ GELDİNİZ     >>>>>>>");
            Console.WriteLine(" ");
            Console.WriteLine("             Mevcut Kira Listesi Getiriliyor... , Hangi Araç Dönüş Yapıyorsa O Araç İçin İstenen Bilgileri Girin   ");
            GetRentalDetails(rentalManager);
            Console.WriteLine("");

            Console.Write("     Kira ID :");
            int rentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("     Araba ID :");
            int carId = Convert.ToInt32(Console.ReadLine());

            Console.Write("     Müşteri ID :");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("     Kiralanma Tarihi(GG.AA.YYYY) : ");
            DateTime rentDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("     Dönüş Tarihi(GG.AA.YYYY) : ");
            DateTime returnDate = Convert.ToDateTime(Console.ReadLine());

            Rental returnedCar = new Rental { Id = rentId, CarId = carId, CustomerId = customerId, RentDate = rentDate, ReturnDate = returnDate };
            rentalManager.ReturnedCar(returnedCar);
        }

        private static void GetCustomerInfo(CustomerManager customerManager)
        {
            foreach (var customer in customerManager.GetCustomerInfo().Data)
            {
                Console.WriteLine($"    Müşteri ID : {customer.CustomerId}\n" +
                                 $"     İsim : {customer.CustomerName}\n" +
                                 $"     Soyisim : {customer.CustomerLastName}\n" +
                                 $"     Email : {customer.Email} ");
                                 
            }
        }

        




    }

}
