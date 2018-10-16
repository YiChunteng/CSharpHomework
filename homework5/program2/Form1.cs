using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//线的初始长度
			length = Convert.ToDouble(textBox4.Text);
			//粗细
			cx = int.Parse(textBox5.Text);
			//颜色
			R = Convert.ToInt32(textBox6.Text);
			G = Convert.ToInt32(textBox7.Text);
			B = Convert.ToInt32(textBox8.Text);
			//控制角度
			m = Convert.ToDouble(textBox2.Text);
			th1 = m * Math.PI / 180;
			mm = Convert.ToDouble(textBox3.Text);
			th2 = mm * Math.PI / 180;
			//控制k的大小
			k = Convert.ToDouble(textBox1.Text);

			if (graphics == null) graphics = this.CreateGraphics();
			drawCayleyTree1(8, 400, 550, length, -Math.PI / 2);
			
		}
		Random random = new Random();
		int R, G, B, cx;
		double m, mm, th1, th2, k, length;

		private Graphics graphics;
		double per1 = 0.6;
		double per2 = 0.7;
		
		void drawCayleyTree1(int n, double x0, double y0, double leng, double th)
		{
			if (n == 0) return;
			double x1 = x0 + leng * Math.Cos(th);
			double y1 = y0 + leng * Math.Sin(th);

			double x2 = x0 + leng * k * Math.Cos(th);
			double y2 = y0 + leng * k * Math.Sin(th);

			drawLine(x0, y0, x1, y1);
			drawLine(x0, y0, x2, y2);

			drawCayleyTree1(n - 1, x1, y1, per1 * leng, th + th1);
			drawCayleyTree1(n - 1, x2, y2, per2 * leng, th - th2);
		}
		
		void drawLine(double x0, double y0, double x1, double y1)
		{

			Pen pen = new Pen(Color.FromArgb(R,G,B), cx);
			graphics.DrawLine(
				pen, (int)x0, (int)y0, (int)x1, (int)y1);
		}

		
		
		private void label1_Click(object sender, EventArgs e)
		{
			
		}
		
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		//单击随机树按钮生成一棵随机树
		private void button2_Click(object sender, EventArgs e)
		{
			length = random.Next(60,150);
			//粗细
			cx = random.Next(1, 6);
			//颜色
			R = random.Next(10, 255);
			G = random.Next(10, 255);
			B = random.Next(10, 255);
			//控制角度
			m = random.Next(20, 80);
			th1 = m * Math.PI / 180;
			mm = random.Next(20, 80);
			th2 = mm * Math.PI / 180;
			//控制k的大小
			k = random.NextDouble() + 1.0;

			if (graphics == null) graphics = this.CreateGraphics();
			drawCayleyTree1(8, 400, 550, length, -Math.PI / 2);
		}
	}
}
