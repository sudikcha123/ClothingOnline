using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onlineclothing2.Models
{
    [Table("userregistration")]
    public class Userregister
    {   
        [Key]
        public int id { get; set; }
        public String? username{ get; set; }
        public String? email { get; set; }
        public String?  phone{ get; set; }
        public String? password { get; set; }
        
    }
}
