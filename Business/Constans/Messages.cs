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
    }
}
