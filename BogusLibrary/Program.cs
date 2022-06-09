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

        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("                                           Client                                           ");
        Console.WriteLine("--------------------------------------------------------------------------------------------");

        foreach (var client in clientes)
        {
            Console.WriteLine(string.Format("Id: {0}", client.Id.ToString()));
            Console.WriteLine(string.Format("Name: {0}  Address: {1}  Birthday: {2}", client.Name.ToString().PadRight(31, ' '), client.Address.ToString().PadRight(31, ' '), client.Birthday.ToString().Substring(1,10).PadRight(17, ' ')));
            Console.WriteLine(string.Format("Email: {0}  City: {1}  Active: {2}", client.Email.ToString().PadRight(30, ' '), client.City.ToString().PadRight(34, ' '), client.Active.ToString().PadRight(5, ' ')));
            Console.WriteLine(string.Format("Father's Name: {0} ZipCode: {1}  Salary: {2}", client.FatherName.ToString().PadRight(23, ' '), client.ZipCode.ToString().PadRight(31, ' '), client.Salary.ToString().PadRight(20, ' ')));
            Console.WriteLine(string.Format("Mother's Name: {0}  Phone: {1}", client.MotherName.ToString().PadRight(22, ' '), client.Phone.ToString().PadRight(20, ' ')));
            //Console.WriteLine(cli.Gender);
            Console.WriteLine("");
        }
        Console.ReadLine();
    }
}