using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Factory
{
    public class UserFactory
    {
        public static MsUser CreateNewUser(string name, DateTime dob, string gender, string address, string password, string phone)
        {
            MsUser newUser = new MsUser();
            newUser.UserName = name;
            newUser.UserDOB = dob;
            newUser.UserGender = gender;
            newUser.UserAddress = address;
            newUser.UserPassword = password;
            newUser.UserPhone = phone;
            newUser.UserRole = "Customer";

            return newUser;
        }
    }
}