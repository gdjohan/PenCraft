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
    public partial class UpdateProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    if (Session["user"] == null)
                    {
                        int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                        MsUser userFromCookie = UserController.GetUserById(id);
                        Session["user"] = userFromCookie;
                    }

                    MsUser user = (MsUser)Session["user"];
                    int userID = user.UserID;

                    Calendar1.Visible = false;
                    GenderRadioButton.Visible = false;

                    MsUser currUser = UserController.GetUserById(userID);

                    TBox_Name.Text = currUser.UserName;
                    Lbl_DOB.Text = currUser.UserDOB.ToString("dd/MM/yyyy");
                    Lbl_Gender.Text = currUser.UserGender;
                    TBox_Address.Text = currUser.UserAddress;
                    TBox_Password.Text = currUser.UserPassword;
                    TBox_Phone.Text = currUser.UserPhone;
                }
            }
        }

        protected void Btn_EditDOB_Click(object sender, EventArgs e)
        {
            Btn_EditDOB.Visible = false;
            Calendar1.Visible = true;
        }

        protected void Btn_EditGender_Click(object sender, EventArgs e)
        {
            Btn_EditGender.Visible = false;
            GenderRadioButton.Visible = true;
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];

            int id = user.UserID;
            string name = TBox_Name.Text;
            DateTime dob = Convert.ToDateTime(Lbl_DOB.Text);
            string gender = Lbl_Gender.Text;
            string address = TBox_Address.Text;
            string password = TBox_Password.Text;
            string phone = TBox_Phone.Text;

            Lbl_Status.Text = UserController.UpdateUser(id, name, dob, gender, address, password, phone);

            if (Lbl_Status.Text == "User profile has been updated")
            {
                Response.Redirect("~/View/UpdateProfilePage.aspx");
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Lbl_DOB.Text = Calendar1.SelectedDates[0].ToString("dd/MM/yyyy");
        }

        protected void GenderRadioButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lbl_Gender.Text = GenderRadioButton.SelectedValue;
        }
    }
}