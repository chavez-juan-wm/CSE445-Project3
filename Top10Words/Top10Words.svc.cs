using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;

namespace Top10Words
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Top10words : ITop10Words
    {
        public string[] Top10Words(string url)
        {
            Web2String.ServiceClient webService = new Web2String.ServiceClient();
            string html = webService.GetWebContent(url);

            var regexCss = new Regex("(\\<script(.+?)\\</script\\>)|(\\<style(.+?)\\</style\\>)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
            html = regexCss.Replace(html, " ");
            html = Regex.Replace(html, "<.*?>", " ");
            html = Regex.Replace(html, @"^\s+$[\r\n]*", "", RegexOptions.Multiline);
            html = html.Replace("\r", " ");
            html = html.Replace("\n", " ");
            html = html.Replace("\t", " ");
            html = html.Replace("&nbsp;", " ");
            html = Regex.Replace(html, "<.*?>", " ");
            html = Regex.Replace(html, @"\s+", " ");

            var words = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
            var wordPattern = new Regex(@"\w+");

            foreach (Match match in wordPattern.Matches(html))
            {
                int currentCount = 0;
                words.TryGetValue(match.Value, out currentCount);

                currentCount++;
                words[match.Value] = currentCount;
            }

            var myList = words.ToList();
            myList.Sort((x, y) => y.Value.CompareTo(x.Value));

            string[] top10 = { myList[0].Key, myList[1].Key, myList[2].Key, myList[3].Key, myList[4].Key, myList[5].Key, myList[6].Key, myList[7].Key, myList[8].Key, myList[9].Key};

            return top10;
        }
    }
}
