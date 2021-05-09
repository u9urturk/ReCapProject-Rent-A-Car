using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ImageUpdated = "Görsel Güncellendi";
        public static string ImageDeleted = "Görsel Silindi";
        public static string ProfileImageLimitExceeded = "Yalnızca Bir Profil Fotoğrafınız Olabilir";
        public static string UpdatedNo = "Güncelleme Başarısız";
        public static string UpdatedOk = "Güncelleme Başarılı";
        public static string CreditCardUpdated = "Kredi Kartı Güncellendi";
        public static string CreditCardDeleted = "Kredi Kartı Silindi";
        public static string CreditCardCreated = "Kredi Kartı Kayıt Edildi";
        public static string NotFindeksPoint = "Yetersiz Findeks Puanı !";
        public static string MaxFindeksPointExceeded = "Tebrikler !\n"+"Max Findeks Puanına Ulaşıldı.";
        public static string FindeksPointDeleted = "Findeks Puanı Silindi.";
        public static string FindeksPointUpdated = "Findeks Puanı Güncellendi.";
        public static string FindeksPointCreated = "Findeks Puanı Oluşturuldu.";
        public static string CarAdded = "Araç eklendi";
        public static string CarNotAdded ="Araç ekleme işlemi gerçekleştirlemedi"+"\n"+
                                            "Araba ile ilgili açıklama en az iki karakter içermelidir."+"\n" +
                                            "Arabanın günlük fiyatı sıfırdan büyük olmalıdır.!";
        public static string CarDeleted = "Araç Silindi";
        public static string CarUpdated = "Araç güncellendi.";
        public static string CarNotUpdated ="Güncelleme işlemi gerçekleştirilemedi"+"\n"+
                                              "Araba ile ilgili açıklama en az iki karakter içermelidir.!" + "\n" +
                                              "Arabanın günlük fiyatı sıfırdan büyük olmalıdır.!";
        public static string CarList = "Araç bilgileri listelendi.!";
        public static string RentalAdded = "ARAÇ KİRALANDI";
        public static string OperationSuccess = "OPERASYON BAŞARILI";
        public static string OperationFail = "İSTENİLEN ARAÇ HENÜZ KİRALAMA İÇİN UYGUN DEĞİL";
        public static string NewUserAdded = "YENİ KULLANICI EKLENDİ";
        public static string UserDeleted = "KULLANICI SİLİNDİ";
        public static string UserUpdeted = "KULLANICI GÜNCELLENDİ";
        public static string NewCustomerAdded = "YENİ MÜŞTERİ EKLENDİ";
        public static string CustomerDeleted = "MÜŞTERİ SİLİNDİ";
        public static string CustomerUpdated = "MÜŞTERİ GÜNCELLENDİ";
        public static string GetAllDetails = "KİRALANAN ARAÇ LİSTESİ";
        public static string RentalList = "KİRALANAN ARAÇ LİSTESİ ";
        
        public static string RentalUpdated = "KİRALIK ARACIN DÖNÜŞÜ GERÇEKLEŞTİ "+"\n"+
                                             "KİRA BİLGİSİ KİRA ARŞİVİNE TAŞINDI..";
        public static string NullYes =    "iSTENİLEN ARAÇ ŞUAN KİRALANMIŞ DURUMDA"+"\n"+
                                          "DAHA SONRA TEKRAR DENEYİN...";
        public static string notRented = "SİSTEMDE GİRİLEN BİLGİLERE AİT BİR ARAÇ BULUNMAMAKTA";
        public static string RentArchiveList = "KİRALIK ARAÇ ARŞİVİ";

        public static string Added = "EKLENDİ";
        public static string Deleted = "SİLİNDİ";
        public static string Updated = "GÜNCELLENDİ";
        public static string CarImageLimitExceeded = "Bir araç için en fazla 4 fotoğraf yüklenebilir.";
        public static string ImageAdded = "GÖRSEL EKLENDİ";
        public static string AuthorizationDenied = "YETKİNİZ YOK ";
        public static string UserRegistered = "KAYIT OLDU";
        public static string UserNotFound = "KULLANICI BULUNAMADI";
        public static string PasswordError = "PAROLA HATASI";
        public static string UserAlreadyExists = "KULLANICI MEVCUT";
        public static string AccessTokenCreated = "Giriş Yapıldı";
        public static string SuccessfulLogin = "BAŞARILI GİRİŞ";
        public static string UnexpectedError = "BEKLENMEDİK BİR HATA OLUŞTU. İŞLEMLER GERİ ALINIRYOR...";
        public static string ClaimAdded = "Rol Başarıyla Eklendi";
        public static string DeletedClaim = "Rol Başarıyla Silindi";
        public static string UserAssigned;
        public static string GetUserList;
    }
}
