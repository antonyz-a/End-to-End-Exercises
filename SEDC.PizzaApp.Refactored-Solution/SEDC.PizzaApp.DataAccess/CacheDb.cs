﻿using SEDC.PizzaApp.Domain.Enum;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.DataAccess
{
    public static class CacheDb
    {
        public static List<Order> Orders;
        public static List<User> Users;
        public static List<Pizza> Menu;
        public static List<Feedback> Feedbacks;

        public static int OrderId;
        public static int UserId;
        public static int PizzaId;
        public static int FeedbackId;

        static CacheDb()
        {
            Users = new List<User>()
            {
                new User
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobski",
                    Address = "Bob street",
                    Phone = 3565645546567
                },
                new User
                {
                    Id = 2,
                    FirstName = "Jill",
                    LastName = "Wayne",
                    Address = "Jill street",
                    Phone = 3565645546123
                }
            };

            Menu = new List<Pizza>()
            {
                 new Pizza()
                {
                    Id = 1,
                    Name = "Kapri",
                    Price = 7,
                    PizzaSize = PizzaSize.Medium,
                    Image = "Kapri.png"
                },
                new Pizza()
                {
                    Id = 2,
                    Name = "Kapri",
                    Price = 7,
                    PizzaSize = PizzaSize.Large,
                    Image = "Kapri.png"
                },
                new Pizza()
                {
                    Id = 3,
                    Name = "Kapri",
                    Price = 7,
                    PizzaSize = PizzaSize.Family,
                    Image = "Kapri.png"
                },
                new Pizza()
                {
                    Id = 4,
                    Name = "Peperoni",
                    Price = 9,
                    PizzaSize = PizzaSize.Medium,
                    Image = "Peperoni.png"
                },
                new Pizza()
                {
                    Id = 5,
                    Name = "Peperoni",
                    Price = 8,
                    PizzaSize = PizzaSize.Large,
                    Image = "Peperoni.png"
                },
                new Pizza()
                {
                    Id = 6,
                    Name = "Peperoni",
                    Price = 8,
                    PizzaSize = PizzaSize.Family,
                    Image = "Peperoni.png"
                },
                new Pizza()
                {
                    Id = 7,
                    Name = "Margarita",
                    Price = 10.5,
                    PizzaSize = PizzaSize.Medium,
                    Image = "Margarita.png"
                },
                new Pizza()
                {
                    Id = 8,
                    Name = "Margarita",
                    Price = 10.5,
                    PizzaSize = PizzaSize.Large,
                    Image = "Margarita.png"
                },
                new Pizza()
                {
                    Id = 9,
                    Name = "Margarita",
                    Price = 10.5,
                    PizzaSize = PizzaSize.Family,
                    Image = "Margarita.png"
                },
                new Pizza()
                {
                    Id = 10,
                    Name = "Siciliana",
                    Price = 6.5,
                    PizzaSize = PizzaSize.Medium,
                    Image = "Siciliana.png"
                },
                new Pizza()
                {
                    Id = 11,
                    Name = "Siciliana",
                    Price = 9.5,
                    PizzaSize = PizzaSize.Large,
                    Image = "Siciliana.png"
                },
                new Pizza()
                {
                    Id = 12,
                    Name = "Siciliana",
                    Price = 9.5,
                    PizzaSize = PizzaSize.Family,
                    Image = "Siciliana.png"
                }
            };

            Orders = new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    User = Users[0],
                    PizzaOrders = new List<PizzaOrder>()
                    {
                        new PizzaOrder()
                        {
                            Pizza = Menu[0]
                        }
                    }
                },
                new Order()
                {
                    Id = 2,
                    User = Users[0],
                    PizzaOrders = new List<PizzaOrder>()
                    {
                        new PizzaOrder()
                        {
                            Pizza = Menu[0]

                        },
                        new PizzaOrder() {Pizza = Menu[1]},
                        new PizzaOrder() {Pizza = Menu[2]},
                        new PizzaOrder() {Pizza = Menu[3]},
                    }
                },
                new Order()
                {
                    Id = 3,
                    User = Users[1],
                    PizzaOrders = new List<PizzaOrder>()
                    {
                        new PizzaOrder()
                        {
                            Pizza = Menu[0]
                        },
                        new PizzaOrder() {Pizza = Menu[1]},
                        new PizzaOrder() {Pizza = Menu[8]},
                       

                    }
                }
            };

            Feedbacks = new List<Feedback>()
            {
                new Feedback
                {
                    Id = 1,
                    Name = "Antonio",
                    Email = "antoniokosarkar@gmail.com",
                    Message = "Thats is one salty pizza, Take it easy on the salt next time"
                },
                new Feedback
                {
                    Id = 2,
                    Name = "Pero",
                    Email = "perosarkar@gmail.com",
                    Message = "The margarita is Great"
                }
            };

            OrderId = 3;
            UserId = 2;
            PizzaId = 12;
            FeedbackId = 2;
        }
    }
}
