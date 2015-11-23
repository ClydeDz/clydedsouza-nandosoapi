using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clydedsouza_nandosoapi.Models
{
    public enum Type
    {
        Veg, NonVeg
    }
    public enum Course
    {
        Starters, Mains, Deserts, Drinks
    }
    public enum Level
    {
        Mild, Medium, Hot
    }
    
    public class Menu
    {
        public int ID { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Type Type { get; set; }
        public Course Course { get; set; }
        public Level Level { get; set; }
        public bool OnSpecial { get; set; }
        public double Discount { get; set; }
        public string Day { get; set; }

        [JsonIgnore]
        public virtual ICollection<Coupon> Coupons { get; set; }
    }
}
