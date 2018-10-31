using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;

namespace homeworkk
{
	public partial class Form1 : Form
	{
		public List<Order> orders = new List<Order>();
		OrderService orderService = new OrderService();
		
		public string KeyWord { get; set; }


		public Form1()
		{
			InitializeComponent();
			
			Order order1 = new Order("03", "小凯", "香蕉", 80);
			orderService.InsertOrder(order1);
 		    orderBindingSource.DataSource = orderService.list;
			textBox1.DataBindings.Add("Text", this, "KeyWord");
			

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBox1.Items.Add("01");
			comboBox1.Items.Add("02");
			comboBox1.Items.Add("03");

			comboBox2.Items.Add("Id");
			comboBox2.Items.Add("姓名");
			comboBox2.Items.Add("商品");
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		//添加订单
		private void button2_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.ShowDialog();

			string m1 = form2.Idd;
			string m2 = form2.Namee;
			string m3 = form2.Goodss;
			int m4 = form2.Amountt;
			if (m1 != null && m2 != null && m3 != null && m4 != 0)
			{
				BindingList<Order> bindinglist = new BindingList<Order>();
				bindinglist = new BindingList<Order>(orderService.list);
				orderBindingSource.DataSource = bindinglist;

				Order order2 = new Order(m1, m2, m3, m4);
				bindinglist.Add(order2);
				comboBox1.Items.Add(m1);
			}
			
			orderBindingSource.EndEdit();
		}
		//修改订单
		private void button3_Click(object sender, EventArgs e)
		{
			BindingList<Order> bindinglist = new BindingList<Order>();
			bindinglist = new BindingList<Order>(orderService.list);
			orderBindingSource.DataSource = bindinglist;

			Form3 form3 = new Form3();
			form3.ShowDialog();

			string a1 = form3.changing;
			string a2 = form3.nname;
			string a3 = form3.ggoods;
			int  a4 = form3.nnum;
			
			
			for( int i = 0; i < bindinglist.Count; i++)
			{
				if(a1 != null && bindinglist[i].card.Contains(a1))
				{
					bindinglist[i] = new Order(a1, a2, a3, a4);
				}
			}
			

		}
		//查找订单
		private void button1_Click(object sender, EventArgs e)
		{
			
			switch (comboBox2.Text)
			{
				case ("Id"):
					orderBindingSource.DataSource =
						orderService.list.Where(s => s.card == KeyWord);
					break;
				case ("姓名"):
					orderBindingSource.DataSource =
						orderService.list.Where(s => s.name == KeyWord);
					break;
				case ("商品"):
					orderBindingSource.DataSource =
						orderService.list.Where(s => s.series == KeyWord);
					break;
			}
			

		}
		//删除订单
		private void button4_Click(object sender, EventArgs e)
		{
			BindingList<Order> bindinglist = new BindingList<Order>(orderService.list);
			orderBindingSource.DataSource = bindinglist;
			for(int i = 0; i< bindinglist.Count; i++)
			{
				if(bindinglist[i].card.Contains(comboBox1.Text))
				{
					bindinglist.RemoveAt(i);
				}
			}
		
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
