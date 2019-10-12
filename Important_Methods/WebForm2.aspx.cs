using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hack4HongKong.Important_Methods
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            fileup.PostedFile.SaveAs(@"C:\Users\Aryan Wadhwani\source\repos\Hack4HongKong\TestImages\hello.jpg");
            string s = Important_Methods.CheckforLogo.getMatches(@"C:\Users\Aryan Wadhwani\source\repos\Hack4HongKong\TestImages\hello.jpg")[0];
        }
    }
}