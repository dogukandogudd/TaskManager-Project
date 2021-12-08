using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string TaskAdded = "Task Added";
        public static string TaskTitleInvalid = "Task Title Invalid";
        public static string MaintenanceTime="bakım";
        public static string TasksListed="taskslisted";
        public static string TaskNameAlreadyExists="Bu başlık zaten kullanılıyor";
        public static string  AuthorizationDenied="yetkinyok";
        public static string UserRegistered="kayıt oldu  ";
        public static string UserNotFound = " kullanıcı bulunamdaı ";
        public static string PasswordError = " parola hatası";
        public static string SuccessfulLogin = " başarılı giriş ";
        public static string UserAlreadyExists = " kullanıcı mevcut ";
        public static string AccessTokenCreated = " token oluşturuldu ";
    }
}
