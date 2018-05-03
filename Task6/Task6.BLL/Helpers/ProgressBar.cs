using System;
using Task6.BLL.Interfaces;

namespace Task6.BLL.Helpers
{
	public class ProgressBar : IProgressBar
	{
		public void DisplayProgress(int progress, int tot)
		{
			Console.CursorLeft = 0;
			Console.Write("["); 
			Console.CursorLeft = 32;
			Console.Write("]");
			Console.CursorLeft = 1;
			var onechunk = 30.0f / tot;

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
			Console.Write(progress.ToString() + " of " + tot.ToString() + "%"); 
		}
	
	}
}
