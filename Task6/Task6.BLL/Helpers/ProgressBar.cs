using System;
using Task6.BLL.Interfaces;

namespace Task6.BLL.Helpers
{
	public static class ProgressBar
	{
		private const int Total = 100;

		public static void DisplayProgress(int progress)
		{
			Console.CursorLeft = 0;
			Console.Write("["); 
			Console.CursorLeft = 32;
			Console.Write("]");
			Console.CursorLeft = 1;
			var onechunk = 30.0f / Total;

			var position = 1;
			for (var i = 0; i < onechunk * progress; i++)
			{
				Console.BackgroundColor = ConsoleColor.Green;
				Console.CursorLeft = position++;
				Console.Write(" ");
			}

			for (var i = position; i <= 31; i++)
			{
				Console.BackgroundColor = ConsoleColor.Gray;
				Console.CursorLeft = position++;
				Console.Write(" ");
			}

			Console.CursorLeft = 35;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Write(progress.ToString() + " of " + Total.ToString() + "%"); 
		}
	
	}
}
