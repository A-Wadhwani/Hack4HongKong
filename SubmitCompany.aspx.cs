using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hack4HongKong
{
    public partial class SubmitCompany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            successAlert.Visible = false;
            //SendMail("kade", "Google", "IT WORKS");
            //AddCompany("Facebook", "Other Description", new string[] { "tag1", "tag2" });
        }
        private void AddCompany(string companyName, string description, string[] tags, string alternative)
        {
            DatabaseInterface.CreateNewCompany(companyName, description, tags, alternative);
        }

        protected void addTagToListBox_Click(object sender, EventArgs e)
        {
            tagListBox.Items.Add(tagSubmissionTextBox.Text);
        }

        protected void removeTagFromListBox_Click(object sender, EventArgs e)
        {
            tagListBox.Items.RemoveAt(tagListBox.SelectedIndex);
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            /*List<string> tags = new List<string>();
            foreach(ListItem item in tagListBox.Items)
            {
                tags.Add(item.Text);
            }*/

            AddCompany(companyNameTxtBox.Text, descTextBox.Text, null, alternativeTxtBox.Text);
            companyNameTxtBox.Text = String.Empty;
            descTextBox.Text = String.Empty;
            successAlert.Visible = true;
        }
        /*
        private void SendMail(string recipientName, string company, string desc)
        {
            var comp = DatabaseInterface.GetCompany(company);

            string filename = Server.MapPath("~/EmailVerification/Event.html");
            string mailbody = System.IO.File.ReadAllText(filename);
            mailbody = mailbody.Replace("##RecipientName##", recipientName);
            mailbody = mailbody.Replace("##Company##", company);
            mailbody = mailbody.Replace("##Description##", desc);
            mailbody = mailbody.Replace("<input type=\"hidden\" id=\"compID\" value=\"1\">", String.Format("<input type=\"hidden\" id=\"compID\" value=\"{0}\">", comp.CompanyID));


            string to = "kadetkd15@gmail.com";
            string from = "mhacksproject2019@gmail.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Auto Response Email";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            System.Net.NetworkCredential basicCredential = new System.Net.NetworkCredential(from, "Mhacks_2019abc");
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential;
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
            }
        }*/
    }
}