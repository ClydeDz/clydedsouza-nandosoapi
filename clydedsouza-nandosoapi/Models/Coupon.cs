using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clydedsouza_nandosoapi.Models
{
    public class Coupon
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string ExpiresOn { get; set; }
        public float Discount { get; set; }
        public int MenuID { get; set; }
        public string Exemptions { get; set; }

        [JsonIgnore]
        public virtual Menu Menu { get; set; }
    }
}
