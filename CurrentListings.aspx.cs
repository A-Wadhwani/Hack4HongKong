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
            var allCompanies = SortCompanies();
            DisplayData(allCompanies);
        }
        private void DisplayData(DatabaseObjectTemplate[] data)
        {
            txtValueA.Text = "";
            for (int x = 0; x < data.Length; x++)
            {
                if (data[x].Approved == true)
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
                       "<div class=\"card\">" +
                           "<div class=\"card bg-primary text-white\">" +
                               " <b>" + data[x].CompanyName + "</b> " +
                           "</div>" +
                           "<div class=\"card-body\">" +
                               " " + data[x].Description + " " +
                            "</div>" +
                        "</div>";



                    // mainTable.Rows.Add(tr);
                    //companyList.Items.Add(allCompanies[x].CompanyName);
                }
            }
        }
        private DatabaseObjectTemplate[] SortCompanies(string name)
        {
            var allCompanies = DatabaseInterface.GetAllCompanies();

            if (name == null)
                return allCompanies;

            name = name.Trim().ToLower();

            ListClassHolder[] lists = new ListClassHolder[8];
            
            for(int x = 0; x < lists.Length; x++)
                lists[x] = new ListClassHolder();

            for (int x = 0; x < allCompanies.Length; x++)
            {
                string compName = allCompanies[x].CompanyName.ToLower();

                if (compName == name)
                {
                    lists[0].output.Add(allCompanies[x]);
                }
                else if(compName.Contains(name))
                {
                    lists[1].output.Add(allCompanies[x]);
                }
                else if(name.Contains(compName))
                {
                    lists[2].output.Add(allCompanies[x]);
                }
                else if (compName.Contains(name.Remove(name.Length / 2)))
                {
                    lists[3].output.Add(allCompanies[x]);
                }
                else if (name.Contains(compName.Remove(compName.Length / 2)))
                {
                    lists[4].output.Add(allCompanies[x]);
                }
                else if (compName.Contains(name.Remove(0, name.Length / 2)))
                {
                    lists[5].output.Add(allCompanies[x]);
                }
                else if (name.Contains(compName.Remove(0, compName.Length / 2)))
                {
                    lists[6].output.Add(allCompanies[x]);
                }
                else
                {
                    lists[7].output.Add(allCompanies[x]);
                }
            }

            List<DatabaseObjectTemplate> mainOutput = new List<DatabaseObjectTemplate>();
            for(int x = 0; x < lists.Length; x++)
            {
                mainOutput.AddRange(lists[x].output);
            }
            for (int x = 0; x < mainOutput.Count(); x++)
                if (mainOutput[x] == null)
                    mainOutput.RemoveAt(x);

            return mainOutput.ToArray();
        }
        private DatabaseObjectTemplate[] SortCompanies()
        {
            return SortCompanies(null);
        }
        private class ListClassHolder
        {
            public List<DatabaseObjectTemplate> output = new List<DatabaseObjectTemplate>();
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            string s = searchTextBox.Text;
            if (String.IsNullOrWhiteSpace(s))
                s = null;

            var comps = SortCompanies(s);
            DisplayData(comps);
        }
    }
}