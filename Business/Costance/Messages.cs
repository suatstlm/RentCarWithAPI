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
    }
}
