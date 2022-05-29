using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace onlineclothing2.Models
{
    [Table("loginuser")]
    public class Login
    {
      public int Id { get; set; }
        public string Email { get; set; }
        public int password { get; set; }
    }

}
