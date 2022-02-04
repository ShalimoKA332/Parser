using System;
using HtmlAgilityPack;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вступительное задание для SimbirSoft \nВыполнил: Шалимо Кирилл Александрович\nВведите url ");
            string url = Console.ReadLine();
            GetRequest get = new GetRequest();
            get.Requiest(url);

        }
    }
}
