﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Domain.Models
{
   public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<PizzaOrder> PizzaOrders { get; set; } = new List<PizzaOrder>();
        public double Price 
        { 
            get
            {
                return PizzaOrders.Sum(x => x.Pizza.Price) + 2;
            }
        }

    }
}
