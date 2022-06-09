using Bogus;
using BogusLibrary;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        var clientes = FakeData.ListClientsFake();

        foreach (var cli in clientes)
        {
            Console.WriteLine(cli.Id);
            Console.WriteLine(cli.Name);
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