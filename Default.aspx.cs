using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Cloud.Vision.V1;
using Image = Google.Cloud.Vision.V1.Image;
using Page = System.Web.UI.Page;

namespace Hack4HongKong
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Aryan Wadhwani\source\repos\Hack4HongKong\TestImages\blizzard.webp";
            var image = Image.FromFile(filePath);
            var client = ImageAnnotatorClient.Create();
            var response = client.DetectLogos(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    Console.WriteLine(annotation.Description);
            }
        }
    }
}