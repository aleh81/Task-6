﻿using System;

namespace Task6.BLL.Helpers
{
	public static class ExceptionDisplay
	{
		public static void Display(Exception e)
		{
			Console.Beep();
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine("Exception in " + e.Source);
			Console.WriteLine("Method " + e.TargetSite);
			Console.WriteLine(e.GetType());
			Console.WriteLine(e.Message);
			Console.ResetColor();
		}
	}
}
