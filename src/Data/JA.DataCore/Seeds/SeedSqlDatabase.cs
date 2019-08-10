using System;
using System.Collections.Generic;
using System.Text;
using JA.DataCore;
using JA.ModelsCore.Blog;
using JA.ModelsCore.Customer;

namespace JA.Data.Seeds
{
    public class SeedInitialDatabase // : DropCreateDatabaseAlways<BlogContext>
    {
        // Seed GoGirlCustomer
        //         public virtual void SeedGoGirlCustomerData(DbModelBuilder modelBuilder)

        protected static void Seed(BlogContext context)
        {
            // base.Seed(context);

            // Coops
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.Customers.Add(new GoGirlCustomer()
            {
                Id = 1,
                FirstName = "Justine",
                LastName = "Alires",
                Email = "ja@google.com",
                CustomerAddress =
                {
                    City = "Seattle",
                    Region = "Washington",
                    StreetAddress = "Arboretum Dr",
                    ZipCode = "97117"
                },

                PoliticalAffilliation = "FreedomFighter",
                DateOfBirth = new DateTime(1964, 09, 21),
                DateModified = DateTime.UtcNow,
                DateCreated = DateTime.Now,
                //Foodlogs = new List<FoodLog>
                //{
                //    new FoodLog()
                //    {
                //        Food = new List<Food>
                //        {
                //            new Food
                //            {
                //                Vegi = new Vegetable
                //                {
                //                    Name = "Eggplant",
                //                    PricePerEach = (decimal) 2.25,
                //                    PricePerFlat = (decimal) 12.25,
                //                    PricePerPound = (decimal) 1.39
                //                }
                //            }

                //        }
                //    },
                //},
                IsDirty = false

            });

            //// Vegetables
            //context.Produce.Add(new Vegetable
            //{
            //    Name = "Zucchini",
            //    PricePerEach = (decimal)0.25,
            //    PricePerFlat = (decimal)7.25,
            //    PricePerPound = (decimal)1.25,
            //    VegiSubstitutions = new List<Vegetable>()
            //                           {
            //                               new Vegetable(){ Name = "Eggplant",
            //                                PricePerEach = (decimal)2.25,
            //                                PricePerFlat = (decimal)12.25,
            //                                PricePerPound = (decimal)1.39,
            //                               },
            //                               new Vegetable(){ Name = "Parsnip",
            //                                PricePerEach = (decimal)0.39,
            //                                PricePerFlat = (decimal)4.25,
            //                                PricePerPound = (decimal)0.79,
            //                               }

            //                           }
            //});

            // Fruit
            //context.Produce.Add(new Fruit
            //{
            //    Name = "Apple",
            //    PricePerEach = (decimal)0.25,
            //    PricePerFlat = (decimal)40.00,
            //    PricePerPound = (decimal)1.25,
            //    FruitSubstitutions = new List<Fruit>()
            //                           {
            //                               new Fruit(){
            //                                    Name = "Oranges",
            //                                    PricePerEach = (decimal)0.75,
            //                                    PricePerFlat = (decimal)40.25,
            //                                    PricePerPound = (decimal)0.98,
            //                               },
            //                               new Fruit(){ Name = "Blueberries",
            //                                PricePerEach = (decimal)2.39,
            //                                PricePerFlat = (decimal)20.25,
            //                              //  PricePerPound = (decimal)0.79,
            //                               }

            //                           }
            //});

            context.SaveChangesAsync();

        }

    }
}

//VALUES(1,'Justine', 'Alires', 'ja@google.com', 'Seattle', 'Washington', 'FreedomFighter', '1')
//INSERT[dbo].[GoGirlCustomer]
//([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
//VALUES(1,'Julia', 'Chiles', 'julia@google.com', 'Seattle', 'Washington', 'FreedomFighter', '0')
//INSERT[dbo].[GoGirlCustomer]
//([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
//VALUES(1,'Gayle', 'Gand', 'gayle@google.com', 'Denver', 'Colorado', 'FreedomFighter', '0')
//INSERT[dbo].[GoGirlCustomer]
//([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
//VALUES(1,'Martha', 'Stewart', 'martha@google.com', 'Austin', 'Texas', 'FreedomFighter', '0')
//INSERT[dbo].[GoGirlCustomer]
//([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
//VALUES(1,'Adriana', 'Pacheco', 'adriana@google.com', 'Albuquerque', 'New Mexico', 'FreedomFighter', '0')
//INSERT[dbo].[GoGirlCustomer]
//([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
//VALUES(1,'Janine', 'Alires', 'janine@google.com', 'New York', 'New York', 'FreedomFighter', '0')
//INSERT[dbo].[GoGirlCustomer]
//([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
//VALUES(1,'Sara', 'Stephens', 'sara@google.com', 'Houston', 'Texas', 'FreedomFighter', '0')
//
//