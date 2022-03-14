using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Costance
{
    public class Messages
    {
        public static string CarAdded = ("Araba eklendi");

        public static string CheckCarRent = ("Araba başka bir kullanıcı tarafından kiralanmıştır");

        public static string CarImageAdded = ("Araba için fotoğraf eklendi");

        public static string CheckCarImage = ("Arabanın resim adeti 5 fazla olamaz");

        public static string CarImageLimitExceeded = ("5'den fazla resim eklenemez");

        public static string CarImageDeleted = ("Araba için fotoğraf silindi");
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered { get; internal set; }
        public static User UserNotFound { get; internal set; }
        public static User PasswordError { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static string UserAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
    }
}
