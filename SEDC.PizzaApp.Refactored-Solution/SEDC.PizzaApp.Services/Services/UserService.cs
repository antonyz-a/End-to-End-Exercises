using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.CacheRepositories;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        private IRepository<Feedback> _feedbackRepository;
        public UserService(IRepository<User> userRepository, IRepository<Feedback> feedbackRepository)
        {
            _userRepository = userRepository;
            _feedbackRepository = feedbackRepository;
        }

        public int AddNewUser(User entity)
        {
            return _userRepository.Insert(entity);
        }

        
        public string GetLastUserName()
        {
            return _userRepository.GetAll().LastOrDefault().FirstName;
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public int GiveFeedback(Feedback entity)
        {
            return _feedbackRepository.Insert(entity);
        }

        public List<Feedback> GetFeedback(int ammount)
        {
            return _feedbackRepository.GetAll().GetRange(0, ammount).ToList();
            
        }
    }
}
