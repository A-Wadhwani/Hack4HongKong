﻿using System;
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
            SendMail("kade", "Google", "IT WORKS");
            //AddCompany("Facebook", "Other Description", new string[] { "tag1", "tag2" });
        }
        private void AddCompany(string companyName, string description, string[] tags)
        {
            DatabaseInterface.CreateNewCompany(companyName, description, tags);
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

            AddCompany(companyNameTxtBox.Text, descTextBox.Text, null);
            companyNameTxtBox.Text = String.Empty;
            descTextBox.Text = String.Empty;
        }

        private void SendMail(string recipientName, string company, string desc)
        {
            string filename = Server.MapPath("~/EmailVerification/Event.html");
            string mailbody = System.IO.File.ReadAllText(filename);
            mailbody = mailbody.Replace("##RecipientName##", recipientName);
            mailbody = mailbody.Replace("##Company##", company);
            mailbody = mailbody.Replace("##Description##", desc);


            string to = "kab@gmalia.com";
            string from = "YouEmailID@gmail.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Auto Response Email";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            System.Net.NetworkCredential basicCredential = new System.Net.NetworkCredential("YouEmailID@gmail.com", "Password");
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
        }
    }
}