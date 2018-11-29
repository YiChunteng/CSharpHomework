using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ordertest {

    public class OrderDetail {
		[Key]
		public string Id { get; set; }
		public double Quantity { get; set; }
		public string GoodsName { get; set; }
		public double AmountMoney { get; set; }
		public Goods Goods { get; set; }
		

		public OrderDetail() { }

        public OrderDetail(string id, Goods goods, double value) {
            this.Id = id;
            this.Goods = goods;
			this.GoodsName = goods.Name;
			this.AmountMoney = (goods.Price * value);
            this.Quantity = value;
        }
		
  //      public double Quantity
		//{
		//	get { return quantity; }
		//	set
		//	{
		//		if (value < 0)
		//			throw new ArgumentOutOfRangeException("value must >= 0!");
		//		quantity = value;
		//	}
		//}

        //public override bool Equals(object obj)
        //{
        //    var detail = obj as OrderDetail;
        //    return detail != null &&
        //        Goods.Equals(detail.Goods)&&
        //        Quantity == detail.Quantity;
        //}

        public override int GetHashCode()
        {

            var hashCode = 1522631281;
            String gname=Goods==null?"":(Goods.Name==null?"": Goods.Name);
            hashCode = hashCode * -1521134295 + gname.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }


        public override string ToString() {
            string result = "";
            result += $"orderDetailId:{Id}:  ";
            result += Goods + $", quantity:{Quantity}"; 
            return result;
        }


    }
}
