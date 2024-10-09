using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projects.Layouts
{
    public partial class Header : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Btn_Home.Visible = true;
                Btn_Login.Visible = true;
                Btn_Register.Visible = true;
                Btn_Cart.Visible = false;
                Btn_Transaction.Visible = false;
                Btn_UpdateProfile.Visible = false;
                Btn_Logout.Visible = false;
            }
            else
            {
                MsUser user = (MsUser)Session["user"];
                if (user.UserRole == "Customer")
                {
                    Btn_Home.Visible = true;
                    Btn_Login.Visible = false;
                    Btn_Register.Visible = false;
                    Btn_Cart.Visible = true;
                    Btn_Transaction.Visible = true;
                    Btn_UpdateProfile.Visible = true;
                    Btn_Logout.Visible = true;
                }
                else if (user.UserRole == "Admin")
                {
                    Btn_Home.Visible = true;
                    Btn_Login.Visible = false;
                    Btn_Register.Visible = false;
                    Btn_Cart.Visible = false;
                    Btn_Transaction.Visible = true;
                    Btn_UpdateProfile.Visible = true;
                    Btn_Logout.Visible = true;
                }
            }
        }

        protected void Btn_Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/RegisterPage.aspx");
        }

        protected void Btn_Cart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Cart/CartPage.aspx");
        }

        protected void Btn_Transaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Transaction/TransactionPage.aspx");
        }

        protected void Btn_UpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/UpdateProfilePage.aspx");
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("~/View/LoginPage.aspx");
        }
    }
}