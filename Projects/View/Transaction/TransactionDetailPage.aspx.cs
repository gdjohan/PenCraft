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
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ID = Request.QueryString["ID"];

            if (string.IsNullOrEmpty(ID))
            {
                Response.Redirect("~/View/HomePage.aspx");
            }

            int transactionID = Convert.ToInt32(ID);
            GV_TransactionDetail.DataSource = TransactionDetailController.GetTransactionDetailByEachCustomer(transactionID);
            GV_TransactionDetail.DataBind();
        }
    }
}