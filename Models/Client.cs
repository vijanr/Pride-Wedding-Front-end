using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingPlanners.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
        public int client_NIC { get; set; }
        public string F_name { get; set; }
        public string L_name { get; set; }
       
        [DataType(DataType.PhoneNumber)]
        public int tele_no { get; set; }
        public string Address { get; set; }
        public string username { get; set; }

        [DataType(DataType.EmailAddress)]
        
        public string email { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }

        [DataType(DataType.Password)]
        public string retypepassword { get; set; }
    }
}
