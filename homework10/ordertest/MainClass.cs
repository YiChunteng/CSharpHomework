﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

    class MainClass {
        public static void Main() {
            try {
                Customer customer1 = new Customer("1", "Customer1");
                Customer customer2 = new Customer("2", "Customer2");

                Goods milk = new Goods("1", "Milk", 69.9);
                Goods eggs = new Goods("2", "eggs", 4.99);
                Goods apple = new Goods("3", "apple", 5.59);

                OrderDetail orderDetails1 = new OrderDetail("1", apple, 8.0);
                OrderDetail orderDetails2 = new OrderDetail("2", eggs, 2.0);
                OrderDetail orderDetails3 = new OrderDetail("3", milk, 1.0);

                Order order1 = new Order("1", customer1);
                Order order2 = new Order("2", customer2);
                
                order1.AddDetails(orderDetails1);
                order2.AddDetails(orderDetails2);
                order2.AddDetails(orderDetails3);
                //order1.AddOrderDetails(orderDetails3);
                
                

                OrderService os = new OrderService();
                os.Add(order1);
                os.Add(order2);

				os.Delete("1");

                Console.WriteLine("GetAllOrders");
                //List<Order> orders = os.QueryAllOrders();
                //foreach (Order od in orders)
                //    Console.WriteLine(od.ToString());

                //Console.WriteLine("GetOrdersByCustomerName:'Customer2'");
                //orders = os.QueryByCustomerName("Customer2");
                //foreach (Order od in orders)
                //    Console.WriteLine(od.ToString());

                //Console.WriteLine("GetOrdersByGoodsName:'apple'");
                //orders = os.QueryByGoodsName("apple");
                //foreach (Order od in orders)
                //    Console.WriteLine(od.ToString());

                //Console.WriteLine("GetOrdersByPrice:1000");
                //orders = os.QueryByPrice(1000);
                //foreach (Order od in orders)
                //    Console.WriteLine(od.ToString());

                //Console.WriteLine("Remove order(id=2) and qurey all");
                //os.RemoveOrder(2);
                //os.QueryAllOrders().ForEach(
                //    od => Console.WriteLine(od));

            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
