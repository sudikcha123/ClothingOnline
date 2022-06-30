using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace onlineclothing2.Models
{
    [Table("adminlogin")]
    public class LoginAdmin
    {
        [Key]

        public string ?email { get; set; }
        public string ?password { get; set; }
        public string ?role { get; set; }


    }
}
