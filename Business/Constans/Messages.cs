﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
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
                                             "KİRA BİLGİSİ KİRA ARŞİVİNE KAYIT EDİLDİ..";
        public static string NullYes =    "iSTENİLEN ARAÇ ŞUAN KİRALANMIŞ DURUMDA"+"\n"+
                                          "DAHA SONRA TEKRAR DENEYİN...";
        public static string notRented = "SİSTEMDE GİRİLEN BİLGİLERE AİT BİR ARAÇ BULUNMAMAKTA";
        public static string RentArchiveList = "KİRALIK ARAÇ ARŞİVİ";
    }
}