using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.Entity;

namespace ordertest {
	/// <summary>
	/// OrderService:provide ordering service,
	/// like add order, remove order, query order and so on
	/// 实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)
	/// </summary>
	/// orderDict = new Dictionary<uint, Order>();
	public class OrderService { 

        //private Dictionary<uint, Order> orderDict;

        public OrderService() {
            
        }
		public void Add(Order order)
		{
			using (var db = new orderDB())
			{
				db.Order.Add(order);
				db.SaveChanges();
			}
		}

		public void Delete(String orderId)
		{
			using (var db = new orderDB())
			{
				var order = db.Order.Include("details").SingleOrDefault(o => o.Id == orderId);
				db.OrderDetails.RemoveRange(order.Details);
				
				db.Order.Remove(order);
				
				db.SaveChanges();
			}
		}

		public List<Order> GetAllOrders()
		{
			using (var db = new orderDB())
			{
				return db.Order.Include("details").ToList<Order>();
			}
		}

		public void Update(Order order)
		{
			using (var db = new orderDB())
			{
				db.Order.Attach(order);
				db.Entry(order).State = EntityState.Modified;
				order.Details.ForEach(
					item => db.Entry(item).State = EntityState.Modified);
				db.SaveChanges();
			}
		}

		public Order GetOrder(String Id)
		{
			using (var db = new orderDB())
			{
				return db.Order.Include("details").
				  SingleOrDefault(o => o.Id == Id);
			}
		}

		public List<Order> QueryByCustormer(String custormer)
		{
			using (var db = new orderDB())
			{
				return db.Order.Include("details")
				  .Where(o => o.custumerName.Equals(custormer)).ToList<Order>();
			}
		}

		public List<Order> QueryByGoods(String product)
		{
			using (var db = new orderDB())
			{
				var query = db.Order.Include("details")
				  .Where(o => o.Details.Where(
					item => item.GoodsName.Equals(product)).Count() > 0);
				return query.ToList<Order>();
			}
		}

		public List<Order> QueryByAmountMoney(double money)
		{
			using (var db = new orderDB())
			{
				var query = db.Order.Include("details")
				  .Where(o => o.Details.Where(
					item => item.AmountMoney > money).Count() > 0);
				return query.ToList<Order>();
			}
		}

	}
}
