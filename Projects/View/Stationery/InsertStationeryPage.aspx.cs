using Projects.Controller;
using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projects.View.Stationery
{
    public partial class InsertStationeryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
            else
            {
                if (Session["user"] == null)
                {
                    int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    MsUser userFromCookie = UserController.GetUserById(id);
                    Session["user"] = userFromCookie;
                }

                MsUser user = (MsUser)Session["user"];

                if (user.UserRole.Equals("Customer"))
                {
                    Response.Redirect("~/View/HomePage.aspx");
                }
            }
        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            string name = TBox_Name.Text;
            string price = TBox_Price.Text;

            Lbl_Status.Text = StationeryController.CreateNewStationery(name, price);

            if (Lbl_Status.Text == "Stationery added successfully")
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }
    }
}