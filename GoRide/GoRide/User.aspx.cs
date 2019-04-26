using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GoRide
{
    public partial class User : System.Web.UI.Page
    {
        Model model = new Model();

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            model.User_Name = txtName.Text;
            model.User_UserID = txtUserID.Text;
            model.User_Password = txtPassword.Text;
            model.User_Age =Convert.ToInt32( txtAge.Text);
            if (rdbMale.Checked == true)
                model.User_Gender = "Male";
            if (rdbFemale.Checked == true)
                model.User_Gender = "Female";
            model.User_Phone = Convert.ToInt32(txtPhone.Text);
            model.User_Address = txtAddress.Text;
           
        }

       
    }
}
