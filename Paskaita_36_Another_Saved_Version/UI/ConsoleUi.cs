using Paskaita_36_Another_Saved_Version.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_36_Another_Saved_Version.UI
{
    internal class ConsoleUi
    {
        private readonly IOrderService _orderService;

        public ConsoleUi(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public void Run()
        {
            _orderService.Add();
        }
    }
}
