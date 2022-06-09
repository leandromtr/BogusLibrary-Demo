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
                .RuleFor(c => c.Email, f => f.Person.Email.ToLower())
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

        public static List<Vehicle> ListVehiclesFake(string languageCode)
        {
            var vehicleFaker = new Faker<Vehicle>(languageCode)
                .RuleFor(c => c.Vin, f => f.Vehicle.Vin())
                .RuleFor(c => c.Manufacturer, f => f.Vehicle.Manufacturer())
                .RuleFor(c => c.Model, f => f.Vehicle.Model())
                .RuleFor(c => c.Type, f => f.Vehicle.Type())
                .RuleFor(c => c.Fuel, f => f.Vehicle.Fuel());
            var vehicles = vehicleFaker.Generate(10);
            return vehicles;
        }

        //Vehicle
    }
}
