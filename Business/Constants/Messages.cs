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
        public static string MaintenanceTime = "Maintenance";
        public static string TasksListed = "Tasks Listed";
        public static string TaskNameAlreadyExists = "This Title is already in use ";
        public static string AuthorizationDenied = "You are not Authorized";
        public static string UserRegistered = "Registered  ";
        public static string UserNotFound = " User not found  ";
        public static string PasswordError = " Password Error";
        public static string SuccessfulLogin = "Successful Login ";
        public static string UserAlreadyExists = " User available  ";
        public static string AccessTokenCreated = " Token Created ";
    }
}
