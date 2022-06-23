using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Araçlar için hazır mesajlar
        public static string CarAdded = "Araç eklendi.";
        public static string CarDeleted = "Araç silindi.";
        public static string CarUpdated = "Araç güncellendi.";
        public static string CarListed = "Araç listelendi.";
        public static string CarValueInvalid = "Araç açıklaması en az 2 harf içermeli ve ücreti 0 dan büyük olmalıdır";
        //Boyalar için hazır mesajlar
        public static string ColorAdded = "Boya eklendi.";
        public static string ColorDeleted = "Boya silindi.";
        public static string ColorUpdated = "Boya güncelendi.";
        public static string ColorListed = "Boyalar listelendi.";
        //Markalar  için hazır mesajlar
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka güncelendi.";
        public static string BrandListed = "Markalar listelendi.";
        public static string MaintenanceTime = "Sunucu bakımda";
    }
}
