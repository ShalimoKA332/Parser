using System;
using HtmlAgilityPack;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вступительное задание для SimbirSoft \nВыполнил Шалимо Кирилл Александрович");
            GetRequest get = new GetRequest();
            get.Requiest();
            
        }
    }
}
