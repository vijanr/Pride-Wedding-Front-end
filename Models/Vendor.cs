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
        public string CompanyName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string TelephoneNo { get; set; }
        public string CompanyCatogary { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
