using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        internal static string CarNotAdded ="Araç ekleme işlemi gerçekleştirlemedi"+"\n"+
                                            "Araba ile ilgili açıklama en az iki karakter içermelidir."+"\n" +
                                            "Arabanın günlük fiyatı sıfırdan büyük olmalıdır.!";
        internal static string CarDeleted = "Araç Silindi";
        internal static string CarUpdated = "Araç güncellendi.";
        internal static string CarNotUpdated ="Güncelleme işlemi gerçekleştirilemedi"+"\n"+
                                              "Araba ile ilgili açıklama en az iki karakter içermelidir.!" + "\n" +
                                              "Arabanın günlük fiyatı sıfırdan büyük olmalıdır.!";
        internal static string CarList = "Araç bilgileri listelendi.!";
        internal static string RentalAdded = "ARAÇ KİRALANDI";
        internal static string OperationSuccess = "OPERASYON BAŞARILI";
        internal static string OperationFail = "İSTENİLEN ARAÇ HENÜZ KİRALAMA İÇİN UYGUN DEĞİL";
        internal static string NewUserAdded = "YENİ KULLANICI EKLENDİ";
        internal static string UserDeleted = "KULLANICI SİLİNDİ";
        internal static string UserUpdeted = "KULLANICI GÜNCELLENDİ";
        internal static string NewCustomerAdded = "YENİ MÜŞTERİ EKLENDİ";
        internal static string CustomerDeleted = "MÜŞTERİ SİLİNDİ";
        internal static string CustomerUpdated = "MÜŞTERİ GÜNCELLENDİ";
        internal static string GetAllDetails = "KİRALANAN ARAÇ LİSTESİ";
        internal static string RentalList = "KİRALANAN ARAÇ LİSTESİ ";
        
        internal static string RentalUpdated = "ARAÇ GÜNCELLENDİ ";
        internal static string NullYes =    "iSTENİLEN ARAÇ ŞUAN KİRALANMIŞ DURUMDA"+"\n"+
                                          "DAHA SONRA TEKRAR DENEYİN...";
        internal static string notRented = "SİSTEMDE GİRİLEN BİLGİLERE AİT BİR ARAÇ BULUNMAMAKTA";
    }
}
