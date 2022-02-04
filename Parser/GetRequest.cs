using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace Parser
{
    class GetRequest
    {
        string ulr = @"https://www.simbirsoft.com/";

        public void Requiest()
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(ulr);
            List<Fields> vs = new List<Fields>();
            string ts = htmlDoc.DocumentNode.InnerText;
            string[] words = ts.Split(' ', ',', '.', '?', '"', ';', ':', '[',']', '(', ')', '\n', '\r', '\t');
            foreach (string s in words)
            {

                if (!vs.Contains(vs.Where(u => u.word == s.Trim()).FirstOrDefault()))
                {
                    vs.Add(new Fields() { word = s });

                }
                else
                {
                    vs.Where(u => u.word == s).FirstOrDefault().countword += 1;
                }

            }
            foreach (var i in vs)
            {
                Console.WriteLine(i.word +" "+ i.countword);
            }

        }



    }
}
