﻿using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.EntityRepositories
{
    public class UserEntityRepository : IRepository<User>
    {
        private PizzaDbContext _context;
        public UserEntityRepository(PizzaDbContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(User entity)
        {
            _context.Users.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public void Update(User entity)
        {
            User user = _context.Users.SingleOrDefault(x => x.Id == entity.Id);
            if (user != null)
            {
                user.Address = entity.Address;
                user.FirstName = entity.FirstName;
                user.LastName = entity.LastName;
                user.Phone = entity.Phone;
                if (entity.Orders != null)
                    user.Orders = entity.Orders;

                _context.Users.Update(user);
            }
        }

        public void DeleteById(int id)
        {
            User user = _context.Users.SingleOrDefault(x => x.Id == id);
            if (user != null)
                _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}