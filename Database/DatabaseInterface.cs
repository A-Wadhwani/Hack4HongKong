using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hack4HongKong
{
    public class DatabaseInterface : DatabaseQueries
    {
        public static DatabaseObjectTemplate[] GetAllCompanies()
        {
            try
            {
                var response = GetData("Companies");
                object json = JsonConvert.DeserializeObject(response.Body);

                List<DatabaseObjectTemplate> output = new List<DatabaseObjectTemplate>();
                foreach (var token in ((JToken)json).Children())
                {
                    output.Add(token.ToObject<DatabaseObjectTemplate>());
                }
                //var output = ((JToken)json).ToObject<DatabaseObjectTemplate[]>();
                for(int x = output.Count() - 1; x >= 0; x--)
                    if (output[x] == null)
                        output.RemoveAt(x);

                return output.ToArray();
            }
            catch
            {
                return null;
            }
        }
        public static void CreateNewCompany(string companyName, string description, string[] tags, string alternatives, bool approved = false)
        {
            var allCompanies = GetAllCompanies();
            for (int x = 0; x < allCompanies.Length; x++)
                if (allCompanies[x].CompanyName.ToLower() == companyName.ToLower())
                    throw new Exception("Company has already been added");


            int newID = GetCurrentHighestID() + 1;
            DatabaseObjectTemplate newItem = new DatabaseObjectTemplate
            {
                CompanyName = companyName,
                Description = description,
                Tags = tags,
                CompanyID = newID,
                Approved = approved,
                Alternatives = alternatives
            };

            InsertData("Companies/" + newID, newItem);
        }
        public static void UpdateCompany(DatabaseObjectTemplate company)
        {
            UpdateData("Companies/" + company.CompanyID, company);
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
            try
            {
                for (int x = 0; x < allCompanies.Length; x++)
                {
                    if (allCompanies[x].CompanyID > maxID)
                        maxID = allCompanies[x].CompanyID;
                }
            } catch { }
            return maxID;
        }

    }
    public class DatabaseObjectTemplate
    {
        public bool Approved { get; set; }
        public string CompanyName { get; set; }
        public string Alternatives { get; set; }
        public int CompanyID { get; set; }
        public string Description { get; set; }
        public string[] Tags { get; set; }
    }
}