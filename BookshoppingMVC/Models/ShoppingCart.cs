﻿using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookshoppingMVC.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public bool isDeleted { get; set; } = false;
        public ICollection<CartDetail> CartDetails { get; set; }
    }
}
