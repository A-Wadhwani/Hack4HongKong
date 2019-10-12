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
            failedAlert.Visible = false;
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string path = MapPath(@"~/LogoImages/image.jpg");
            txtValueA.Text = "";
            if (upload.PostedFile.ContentLength > 0)
            {
                failedAlert.Visible = false;

                upload.PostedFile.SaveAs(path);
                string fileName = upload.PostedFile.FileName;
                var allCompaniesWithinPicture = Important_Methods.CheckforLogo.CompaniesFoundInPicture(path);


                for (int x = 0; x < allCompaniesWithinPicture.Length; x++)
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
                               " <b>" + allCompaniesWithinPicture[x].CompanyName + "</b> " +
                           "</div>" +
                           "<div class=\"panel-body\">" +
                               " " + allCompaniesWithinPicture[x].Description + " " +
                            "</div>" +
                        "</div>";



                    // mainTable.Rows.Add(tr);
                    //companyList.Items.Add(allCompanies[x].CompanyName);
                }
            }
            else
            {
                failedAlert.Visible = true;
            }
        }
    }
}