using CrystalDecisions.Web;
using Projects.Controller;
using Projects.Datasets;
using Projects.Model;
using Projects.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projects.View.Transaction
{
    public partial class TransactionReportPage : System.Web.UI.Page
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
                    Response.Redirect("~/View/TransactionPage.aspx");
                }

                var listTransactions = TransactionController.GetAllTransactions();

                if (listTransactions.Count == 0)
                {
                    Lbl_TransactionAmount.Text = "No transaction yet";
                }
                else
                {
                    // 1 buat CrystalReport
                    var report = new CrystalReport1();

                    // untuk nampung data
                    var datasets = new ReportDataSet();

                    var header = datasets.Transactions;
                    var detail = datasets.TransactionDetails;

                    var transactions = TransactionController.GetAllTransactions();

                    // masukin datanya satu-satu
                    foreach (var transaction in transactions)
                    {
                        // buat baris header baru
                        var newHeader = header.NewRow();

                        // masukin datanya
                        newHeader["TransactionId"] = transaction.TransactionId;
                        newHeader["UserId"] = transaction.UserID;
                        newHeader["TransactionDate"] = transaction.TransactionDate;
                        newHeader["GrandTotalValue"] = transaction.GrandTotal;
        
                        header.Rows.Add(newHeader);

                        foreach (var transactionDetail in transaction.TransactionDetails)
                        {
                            var newDetail = detail.NewRow();
                            newDetail["TransactionId"] = transactionDetail.TransactionID;
                            newDetail["StationeryName"] = transactionDetail.StationeryName;
                            newDetail["Quantity"] = transactionDetail.Quantity;
                            newDetail["StationeryPrice"] = transactionDetail.StationeryPrice;
                            newDetail["SubTotalValue"] = transactionDetail.SubTotal;

                            detail.Rows.Add(newDetail);
                        }
                    }

                    report.SetDataSource(datasets);
                    CrystalReportViewer1.ReportSource = report;
                    CrystalReportViewer1.DataBind();
                }
            }
        }
    }
}