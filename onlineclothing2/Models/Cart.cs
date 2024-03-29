﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onlineclothing2.Models
{
    [Table("cart")]
    public class Cart
    {
        [Key]
        public int id { get; set; }
        public string? name { get; set; }
        public int? price { get; set; }  
        public int? productid { get; set;  }
        public string? username { get; set; }
       public string? category { get; set; }
       public int quantity { get; set; }
        public int total { get; set; }
    }
}
