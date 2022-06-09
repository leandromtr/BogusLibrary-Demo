using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogusLibrary
{
    public class FakeData
    {
        public static List<Client> ListClientsFake(string languageCode)
        {
            var clientFaker = new Faker<Client>(languageCode)
                .RuleFor(c => c.Id, f => f.IndexFaker)
                .RuleFor(c => c.Name, f => f.Person.FullName)
                .RuleFor(c => c.FatherName, f => f.Name.FullName(Bogus.DataSets.Name.Gender.Male))
                .RuleFor(c => c.MotherName, f => f.Name.FullName(Bogus.DataSets.Name.Gender.Female))
                .RuleFor(c => c.Email, f => f.Person.Email)
                .RuleFor(c => c.Phone, f => f.Person.Phone)
                .RuleFor(c => c.Address, f => f.Person.Address.Street)
                .RuleFor(c => c.ZipCode, f => f.Person.Address.ZipCode)
                .RuleFor(c => c.City, f => f.Person.Address.City)
                .RuleFor(c => c.Birthday, f => f.Person.DateOfBirth.Date)
                //.RuleFor(c => c.Gender, f => f.PickRandom(new string[] { "male", "femine" }))
                .RuleFor(c => c.Active, f => f.PickRandomParam(new bool[] { true, true, false }))
                .RuleFor(o => o.Salary, f => f.Random.Int(1000, 3000));
            var clientes = clientFaker.Generate(5);
            return clientes;
        }

        //public static List<Client> ListCompaniesFake()
        //{
        //    var clientFaker = new Faker<Client>()
        //        .RuleFor(c => c.Id, f => f.IndexFaker)
        //        .RuleFor(c => c.Name, f => f.Company.)
        //        .RuleFor(c => c.Email, f => f.Internet.Email(f.Person.FirstName).ToLower())
        //        .RuleFor(c => c.Phone, f => f.Person.Phone)
        //        .RuleFor(c => c.Address, f => f.Address.StreetAddress())
        //        .RuleFor(c => c.ZipCode, f => f.Address.ZipCode())
        //        .RuleFor(c => c.City, f => f.Address.City())
        //        .RuleFor(c => c.State, f => f.Address.State())
        //        .RuleFor(c => c.Country, f => f.Internet.Country())
        //        .RuleFor(c => c.Birthday, f => f.Date.Recent(100))
        //        .RuleFor(c => c.Sex, f => f.PickRandom(new string[] { "male", "femine" }))
        //        .RuleFor(c => c.Active, f => f.PickRandomParam(new bool[] { true, true, false }))
        //        .RuleFor(o => o.Salary, f => f.Random.Decimal(500, 2000));
        //    var clientes = clientFaker.Generate(10);
        //    return clientes;
        //}

        //Vehicle
    }
}
