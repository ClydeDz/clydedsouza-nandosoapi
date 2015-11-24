using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace clydedsouza_nandosoapi.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))] 
    public class clydedsouza_nandosoapiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public class MyConfiguration : DbMigrationsConfiguration<clydedsouza_nandosoapiContext>
        {
            public MyConfiguration()
            {
                this.AutomaticMigrationsEnabled = true;
            }

            protected override void Seed(clydedsouza_nandosoapiContext context)
            {
                // Load dummy menu items
                var menuItems = new List<Menu>
                {
                new Menu {
                    Item = "Quarter Chicken",   Description = "Small fraction, big reaction", Price = 8.90 , Type = Type.NonVeg,
                    Course = Course.Mains, Level = Level.Medium, OnSpecial = false, Discount = 0, Day ="Monday"
                },
                 new Menu {
                    Item = "Quarter Chicken & Regular side ",   Description = "Small fraction, big reaction.", Price = 12 , Type = Type.NonVeg,
                    Course = Course.Mains, Level = Level.Mild, OnSpecial = true, Discount = 2.5, Day ="Monday"
                },
                new Menu {
                    Item = "5 Grilled Tenderloins",   Description = "So tender you'll feel it in your loins", Price = 15.50 , Type = Type.NonVeg,
                    Course = Course.Mains, Level = Level.Mild, OnSpecial = true, Discount = 1.2, Day ="Monday"
                },
                new Menu {
                    Item = "Espetada (Portuguese Chicken Skewer)",   Description = "Marinated thigh fillets skewered with fresh red capsicum and onion, flame-grilled to perfection, basted to your heart's desire, served over a regular side.", Price = 17 , Type = Type.NonVeg,
                    Course = Course.Mains, Level = Level.Hot, OnSpecial = true, Discount = 1.2, Day ="Wednesday"
                },
                new Menu {
                    Item = "Grilled Livers",   Description = "Grilled in a garlic sauce and basted to your hearts desire. ", Price = 12 , Type = Type.NonVeg,
                    Course = Course.Mains, Level = Level.Mild, OnSpecial = false, Discount = 0, Day ="Monday"
                },
                new Menu {
                    Item = "Grilled Veggie Strips",   Description = "A wholesome combination of chunky veggies and haloumi cheese grilled with Nando's PERi-PERi basting served with your choice of side. ", Price = 8 , Type = Type.Veg,
                    Course = Course.Starters, Level = Level.Mild, OnSpecial = false, Discount = 0, Day ="Monday"
                },
                new Menu {
                    Item = "5 BBQ Thigh Fillets",   Description = "Get high on some thighs.", Price = 8 , Type = Type.NonVeg,
                    Course = Course.Starters, Level = Level.Medium, OnSpecial = true, Discount = 1.1, Day ="Wednesday"
                },
                new Menu {
                    Item = "Assorted Desserts",   Description = "We have kept the best for the last", Price = 4.2 , Type = Type.Veg,
                    Course = Course.Deserts, Level = Level.Mild, OnSpecial = false, Discount = 0, Day ="Monday"
                },
                new Menu {
                    Item = "Supremo Veggie Burger",   Description = "Combining a freshly baked Portuguese roll, scrumptious home-style veggie patty, gourmet lettuce, tomato, light mayo & PERi-PERi chutney.", Price = 13 , Type = Type.Veg,
                    Course = Course.Mains, Level = Level.Mild, OnSpecial = false, Discount = 0, Day ="Monday"
                },
                new Menu {
                    Item = "Portuguese Veggie Paella",   Description = "Grilled home-style veggie patty combined with veggie strips, tossed over our spicy rice.", Price = 5.90 , Type = Type.Veg,
                    Course = Course.Mains, Level = Level.Mild, OnSpecial = false, Discount = 0, Day ="Monday"
                }
                };
                menuItems.ForEach(s => context.Menus.AddOrUpdate(p => p.Item, s));
                context.SaveChanges();

                // Load dummy Coupon Items
                var couponItems = new List<Coupon>
                {
                    new Coupon
                    {
                        Code ="SSRPCGG4B3C", ExpiresOn= DateTime.Parse("2016-01-02"), Discount= 15, Exemptions="",
                        MenuID= menuItems.Single(s => s.Item == "5 Grilled Tenderloins").ID
                    },
                    new Coupon
                    {
                        Code ="ADDLGSSPVHF", ExpiresOn= DateTime.Parse("2015-12-25"), Discount= 25, Exemptions="",
                        MenuID= menuItems.Single(s => s.Item == "Assorted Desserts").ID
                    },
                    new Coupon
                    {
                        Code ="IKAQOWML3TE", ExpiresOn= DateTime.Parse("2016-03-04"), Discount= 5, Exemptions="",
                        MenuID= menuItems.Single(s => s.Item == "5 Grilled Tenderloins").ID
                    },
                                        new Coupon
                    {
                        Code ="SJYPCGG4B3C", ExpiresOn= DateTime.Parse("2015-11-30"), Discount= 20, Exemptions="",
                        MenuID= menuItems.Single(s => s.Item == "5 Grilled Tenderloins").ID
                    },
                    new Coupon
                    {
                        Code ="AIYLGSSPVHF", ExpiresOn= DateTime.Parse("2016-01-01"), Discount= 16, Exemptions="",
                        MenuID= menuItems.Single(s => s.Item == "Quarter Chicken").ID
                    },
                    new Coupon
                    {
                        Code ="IKAQO8FL3TE", ExpiresOn= DateTime.Parse("2016-01-01"), Discount= 16, Exemptions="",
                        MenuID= menuItems.Single(s => s.Item == "5 Grilled Tenderloins").ID
                    },
                    new Coupon
                    {
                        Code ="UQB1IDVLY03", ExpiresOn= DateTime.Parse("2016-02-03"), Discount= 2, Exemptions="",
                        MenuID= menuItems.Single(s => s.Item == "5 Grilled Tenderloins").ID
                    }
                };
                couponItems.ForEach(s => context.Coupons.AddOrUpdate(p => p.Code, s));
                //foreach (Coupon e in couponItems)
                //{
                //    var enrollmentInDataBase = context.Coupons.Where(
                //        s => s.Menu.ID == e.MenuID).SingleOrDefault();
                //    if (enrollmentInDataBase == null)
                //    {
                //        context.Coupons.Add(e);
                //    }
                //}

                context.SaveChanges();
            }
        }

        public clydedsouza_nandosoapiContext() : base("name=clydedsouza_nandosoapiContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<clydedsouza_nandosoapiContext, MyConfiguration>());
        }

        public System.Data.Entity.DbSet<clydedsouza_nandosoapi.Models.Menu> Menus { get; set; }

        public System.Data.Entity.DbSet<clydedsouza_nandosoapi.Models.Coupon> Coupons { get; set; }
    }
}
