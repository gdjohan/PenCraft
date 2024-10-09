using Projects.Controller;
using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projects.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            string name = TBox_Name.Text;
            string password = TBox_Password.Text;
            Boolean isRemember = CBox_RememberMe.Checked;

            Lbl_Status.Text = UserController.LoginUser(name, password);

            if (Lbl_Status.Text == "Login Success")
            {
                MsUser loginUser = UserController.GetUser(name, password);
                Session["user"] = loginUser;

                if (isRemember == true)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = loginUser.UserID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(4);
                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected void LinkBtn_ToRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/RegisterPage.aspx");
        }
    }
}