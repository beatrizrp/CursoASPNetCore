using System;
using System.Collections.Generic;

namespace Acoplamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Podemos llamar a dos interfaces distintas: 
            // IOrdersRepository repository = new OrdersFromAPIRepository();
            IOrdersRepository repository = new OrdersRepository();

            var service = new OrdersService(repository);

            var pedidos = service.GetOrders();
            foreach (var pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }        
        }
    }

    public class OrdersService
    {
        IOrdersRepository _ordersRepository;
        public OrdersService(IOrdersRepository repository)
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


    public class OrdersRepository : IOrdersRepository
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

    public class OrdersFromAPIRepository : IOrdersRepository
    {
        public List<string> getOrdersFromDB()
        {
            var orders = new List<string>()
            {
                "Pedido desde api 1",
                "Pedido desde api 2",
                "Pedido desde api 3"
            };
            return orders;
        }
    }
}
