using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onlineclothing2.Models
{
    [Table("loginuser")]
    public class Userlogin
    {
        [Key]
        public int Id { get; set; }
        
        public string Email { get; set; }
        public string Password { get; set; }
        public string role { get; set; }
    }
}
