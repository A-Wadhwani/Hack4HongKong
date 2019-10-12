using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Cloud.Vision.V1;
using Image = Google.Cloud.Vision.V1.Image;

namespace Hack4HongKong.Important_Methods
{
    public static class CheckforLogo
    {
        public static List<string> getMatches(string filePath)
        {
            var output = new List<string>();
            var image = Image.FromFile(filePath);
            var client = ImageAnnotatorClient.Create();
            var response = client.DetectLogos(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    output.Add(annotation.Description);
            }
            return output;
        }
        public static DatabaseObjectTemplate[] CompaniesFoundInPicture(string filePath)
        {
            var matches = getMatches(filePath);
            var allCompanies = DatabaseInterface.GetAllCompanies();

            List<DatabaseObjectTemplate> output = new List<DatabaseObjectTemplate>();
            for(int x = 0; x < allCompanies.Length; x++)
            {
                for(int y = 0; y < matches.Count(); y++)
                {
                    if(allCompanies[x].CompanyName == matches[y])
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