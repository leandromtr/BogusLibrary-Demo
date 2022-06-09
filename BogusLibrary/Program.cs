using Bogus;
using BogusLibrary;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fake data generator");
        Console.WriteLine("1 - English");
        Console.WriteLine("2 - French");
        Console.WriteLine("3 - Spanish");
        Console.WriteLine("4 - Portuguese");
        Console.WriteLine("5 - Italian");
        Console.WriteLine("6 - Turkish");
        Console.WriteLine("7 - German");
        Console.WriteLine("");
        Console.WriteLine("Choose the Language:");
        var code =  Console.ReadLine();

        var languageCode = string.Empty;
        if (code == "1") languageCode = "en_US";
        if (code == "2") languageCode = "fr";
        if (code == "3") languageCode = "es";
        if (code == "4") languageCode = "pt_BR";
        if (code == "5") languageCode = "it";
        if (code == "6") languageCode = "tr";
        if (code == "7") languageCode = "de";

        if (string.IsNullOrEmpty(languageCode))
            languageCode = "en_US";


        Console.Clear();

        var clientes = FakeData.ListClientsFake(languageCode);

        foreach (var cli in clientes)
        {

            Console.WriteLine(cli.Id);
            Console.WriteLine(cli.Name);
            Console.WriteLine(cli.FatherName);
            Console.WriteLine(cli.MotherName);
            Console.WriteLine(cli.Email);
            Console.WriteLine(cli.Phone);
            Console.WriteLine(cli.Address);
            Console.WriteLine(cli.ZipCode);
            Console.WriteLine(cli.City);
            Console.WriteLine(cli.Birthday);
            //Console.WriteLine(cli.Gender);
            Console.WriteLine(cli.Active);
            Console.WriteLine(cli.Salary);
            Console.WriteLine("");
        }
        Console.ReadLine();
    }
}