using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingPlanners.Models
{
    public class Vendor
    {
        [Key]
        public int ID { get; set; }
        public string company_name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string tele_no { get; set; }
        public string company_catogary { get; set; }
        
        public string username { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }

        [DataType(DataType.Password)]
        public string retypepassword { get; set; }
    }
}
