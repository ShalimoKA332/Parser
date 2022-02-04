using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace Parser
{
    class GetRequest
    {
        int count_uniq;
        string ulr = @"https://www.simbirsoft.com/";
        List<string> vs = new List<string>();
        public void Requiest()
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(ulr);
            string ts = htmlDoc.DocumentNode.InnerText;
            string[] words = ts.Split(' ', ',', '.', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t');
            Console.WriteLine(ts);

            foreach (string s in words)
            {
               
                if (s != "")
                {
                    vs.Add(s);
                    if (vs.Contains(s))
                        count_uniq++;
                   
                }
            }

        }
        public void GetList()
        {
            foreach (string s in vs)
            {
               
               
             
                Console.WriteLine(s + count_uniq);

            }

        }


    }
}
