using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Html.Forms;

namespace ScraperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ScrapingBrowser browser = new ScrapingBrowser
            {
                AllowAutoRedirect = true,
                AllowMetaRedirect = true
            };

            WebPage page = browser.NavigateToPage(new Uri("https://localhost:44361/"));
            HtmlNode titleNode = page.Html.CssSelect(".navbar-brand").First();
            string PageTitle = titleNode.InnerText;

            //Console.WriteLine(PageTitle);
            //Console.ReadLine();

            List<string> Names = new List<string>();
            var Table = page.Html.CssSelect("#PersonTable").First();
            foreach(var row in Table.SelectNodes("tbody/tr"))
            {
                foreach(var cell in row.SelectNodes("td[1]"))
                {
                    Names.Add(cell.InnerText);
                }
            }
            foreach(var name in Names)
            {
                Console.WriteLine(name);
            }

            // find a form and send back data
            PageWebForm form = page.FindFormById("dataForm");
            // assign values to form fields
            form["UserName"] = "AJSON";
            form["Gender"] = "M";
            form.Method = HttpVerb.Post;
            WebPage resultsPage = form.Submit();

            Console.WriteLine(resultsPage.RawResponse.StatusCode);

            Console.ReadLine();
        }
    }
}
