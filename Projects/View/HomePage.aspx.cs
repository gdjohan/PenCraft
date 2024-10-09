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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GV_StationeryList.DataSource = StationeryController.GetAllStationeries();
            GV_StationeryList.DataBind();

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Pnl_StationeryOperation.Visible = false;
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

                if (user.UserRole == "Admin")
                {
                    Pnl_StationeryOperation.Visible = true;
                }
                else
                {
                    Pnl_StationeryOperation.Visible = false;
                }

                //Lbl_Hello.Text = "Hello, " + user.Username;

                //if (Application["user_count"] != null)
                //{
                //    Lbl_TotalOnline.Text = Application["user_count"].ToString() + " Total Users Online";
                //}*/

                GV_Stationery.DataSource = StationeryController.GetAllStationeries();
                GV_Stationery.DataBind();
            }
        }
        protected void SeeDetail(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GV_StationeryList.Rows[e.NewEditIndex];
            string id = row.Cells[1].Text;
            Response.Redirect("~/View/Stationery/StationeryDetailPage.aspx?ID=" + id);
        }

        protected void UpdateStationery(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GV_Stationery.Rows[e.NewEditIndex];
            string id = row.Cells[1].Text;
            Response.Redirect("~/View/Stationery/UpdateStationeryPage.aspx?ID=" + id);
        }

        protected void DeleteStationery(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GV_Stationery.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[1].Text);
            StationeryController.DeleteStationery(id);
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Stationery/InsertStationeryPage.aspx");
        }
    }
}