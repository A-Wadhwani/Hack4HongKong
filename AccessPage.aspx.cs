using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hack4HongKong
{
    public partial class AccessPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            var allData = DatabaseInterface.GetAllCompanies();
            txtValueA.Text = String.Empty;
            for (int x = 0; x < allData.Length; x++)
            {
                if (allData[x].Approved == false)
                {
                    txtValueA.Text +=
                       "<div class=\"card\">" +
                           "<div class=\"card bg-primary text-white\">" +
                               " <b>" + allData[x].CompanyName + "</b> " +
                           "</div>" +
                           "<div class=\"card-body\">" +
                               " " + allData[x].Description + " " +
                            "</div>" +
                           "<div class=\"card-body\"> " +
                               "<button onclick=\"UpdateDataBase(" + allData[x].CompanyID + ")\" >Insert Addition</button>" +//"<asp:Button runat=\"server\" OnClick=\"Unnamed_Click\" Text=\"Accept Addition: " + allData[x].CompanyName + "\" />" +    
                            " </div>" +
                        "</div>";
                }
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var compName = btn.Text.Remove(0, btn.Text.IndexOf(":") + 2);

            var comp = DatabaseInterface.GetCompany(compName);

            DatabaseInterface.UpdateCompany(comp);
            //DatabaseInterface.CreateNewCompany(comp.CompanyName, comp.Description, new string[0], true);
        }
    }
}