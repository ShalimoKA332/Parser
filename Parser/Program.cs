using System;
using HtmlAgilityPack;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetRequest get = new GetRequest();
            get.Requiest();
            get.GetList();
        }
    }
}
