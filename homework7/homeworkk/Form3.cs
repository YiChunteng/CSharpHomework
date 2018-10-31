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
	public partial class Form3 : Form
	{
		public string changing;
		public string nname;
		public string ggoods;
		public int nnum;
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			comboBox1.Items.Add("苹果");
			comboBox1.Items.Add("香蕉");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			changing = textBox1.Text;
			nname = textBox2.Text;
			ggoods = comboBox1.Text;
			nnum = int.Parse (textBox4.Text);

			this.Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
