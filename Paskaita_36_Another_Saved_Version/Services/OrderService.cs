using _36_Paskaita_Restaurant_System.Models;
using Paskaita_36_Another_Saved_Version.Repositories.Interfaces;
using Paskaita_36_Another_Saved_Version.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Part2_Restaurant_Solution_Structured.Services
{
    internal class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add()
        {
            _orderRepository.Add(new Order());
        }

    }
}
