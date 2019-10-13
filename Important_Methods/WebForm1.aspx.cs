using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hack4HongKong.Important_Methods
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void snap_Click(object sender, EventArgs e)
        {
            String s = myimage.Src;
            s = s.Replace("..", "~");
            //string s1 = Important_Methods.CheckforLogo.getMatches(s)[0];
        }
    }
}