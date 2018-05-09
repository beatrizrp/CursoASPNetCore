﻿using System;
using System.Collections.Generic;

namespace Acoplamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new OrdersService(new OrdersRepository());
            var pedidos = service.GetOrders();
            
            foreach (var pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }        
        }
    }

    public class OrdersService
    {
        OrdersRepository _ordersRepository;
        public OrdersService(OrdersRepository repository)
        {
            _ordersRepository = repository;
        }

        public List<string> GetOrders()
        {
            var orders = _ordersRepository.getOrdersFromDB();
            return orders;

        }
    }

    public interface IOrdersRepository
    {
        List<string> getOrdersFromDB();
    }
    

    public class OrdersRepository
    {
        public List<string> getOrdersFromDB()
        {
            var orders = new List<string>()
            {
                "Pedido 1",
                "Pedido 2",
                "Pedido 3"
            };
            return orders;
        }
    }
}
