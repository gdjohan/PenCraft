using Projects.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projects.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            string name = TBox_Name.Text;
            DateTime dob = Calendar1.SelectedDate;
            string gender = GenderRadioButton.SelectedValue;
            string address = TBox_Address.Text;
            string password = TBox_Password.Text;
            string phone = TBox_Phone.Text;

            Lbl_Status.Text = UserController.RegisterUser(name, dob, gender, address, password, phone);
        }

        protected void LinkBtn_ToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/LoginPage.aspx");
        }
    }
}