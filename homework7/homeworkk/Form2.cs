using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeworkk
{
	public partial class Form2 : Form
	{
		public string Namee;
		public string Idd;
		public string Goodss;
		public int Amountt;
		public Form2()
		{
			InitializeComponent();
			
			
		}

		private void Form2_Load(object sender, EventArgs e)
		{

			comboBox1.Items.Add("苹果");
			comboBox1.Items.Add("香蕉");

			
		}
		 
		private void button1_Click(object sender, EventArgs e)
		{
			Idd = textBox1.Text;
			Namee = textBox2.Text;
			Goodss = comboBox1.Text;
			Amountt = int.Parse(textBox4.Text);
			
			this.Close();
			
		}
		
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}
		//private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		//{
		//	if (e.KeyChar == 13)
		//	{
		//		textBox2.Focus(); //当在文本框1中检查到回车键时，直接将焦点转入TextBox2
		//	}
		//}
		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
