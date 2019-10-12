using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hack4HongKong
{
    public partial class CurrentListings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var allCompanies = DatabaseInterface.GetAllCompanies();
            txtValueA.Text = "";
            for (int x = 0; x < allCompanies.Length; x++)
            {
                /*TableRow tr = new TableRow();

                TableCell nameCell = new TableCell();
                nameCell.Text = allCompanies[x].CompanyName;
                tr.Cells.Add(nameCell);


                tr.Cells.Add(new TableCell());

                TableCell descCell = new TableCell();
                descCell.Text = allCompanies[x].Description;
                tr.Cells.Add(descCell);*/



                //protected string companyName = allCompanies[x].CompanyName;
                txtValueA.Text +=
                   "<div class=\"panel panel-primary\">" +
                       "<div class=\"panel-heading\">" +
                           " " + allCompanies[x].CompanyName + " " +
                       "</div>" +
                       "<div class=\"panel-body\">" +
                           " "+ allCompanies[x].Description + " " +
                        "</div>" +
                    "</div>";



               // mainTable.Rows.Add(tr);
                //companyList.Items.Add(allCompanies[x].CompanyName);
            }
            
        }
    }
}