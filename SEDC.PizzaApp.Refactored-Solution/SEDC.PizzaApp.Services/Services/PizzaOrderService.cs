using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.CacheRepositories;
using SEDC.PizzaApp.Domain.Enum;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Services
{
    public class PizzaOrderService : IPizzaOrderService
    {

        private IRepository<Pizza> _pizzaRepository;
        private IRepository<Order> _orderRepository;

        public PizzaOrderService(IRepository<Pizza> pizzaRepository, IRepository<Order> orderRepository)
        {
            _pizzaRepository = pizzaRepository;
            _orderRepository = orderRepository;
        }
        public List<Order> GetAllOrders()
        {
            List<Order> allOrders = _orderRepository.GetAll();
            return allOrders;
        }

        public Order GetLastOrder()
        {
            return _orderRepository.GetAll().LastOrDefault();
        }

        public List<Pizza> GetMenu()
        {
            List<Pizza> menu = _pizzaRepository.GetAll().GroupBy(x => x.Name).Select(x => x.First()).ToList();
            return menu;
        }

        public string GetMostPopularPizza()
        {
            List<Order> orders = _orderRepository.GetAll();

            List<PizzaOrder> pizzas = orders.SelectMany(x => x.PizzaOrders).ToList();

            //First we group pizzas by name like 2 pepperoni, 10 kapri, 15 margaritas,1 siciliana
            //sort them by descending order
            //Take the first pizza, witch is the most ordered
            //Select the name from that pizza
            string mostPopularPizza = pizzas.GroupBy(x => x.Pizza.Name).OrderByDescending(x => x.Count()).FirstOrDefault()
                                            .Select(x => x.Pizza.Name).FirstOrDefault();
            return mostPopularPizza;

        }

        public Order GetOrderById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public int GetOrderCount()
        {
            return _orderRepository.GetAll().Count;
        }

        public Pizza GetPizzaFromMenu(string name, PizzaSize size)
        {
            return _pizzaRepository.GetAll().Where(x => x.Name == name && x.PizzaSize == size).FirstOrDefault();
        }

        public void MakeNewOrder(Order order)
        {
            _orderRepository.Insert(order);
        }
    }
}
