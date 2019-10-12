using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudTestApp
{
    public class DatabaseInterface : DatabaseQueries
    {
        public static DatabaseObjectTemplate[] GetAllCompanies()
        {
            
            var response = GetData("Companies");
            object json = JsonConvert.DeserializeObject(response.Body);

            var output = ((JToken)json).ToObject<DatabaseObjectTemplate[]>();

            return output;
        }
        public static void CreateNewCompany(string companyName, string description, string[] tags)
        {
            int newID = GetCurrentHighestID() + 1;
            DatabaseObjectTemplate newItem = new DatabaseObjectTemplate
            {
                CompanyName = companyName,
                Description = description,
                Tags = tags,
                CompanyID = newID
            };

            InsertData("Companies/" + newItem.CompanyID, newItem);
        }

        public static void DeleteCompany(int companyID)
        { 
            DeleteData("Companies/" + companyID);
        }
        public static DatabaseObjectTemplate GetCompany(string companyName)
        {
            var allCompanies = GetAllCompanies();
            for (int x = 0; x < allCompanies.Length; x++)
            {
                if (companyName == allCompanies[x].CompanyName)
                    return allCompanies[x];
            }
            return null;
        }
        public static DatabaseObjectTemplate GetCompany(int companyID)
        {
            var allCompanies = GetAllCompanies();
            for (int x = 0; x < allCompanies.Length; x++)
            {
                if (companyID == allCompanies[x].CompanyID)
                    return allCompanies[x];
            }
            return null;
        }
        public static DatabaseObjectTemplate[] GetCompaniesWithTags(string[] tags)
        {
            List<DatabaseObjectTemplate> output = new List<DatabaseObjectTemplate>();
            var allCompanies = GetAllCompanies();
            for (int x = 0; x < allCompanies.Length; x++)
            {
                for (int y = 0; y < allCompanies[x].Tags.Length; y++)
                {
                    if (tags.ToList().Contains(allCompanies[x].Tags[y]))
                    {
                        output.Add(allCompanies[x]);
                    }
                }
            }
            return output.ToArray();
        }
        private static int GetCurrentHighestID()
        {
            var allCompanies = GetAllCompanies();
            int maxID = 0;
            for(int x = 0; x < allCompanies.Length; x++)
            {
                if (allCompanies[x].CompanyID > maxID)
                    maxID = allCompanies[x].CompanyID;
            }
            return maxID;
        }
    }
    public class DatabaseObjectTemplate
    {
        public string CompanyName { get; set; }
        public int CompanyID { get; set; }
        public string Description { get; set; }
        public string[] Tags { get; set; }
    }
}