using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day2
{
	internal class DataTypes
	{
		static int? id;//static,null 

		static void Main(string[] args)
		{
			
			//int ? id=null;//local variable
			if(!id.HasValue)//false
			 Console.WriteLine("id is null");//null

			id=20;
			if(id.HasValue)
			   Console.WriteLine("id"+id);//null

			Nullable<int> mark=null;//C# 2.0,

			int x=default(int);
			float y=default(float);
			Console.WriteLine("value of x:{0}\tvalue of y:{1}",x,y);
			
		}
	}
}