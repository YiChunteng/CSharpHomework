using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ordertest {

    /// <summary>
    /// Order class : all orderDetails
    /// to record each goods and its quantity in this ordering
    /// </summary>
    [Serializable]
    public class Order {
		[Key]
		public string Id { get; set; }
		public string custumerName { get; set; }
		public Customer Customer { get; set; }
		
		public List<OrderDetail> details=new List<OrderDetail>();
		
        public Order(){}

		//public Order(Order order)
		//{
		//	this.Id = order.Id;
		//	this.Customer = order.Customer;
		//	this.custumerName = order.Customer.Name;
		//	this.details = order.details;//不能省略
		//}

		public Order(string orderId, Customer customer) {
            this.Id = orderId;
			this.Customer = customer;
			this.custumerName = customer.Name;
        }


        //public double Amount
        //{
        //    get

        //    {
        //        return details.Sum(d => d.Goods.Price * d.Quantity);
        //    }
        //} 
            
        
        public List<OrderDetail> Details
		{
			set { }
            get =>this.details;
		}


        public void AddDetails(OrderDetail orderDetail) {
            //if (this.Details.Contains(orderDetail))  {
            //    throw new Exception($"orderDetails-{orderDetail.Id} is already existed!");
            //}
            details.Add(orderDetail);
        }


        public void RemoveDetails(string orderDetailId) {
            details.RemoveAll(d =>d.Id==orderDetailId);
        }


        public override string ToString() {
            string result = "================================================================================\n";
            result += $"orderId:{Id}, customer:({Customer.Name})";
            details.ForEach(od => result += "\n\t" + od);
            result += "\n================================================================================";
            return result;
        }
    }
}
