using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace clydedsouza_nandosoapi.Models
{
    public class clydedsouza_nandosoapiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public clydedsouza_nandosoapiContext() : base("name=clydedsouza_nandosoapiContext")
        {
        }

        public System.Data.Entity.DbSet<clydedsouza_nandosoapi.Models.Menu> Menus { get; set; }

        public System.Data.Entity.DbSet<clydedsouza_nandosoapi.Models.Coupon> Coupons { get; set; }
    }
}
