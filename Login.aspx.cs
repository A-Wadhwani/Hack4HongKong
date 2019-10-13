using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hack4HongKong
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            if (inputEmail.Value.ToString().Equals("h4hk@gmail.com") && inputPassword.Value.ToString().Equals("mhacks12"))
            {
                //redirect to access page
            }
            else
            {
                inputPassword.Attributes.Clear();
                inputPassword.Attributes.Add("class", "form-control is-invalid");
            }
        }
    }
}