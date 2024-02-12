using _36_Part2_Restaurant_Solution_Structured.Services;
using _36_Paskaita_Restaurant_System.Models;
using Paskaita_36_Another_Saved_Version.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Paskaita_Restaurant_System.Repository
{
    internal class OrderRepository : IOrderRepository
    {
        List<Order> orders;
        public OrderRepository()
        {
            orders = new List<Order>();
        }

        public void Add(Order order)
        {
            orders.Add(order);
        }

    }
}
