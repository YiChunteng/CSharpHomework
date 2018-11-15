using ordertest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OrderForm
{
    public partial class FormEdit : Form
    {
        Order result = null;

        public FormEdit()
        {
            InitializeComponent();
            Customer customer1 = new Customer(1, "liuwang");
            Customer customer2 = new Customer(2, "jams");

            Goods apple = new Goods(3, "apple", 5.59);
            Goods egg = new Goods(2, "egg", 4.99);
            Goods milk = new Goods(1, "milk", 69.9);
            customerBindingSource.Add(customer1);
            customerBindingSource.Add(customer2);
            goodsBindingSource.Add(apple);
            goodsBindingSource.Add(egg);
            goodsBindingSource.Add(milk);

        }

        public Order getResult()
        {
            return result;
        }

        public FormEdit(Order order):this()
        {
           orderBindingSource.DataSource = order;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (dataGridView1.CurrentCell.Value != null)
                {
                    comboBox2.Text = dataGridView1.CurrentCell.Value.ToString();  //对combobox赋值 
                }
              
                Rectangle R = dataGridView1.GetCellDisplayRectangle(
                                    dataGridView1.CurrentCell.ColumnIndex,
                                    dataGridView1.CurrentCell.RowIndex, false);

                comboBox2.Location = new Point(dataGridView1.Location.X + R.X,
                    dataGridView1.Location.Y + R.Y);

                comboBox2.Width = R.Width;
                comboBox2.Height = R.Height;
                comboBox2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (detailsBindingSource.Current == null)
            {
                detailsBindingSource.Add(new OrderDetail());
            }
            ((OrderDetail)detailsBindingSource.Current).Goods=(Goods)comboBox2.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			DateTime dateTime = DateTime.Now;

			string patternn ="^" + (dateTime.Year % 2000).ToString() + dateTime.Month.ToString()
				+ dateTime.Day.ToString() + "[0-9]{3}" + "$";


			//Regex regex = new Regex(patternn);

			string pattern1 = "^" + "[0-9]{11}" + "$";
			//Regex regex1 = new Regex(pattern1);

			//Match match = regex.Match(textBox1.Text);
			//Match match1 = regex1.Match(textBox2.Text);

			if(Regex.IsMatch(textBox1.Text.ToString(),patternn))
			{
				
				if(Regex.IsMatch(textBox2.Text.ToString(),pattern1))
				{
					result = (Order)orderBindingSource.Current;
					this.Close();
				}
				else
				{
					MessageBox.Show("电话号码格式错误！请重新输入！");
				}
			}
			else
			{
				MessageBox.Show("订单号格式错误！请重新输入！");
			}


		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((Order)orderBindingSource.Current).Customer =(Customer)comboBox1.SelectedItem;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = 
                ((Order)orderBindingSource.Current).Customer;
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
