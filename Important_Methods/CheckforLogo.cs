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
        public static List<string> getMatches(string filePath = @"C:\Users\Aryan Wadhwani\source\repos\Hack4HongKong\TestImages\blizzard.webp")
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
    }
}