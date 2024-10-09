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
    public partial class UpdateStationeryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string ID = Request.QueryString["ID"];

                if (string.IsNullOrEmpty(ID))
                {
                    Response.Redirect("~/View/HomePage.aspx");
                }

                MsStationery oldStationery = StationeryController.GetStationery(Convert.ToInt32(ID));
                TBox_Name.Text = oldStationery.StationeryName;
                TBox_Price.Text = oldStationery.StationeryPrice.ToString();
            }
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["ID"];
            string name = TBox_Name.Text;
            string price = TBox_Price.Text;

            Lbl_Status.Text = StationeryController.UpdateStationery(Convert.ToInt32(id), name, price);

            if (Lbl_Status.Text == "Stationery updated successfully")
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }
    }
}