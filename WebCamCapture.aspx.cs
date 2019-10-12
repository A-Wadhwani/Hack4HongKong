using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hack4HongKong
{
    public partial class WebCamCapture : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                img.ImageUrl = "~/Userimages/201901121048.jpeg";
            }
        }

        protected void Linkbutton1_Click(object sender, EventArgs e)
        {
            // to how Pop and calling another Page in Popup.
            string url = "/WebCam/Captureimage.aspx";
            string s = "window.open('" + url + "', 'popup_window', 'width=900,height=460,left=100,top=100,resizable=no');";
            ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
        }
    }
}