using Projects.Handler;
using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Projects.Controller
{
    public class UserController
    {
        public static String RegisterUser(string name, DateTime dob, string gender, string address, string password, string phone)
        {
            if (string.IsNullOrEmpty(name) || dob == default(DateTime) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phone))
            {
                return "All fields must be filled";
            }
            else if (name.Length < 5 || name.Length > 50)
            {
                return "Name must be between 5 and 50 characters";
            }
            else if (CalculateAge(dob) < 1)
            {
                return "User must be at least 1 year old";
            }
            else if (!IsAlphanumeric(password))
            {
                return "Password must be alphanumeric";
            }

            return UserHandler.CreateNewUser(name, dob, gender, address, password, phone);
        }

        public static int CalculateAge(DateTime dob)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;

            if (dob.Month > today.Month || (dob.Month == today.Month && dob.Day > today.Day))
            {
                age--;
            }

            return age;
        }

        public static bool IsAlphanumeric(string password)
        {
            Regex letterRegex = new Regex("[a-zA-Z]");
            Regex numberRegex = new Regex("[0-9]");
            return letterRegex.IsMatch(password) && numberRegex.IsMatch(password);
        }

        public static String LoginUser(string name, string password)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                return "All fields must be filled";
            }

            MsUser loginUser = UserHandler.LoginUser(name, password);

            if (loginUser == null)
            {
                return "This account has not been registered";
            }
            else
            {
                return "Login Success";
            }
        }

        public static String UpdateUser(int id, string name, DateTime dob, string gender, string address, string password, string phone)
        {
            if(string.IsNullOrEmpty(name) || dob == default(DateTime) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phone))
            {
                return "All fields must be filled";
            }
            else if (name.Length < 5 || name.Length > 50)
            {
                return "Name must be between 5 and 50 characters";
            }
            else if (CalculateAge(dob) < 1)
            {
                return "User must be at least 1 year old";
            }
            else if (!IsAlphanumeric(password))
            {
                return "Password must be alphanumeric";
            }
            return UserHandler.UpdateUser(id, name, dob, gender, address, password, phone);
        }

        public static MsUser GetUser(string name, string password)
        {
            MsUser loginUser = UserHandler.LoginUser(name, password);
            return loginUser;
        }

        public static MsUser GetUserById(int id)
        {
            return UserHandler.GetUserById(id);
        }
    }
}