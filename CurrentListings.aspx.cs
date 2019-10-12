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
            for (int x = 0; x < allCompanies.Length; x++)
            {
                TableRow tr = new TableRow();

                TableCell nameCell = new TableCell();
                nameCell.Text = allCompanies[x].CompanyName;
                tr.Cells.Add(nameCell);


                tr.Cells.Add(new TableCell());

                TableCell descCell = new TableCell();
                descCell.Text = allCompanies[x].Description;
                tr.Cells.Add(descCell);


                mainTable.Rows.Add(tr);
            }
            //companyList.Items.Add();
        }
    }
}