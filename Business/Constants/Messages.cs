using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi.";
        public static string CarUpdated = "Araba Güncellendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarNameException = "Araç adı uygun değil.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarsNotListed = "Arabalar Listelenemedi";


        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string ColorCalled = "İstenilen renk getirildi";
        public static string ColorNotFound = "İstenilen renk bulunamadı. Lütfen geçerli bir renk numarası giriniz.";


        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandListed = "Markalar listelendi";


        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteri listelendi";


        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string SuccessfulLogin ="Giriş yapıldı";
        public static string PasswordError = "Şifre hatalı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string AccessTokenCreated = "Jeton oluşturuldu.";
        public static string UserAlredyExists = "Böyle bir kullanıcı zaten var";
    }
}
