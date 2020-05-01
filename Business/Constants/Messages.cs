﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi.";
        public static string ProductDeleted= "Ürün başarıyla silindi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";

        public static string PasswordError = "Şifre hatalı.";

        public static string SuccessfulLogin = "Giriş Başarılı";

        public static string UserAlreadyExists = "Bu e-posta zaten mevcut.";

        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";

        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu.";
    }
}
