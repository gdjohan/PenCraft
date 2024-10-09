using Projects.Controller;
using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projects.View.Cart
{
    public partial class CartPage : System.Web.UI.Page
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

                if (user.UserRole.Equals("Admin"))
                {
                    Response.Redirect("~/View/HomePage.aspx");
                }

                if (!IsPostBack)
                {
                    int userID = user.UserID;

                    List<Object> listCarts = CartController.GetAllCarts(userID);

                    if (listCarts.Count == 0)
                    {
                        Lbl_CartAmount.Text = "Cart is empty";
                        Pnl_Checkout.Visible = false;
                    }
                    else
                    {
                        Pnl_Checkout.Visible = true;
                        GV_Cart.DataSource = listCarts;
                        GV_Cart.DataBind();
                    }
                }
            }
        }

        protected void UpdateCart(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GV_Cart.Rows[e.NewEditIndex];
            string name = row.Cells[0].Text;
            int price = Convert.ToInt32(row.Cells[1].Text);
            int stationeryID = CartController.GetCartStationeryID(name, price);
            Response.Redirect("~/View/Cart/UpdateCartPage.aspx?ID=" + stationeryID);
        }

        protected void RemoveCart(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GV_Cart.Rows[e.RowIndex];
            string name = row.Cells[0].Text;
            int price = Convert.ToInt32(row.Cells[1].Text);
            int qty = Convert.ToInt32(row.Cells[2].Text);

            MsUser user = (MsUser)Session["user"];
            int userID = user.UserID;

            CartController.RemoveCart(userID, name, price, qty);
            Response.Redirect("~/View/Cart/CartPage.aspx");
        }

        protected void Btn_Checkout_Click(object sender, EventArgs e)
        {
            // Add new transaction
            MsUser user = (MsUser)Session["user"];
            int userID = user.UserID;
            DateTime transactionDate = DateTime.Now;
            TransactionController.AddNewTransaction(userID, transactionDate);

            // Add all cart items into transaction detail
            int transactionID = TransactionController.GetTransactionID();
            Lbl_TransactionID.Text = transactionID.ToString();

            TransactionDetailController.AddNewTransactionDetail(userID, transactionID);

            // Remove all of the user's cart
            CartController.RemoveAllCart(userID);

            Response.Redirect("~/View/HomePage.aspx");
        }
    }
}