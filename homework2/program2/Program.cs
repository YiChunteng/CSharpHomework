using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 13, 9, 16, 25, 38 };
			int m = arr[1];
		  
			//数组的最大值
			for(int i = 0; i < arr.Length;i++)
			{
				if(arr[i] > m)
				{
					m = arr[i];
				}
			}
			Console.WriteLine("数组元素的最大值是：" + m);

			//数组的最小值
			for(int i = 0; i < arr.Length; i++)
			{
				if(arr[i] < m)
				{
					m = arr[i];
				}
			}
			Console.WriteLine("数组元素的最小值是：" + m);

			//数组元素的和
			int sum = 0;
			for(int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
			}
			Console.WriteLine("数组元素的和是：" + sum);

			//平均值
			double n = Convert.ToDouble(sum) / arr.Length;
			Console.WriteLine("数组元素的平均值是：" + n);
		}
		
	}
}
