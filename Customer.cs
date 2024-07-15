﻿using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
