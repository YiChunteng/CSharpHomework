using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
	public abstract class Graph
	{
		public abstract void Display();
		public abstract double Area();
	}

	public class GraphFactory
	{
		public static Graph GetGraph(String type)
		{
			Graph graph = null;
			if(type .Equals("三角形"))
			{
				graph = new Triangle();
			}
			else if(type.Equals("正方形"))
			{
				graph = new Square();
			}
			else if(type.Equals("圆形"))
			{
				graph = new Circle();
			}
			else if(type.Equals("长方形"))
			{
				graph = new Rectangle();
			}

			return graph;
		}
	}

	//三角形
	public class Triangle : Graph
	{
		private double height;
		private double button;

		public Triangle()
		{
			Console.WriteLine("请输入三角形的底边长：");
			this.button = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("请输入三角形的高：");
			this.height = Convert.ToDouble(Console.ReadLine());

		}

		public override double Area()
		{
			return (0.5 * height * button);
		}

		public override void Display()
		{
			Console.WriteLine("三角形的面积是：" + Area());
			
		}
	}
	//正方形
	public class Square : Graph
	{

		private double l;

		public Square()
		{
			Console.WriteLine("请输入正方形的边长：");
			l = Convert.ToDouble(Console.ReadLine());

		}

		public override double Area()
		{
			return (l * l);
		}

		public override void Display()
		{
			Console.WriteLine("正方形的面积是：" + Area());
		}
	}

	//圆
	public class Circle : Graph
	{
		private double R;
		public Circle()
		{
			Console.WriteLine("请输入圆的半径：");
			R = Convert.ToDouble(Console.ReadLine());
		}
		public override double Area()
		{
			return (3.14 * R * R);
		}
		public override void Display()
		{
			Console.WriteLine("圆的面积是：" + Area());
		}
	}
	//长方形
	public class Rectangle : Graph
	{
		private double length;
		private double width;
		public Rectangle()
		{
			Console.WriteLine("请输入长方形的长度：");
			length = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("请输入长方形的宽度：");
			width = Convert.ToDouble(Console.ReadLine());
		}
		public override double Area()
		{
			return (length * width);
		}
		public override void Display()
		{
			Console.WriteLine("长方形的面积是：" + Area());
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("请输入图形的名称（正方形、三角形、圆形、长方形）：");

			Graph graph = GraphFactory.GetGraph(Console.ReadLine());
			
			graph.Display();
		}
	}
}
