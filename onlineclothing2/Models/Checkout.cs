using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace onlineclothing2.Models
{
    [Table("checkout")]
    public class Checkout
    {

        //public Checkout()
        //{
        //    Testcart = new List<Testcart>(); 
        //}
        [Key]
        public int id { get; set; }
        //public string OrederNo { get; set; }
        public string? fullname { get; set; }
        public int? phone { get; set; }
        //public int phone { get; set; }
        public string? delivery { get; set; }
        public string? name { get; set; }
        public string category { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        
        //public string? payment { get; set; }
        //public int pid { get; set; }    
        //public int cartid { get; set; } 
        //public virtual List<Testcart> Testcart { get; set; }
    }
    
}
