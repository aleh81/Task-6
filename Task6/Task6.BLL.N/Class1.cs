using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.BLL.N
{

	public class Employee
	{
		public virtual string GetTypeName()
		{
			return "This is an Employee";
		}
	}

	public class Manager: Employee
	{
		public virtual string GetTypeName()
		{
			return "This is a Manager";
		}
	}

	public class ManualWorker: Employee
	{
		
	}

	public class Class1
	{
		public string Move(string message) => "good";

		public static int Mult(int x) => x * x;
	}
}
