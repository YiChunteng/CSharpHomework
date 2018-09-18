using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[100];
			bool  [] arrr = new bool  [101];
			for(int i = 0;i <= 100;i++)
			{
				arrr[i] = true;
			}
			arrr[0] = arrr[1] = false;
			int x = 0;
			for(int i = 2;i<= 100;i++)
			{
				if (arrr[i])
				{
					arr[x++] = i;

					for (int k = 2 * i; k <= 100; k += i)
					{
						arrr[k] = false;
					}
				}
			}
			int m = 0;
			while(arr[m] != 0)
			{
				Console.Write(arr[m] + " ");
				m++;

			}
		}
	}
}
