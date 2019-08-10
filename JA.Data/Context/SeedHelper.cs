using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JA.Data.Context;
using JA.Models.BlogModels.Food;
using JA.Models.CustomerModels;

namespace NinjaDomain.DataModel
{
    public class DataHelpers
    {
        public static void NewDbWithSeed()
        {

           // Database.SetInitializer(new DropCreateDatabaseAlways<BlogContext>());
            using (var context = new BlogContext())
            {
                if (context.Customers.Any())
                {
                    return;
                }
                var vtClan = context.Customers.Add(new GoGirlCustomer { FirstName = "Vermont Clan" });
                var turtleClan = context.Customers.Add(new GoGirlCustomer { FirstName = "Turtles" });
                var amClan = context.Customers.Add(new GoGirlCustomer { FirstName = "American Ninja Warriors" });

                var j = new GoGirlCustomer
                {
                    FirstName = "JulieSan",
                    LastName = "Wallace",
                    DateOfBirth = new DateTime(1980, 1, 1),
                    //Foodlogs = new List<Foodlog>(
                    //{
                    //    Foodlog = new Foodlog
                    //    {
                    //        Id = 1,
                    //        DateCreated = DateTime.Now,
                    //        DateModified = DateTime.Now,
                    //        IsDirty = false,
                    //        Food =  new List<Food>(
                    //        {
                    //            new Food
                    //            {

                    //            }
                    //        })
                    //    }
                    //})

                };
            //    var s = new Ninja
            //    {
            //        Name = "SampsonSan",
            //        ServedInOniwaban = false,
            //        DateOfBirth = new DateTime(2008, 1, 28),
            //        ClanId = 1

            //    };
            //    var l = new Ninja
            //    {
            //        Name = "Leonardo",
            //        ServedInOniwaban = false,
            //        DateOfBirth = new DateTime(1984, 1, 1),
            //        Clan = turtleClan
            //    };
            //    var r = new Ninja
            //    {
            //        Name = "Raphael",
            //        ServedInOniwaban = false,
            //        DateOfBirth = new DateTime(1985, 1, 1),
            //        Clan = turtleClan
            //    };
            //    context.Ninjas.AddRange(new List<Ninja> { j, s, l, r });
            //    var ninjaKC = new Ninja
            //    {
            //        Name = "Kacy Catanzaro",
            //        ServedInOniwaban = false,
            //        DateOfBirth = new DateTime(1990, 1, 14),
            //        Clan = amClan
            //    };
            //    var muscles = new NinjaEquipment
            //    {
            //        Name = "Muscles",
            //        Type = EquipmentType.Tool,

            //    };
            //    var spunk = new NinjaEquipment
            //    {
            //        Name = "Spunk",
            //        Type = EquipmentType.Weapon
            //    };

            //    ninjaKC.EquipmentOwned.Add(muscles);
            //    ninjaKC.EquipmentOwned.Add(spunk);
            //    context.Ninjas.Add(ninjaKC);

            //    context.SaveChanges();
            //    context.Database.ExecuteSqlCommand(
            //      @"CREATE PROCEDURE GetOldNinjas
            //        AS  SELECT * FROM Ninjas WHERE DateOfBirth<='1/1/1980'");

            //    context.Database.ExecuteSqlCommand(
            //       @"CREATE PROCEDURE DeleteNinjaViaId
            //         @Id int
            //         AS
            //         DELETE from Ninjas Where Id = @id
            //         RETURN @@rowcount");
            }
        }
    }
}

