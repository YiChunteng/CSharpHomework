using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{

	//定义一个委托，申明事件处理函数的格式 
	public delegate void ClockHandler(object sender, ClockEventArgs args);

	public class ClockEventArgs : EventArgs
	{
		public DateTime TimeNow = DateTime.Now;
	}

	public class MyClock
	{
		//定义事件，相当于申明一个委托实例，初值为null
		public event ClockHandler OnClick;

		public void Clock(DateTime timeSpan)
		{
			//触发Click事件

			ClockEventArgs args = new ClockEventArgs();
			//DateTime TimeTow = args.TimeNow.Add(timeSpan);



			while (DateTime.Now < timeSpan)
			{

			}
			OnClick(this, args);

		}

	}


	class Program
	{

		static void Main(string[] args)
		{
			MyClock btn = new MyClock();

			//为btn的OnClick事件添加两个处理方法
			btn.OnClick += new ClockHandler(btn_OnClick); //添加一个委托实例
														  //Console.WriteLine("请输入时间间隔（格式：例如：00:00:00):");
														  //string T = Convert.ToString(Console.ReadLine());
														  //TimeSpan span = TimeSpan.Parse(T);

			Console.Write("其依照格式输入日期时间：");
			Console.Write("其输入 日：");
			int d = Convert.ToInt32(Console.ReadLine());
			Console.Write("其输入 时：");
			int h = Convert.ToInt32(Console.ReadLine());
			Console.Write("其输入 分：");
			int m = Convert.ToInt32(Console.ReadLine());
			Console.Write("其输入 秒：");
			int s = Convert.ToInt32(Console.ReadLine());

			DateTime dateTime = new DateTime(2018, 10, d, h, m, s);
			btn.Clock(dateTime);

		}

		static void btn_OnClick(object sender, ClockEventArgs args)
		{
			Console.WriteLine($"该起床啦！！！");
		}


	}




}