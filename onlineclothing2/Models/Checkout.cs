using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace onlineclothing2.Models
{
    [Table("checkout")]
    public class Checkout
    {
       
        public Checkout()
        {
            Testcart = new List<Testcart>(); 
        }
        [Key]
        public int id { get; set; }
        public string OrederNo { get; set; }
        public string? Fullname { get; set; }    
        public int phone { get; set; }
        public string? Delivery { get; set; }    
        
        public string? payment { get; set; }
        public int pid { get; set; }    
        public int cartid { get; set; } 
        public virtual List<Testcart> Testcart { get; set; }
    }
}
