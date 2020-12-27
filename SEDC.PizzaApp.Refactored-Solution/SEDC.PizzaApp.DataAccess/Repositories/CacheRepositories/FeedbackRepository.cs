using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.CacheRepositories
{
    public class FeedbackRepository : IRepository<Feedback>
    {
        
        public List<Feedback> GetAll()
        {
            return CacheDb.Feedbacks;
        }

        public Feedback GetById(int id)
        {
            return CacheDb.Feedbacks.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Feedback entity)
        {
            CacheDb.FeedbackId++;
            entity.Id = CacheDb.FeedbackId;
            CacheDb.Feedbacks.Add(entity);
            return entity.Id;
        }

        public void Update(Feedback entity)
        {
            Feedback feedback = CacheDb.Feedbacks.SingleOrDefault(x => x.Id == entity.Id);
            if (feedback != null)
            {
                int index = CacheDb.Feedbacks.IndexOf(feedback);
                CacheDb.Feedbacks[index] = entity;
            }
        }

        public void DeleteById(int id)
        {
            Feedback feedback = CacheDb.Feedbacks.SingleOrDefault(x => x.Id == id);
            if (feedback != null)
                CacheDb.Feedbacks.Remove(feedback);

        }
    }
}
