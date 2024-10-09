using Projects.Factory;
using Projects.Model;
using Projects.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Handler
{
    public class UserHandler
    {
        public static String CreateNewUser(string name, DateTime dob, string gender, string address, string password, string phone)
        {
            MsUser checkUser = UserRepository.CheckName(name);

            if (checkUser != null)
            {
                return "Name has already taken";
            }

            MsUser newUser = UserFactory.CreateNewUser(name, dob, gender, address, password, phone);
            UserRepository.AddUser(newUser);
            return "Registration success";
        }

        public static MsUser LoginUser(string name, string password)
        {
            MsUser loginUser = UserRepository.LoginUser(name, password);
            return loginUser;
        }

        public static String UpdateUser(int id, string name, DateTime dob, string gender, string address, string password, string phone)
        {
            MsUser checkUser = UserRepository.CheckName(name);

            if (checkUser != null)
            {
                return "Name has already taken";
            }

            UserRepository.UpdateUser(id, name, dob, gender, address, password, phone);
            return "User profile has been updated";
        }

        public static MsUser GetUserById(int id)
        {
            return UserRepository.GetUserById(id);
        }
    }
}