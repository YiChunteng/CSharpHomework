using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest
{
	class orderDB : DbContext
	{
		public orderDB() : base("OrderDataBase") { }

		public DbSet<Order> Order { get; set; }

		public DbSet<OrderDetail> OrderDetails { get; set; }

		public DbSet<Goods> goods { get; set; }

		public DbSet<Customer> Customers { get; set; }
	}
}
