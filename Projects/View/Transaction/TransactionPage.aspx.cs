using Projects.Controller;
using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projects.View.Transaction
{
    public partial class TransactionPage : System.Web.UI.Page
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
                    Response.Redirect("~/View/Transaction/TransactionReportPage.aspx");
                }

                int userID = user.UserID;
                List<object> listTransactions = TransactionController.GetTransactionByEachUser(userID);

                if (listTransactions.Count == 0)
                {
                    Lbl_TransactionAmount.Text = "No transaction yet";
                }
                else
                {
                    GV_Transaction.DataSource = listTransactions;
                    GV_Transaction.DataBind();
                }
            }
        }

        protected void SeeDetail(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GV_Transaction.Rows[e.NewEditIndex];
            string transactionID = row.Cells[0].Text;
            Response.Redirect("~/View/Transaction/TransactionDetailPage.aspx?ID=" + transactionID);
        }
    }
}