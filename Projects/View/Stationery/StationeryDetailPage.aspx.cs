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
    public partial class StationeryDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Pnl_AddCart.Visible = false;
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

                if (user.UserRole == "Customer")
                {
                    Pnl_AddCart.Visible = true;
                }
                else
                {
                    Pnl_AddCart.Visible = false;
                }
            }

            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];

                MsStationery oldStationery = StationeryController.GetStationery(Convert.ToInt32(id));
                Lbl_Name.Text = oldStationery.StationeryName;
                Lbl_Price.Text = oldStationery.StationeryPrice.ToString();
            }
        }

        protected void Btn_AddCart_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            int UserID = user.UserID;
            int StationeryID = Convert.ToInt32(Request.QueryString["ID"]);
            string qty = TBox_Quantity.Text;

            Lbl_Status.Text = CartController.AddNewCart(UserID, StationeryID, qty);

            if (Lbl_Status.Text == "Cart has been added")
            {
                Response.Redirect("~/View/Cart/CartPage.aspx");
            }
        }
    }
}