using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hack4HongKong
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseInterface.ConnectToDatabase();

            string[] tags = { "tag1", "tag2", "tag3" };
            DatabaseInterface.CreateNewCompany("Google", "This is the description", tags);
        }
    }
}