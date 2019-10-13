using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Vision.V1;
using Grpc.Auth;
using Image = Google.Cloud.Vision.V1.Image;

namespace Hack4HongKong
{
    public partial class CheckCompany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            failedAlert.Visible = false;
            image1.Visible = false;

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string path = MapPath(@"~/Logos/image.jpg");
            txtValueA.Text = "";
            if (upload.PostedFile.ContentLength > 0)
            {
                failedAlert.Visible = false;
                FileLabel.InnerText = upload.PostedFile.FileName;
                image1.Src = "Logos/image.jpg";
                image1.Visible = true;
                upload.PostedFile.SaveAs(path);
                string fileName = upload.PostedFile.FileName;
                var allCompaniesWithinPicture = CompaniesFoundInPicture(path);


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
                       "<br />"+
                        "<div class=\"panel panel-primary\">" +
                           "<div class=\"panel-heading\">" +
                               " <b>" + allCompaniesWithinPicture[x].CompanyName + "</b> " +
                           "</div>" +
                           "<div class=\"panel-body\">" +
                               " " + allCompaniesWithinPicture[x].Description + " " +
                            "</div>" +
                            "<br />"+
                            "<div class=\"panel-body\">"+
                            "<b> Alternatives: </b>" + allCompaniesWithinPicture[x].Alternatives+ " " +
                            "</div>"+
                            "</div>";



                    // mainTable.Rows.Add(tr);
                    //companyList.Items.Add(allCompanies[x].CompanyName);
                }
                if (CompaniesFoundInPicture(path).Length <= 0 && getMatches(path).Count>0) 
                {
                    var CompanyName = getMatches(path);
                    for (int i=0;i<CompanyName.Count;i++)
                    txtValueA.Text +=
                        "<div class=\"panel panel-primary\">" +
                           "<div class=\"panel-heading\">" +
                               " <b> We did not find anything about " + getMatches(path)[i] + ". We will keep you updated if any changes occur!</b> " +
                           "</div>";
                }
                if (getMatches(path).Count<=0)
                    txtValueA.Text +=
                        "<div class=\"panel panel-primary\">" +
                           "<div class=\"panel-heading\">" +
                               " <b> We could not detect a brand in the photo </b> " +
                           "</div>";
            }
            else
            {
                failedAlert.Visible = true;
            }
        }
        public List<string> getMatches(string filePath)
        {

            string path = MapPath("~/My Project 47807-3e6bf2f7f02f.json");
            //var credential = GoogleCredential.FromFile(path);
            //Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "");
            var output = new List<string>();

            //var client = ImageAnnotatorClient.Create(credential);



            GoogleCredential googleCredential;
            using (Stream m = new FileStream(path, FileMode.Open))
                googleCredential = GoogleCredential.FromStream(m);
            var channel = new Grpc.Core.Channel(ImageAnnotatorClient.DefaultEndpoint.Host,
                googleCredential.ToChannelCredentials());
            var client = ImageAnnotatorClient.Create(channel);


            var image = Image.FromFile(filePath);
            var response = client.DetectLogos(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    output.Add(annotation.Description);
            }
            return output;
        }
        public DatabaseObjectTemplate[] CompaniesFoundInPicture(string filePath)
        {
            var matches = getMatches(filePath);
            var allCompanies = DatabaseInterface.GetAllCompanies();

            List<DatabaseObjectTemplate> output = new List<DatabaseObjectTemplate>();
            for (int x = 0; x < allCompanies.Length; x++)
            {
                for (int y = 0; y < matches.Count(); y++)
                {
                    if (allCompanies[x].CompanyName.Equals(matches[y]))
                    {
                        //if it already contains is don't add it again
                        if (!output.Contains(allCompanies[x]))
                            output.Add(allCompanies[x]);
                    }

                }
            }
            return output.ToArray();
        }
    }
}