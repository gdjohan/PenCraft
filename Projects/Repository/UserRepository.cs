using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Repository
{
    public class UserRepository
    {
        public static void AddUser(MsUser user)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            db.MsUsers.Add(user);
            db.SaveChanges();
        }

        public static MsUser CheckName(string name)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser user = (from x in db.MsUsers where x.UserName == name select x).FirstOrDefault();
            return user;
        }

        public static MsUser LoginUser(string name, string password)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser user = (from u in db.MsUsers where u.UserName == name && u.UserPassword == password select u).FirstOrDefault();
            return user;
        }

        public static void UpdateUser(int id, string name, DateTime dob, string gender, string address, string password, string phone)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser user = db.MsUsers.Find(id);
            user.UserName = name;
            user.UserDOB = dob;
            user.UserGender = gender;
            user.UserAddress = address;
            user.UserPassword = password;
            user.UserPhone = phone;

            db.SaveChanges();
        }
        public static MsUser GetUserById(int id)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser user = (from u in db.MsUsers where u.UserID == id select u).FirstOrDefault();
            return user;
        }
    }
}