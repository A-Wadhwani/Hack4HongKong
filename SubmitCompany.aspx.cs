using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hack4HongKong
{
    public partial class SubmitCompany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
    }
}