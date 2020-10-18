using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WordFilter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WordFilterService : IWordFilterService
    {
        public string WordFilter(string str)
        {
            string[] wordArray = str.Split(' ');
            string[] strArray = new string[wordArray.Length];
            string[] stopWords = { "a", "an", "in", "on", "the", "is", "are", "am" };
            string retStr = "";
            int i = 0;
            foreach(string word in wordArray)
            {
                bool stopfound = false;
                foreach(string stop in stopWords)
                {
                    if (word.ToLower().Equals(stop))
                    {
                        stopfound = true;
                    }
                }
                if(!stopfound)
                {
                    strArray[i] += word;
                    i++;
                }
            }
            retStr = String.Join(" ", strArray);
            return retStr;
        }

    }
}
