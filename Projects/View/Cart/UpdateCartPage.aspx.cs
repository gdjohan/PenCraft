using Projects.Controller;
using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projects.View.Cart
{
    public partial class UpdateCartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string stationeryID = Request.QueryString["ID"];

                if (string.IsNullOrEmpty(stationeryID))
                {
                    Response.Redirect("~/View/Cart/CartPage.aspx");
                }

                MsUser user = (MsUser)Session["user"];
                int userID = user.UserID;

                MsStationery stationery = StationeryController.GetStationery(Convert.ToInt32(stationeryID));
                Lbl_Name.Text = stationery.StationeryName;
                Lbl_Price.Text = stationery.StationeryPrice.ToString();
                TBox_Qty.Text = CartController.GetQty(userID, Convert.ToInt32(stationeryID)).ToString();
            }
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            int userID = user.UserID;
            int stationeryID = Convert.ToInt32(Request.QueryString["ID"]);
            string qty = TBox_Qty.Text;

            Lbl_Status.Text = CartController.UpdateCart(userID, stationeryID, qty);

            if (Lbl_Status.Text.Equals("Cart has been updated"))
            {
                Response.Redirect("~/View/Cart/CartPage.aspx");
            }
        }
    }
}