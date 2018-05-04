using System;
using Task6.BLL.Helpers;
using System.IO;
using Task6.BLL.Services;

namespace Task6.UI
{
	class Program
	{
		public static string FilePath =
			Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.FullName + "/";

		public static string FileName = "data.txt";

		static void Main(string[] args)
		{
			Write("Hello World. ", FilePath + FileName);

			Read(FilePath + FileName, "fdsfsd");

			Read(FilePath + FileName, "MyPassword");

			Console.WriteLine();

			ReadProgress(FilePath + FileName, 95);

			ReadProgress(FilePath + FileName, 15);

			ReadProgress(FilePath + FileName, 99);

			ReadProgress(FilePath + FileName, 1);

			Console.ReadKey();
		}

		public static void Write(string text, string path)
		{
			using (var fileStream = new FileStream(path, FileMode.Append))
			{
				var byteArray = System.Text.Encoding.Default.GetBytes(text);

				using (var protectedStream = new ProtectedStream(fileStream, null))
				{
					protectedStream.Write(byteArray, 0, byteArray.Length);
				}

				Console.WriteLine($"The file is recorded {byteArray.Length} byte");
			}
		}

		public static void Read(string path, string password)
		{
			using (var fileStream = File.OpenRead(path))
			{
				try
				{
					using (var protectedStream = new ProtectedStream(fileStream, password))
					{
						var array = new byte[fileStream.Length];

						protectedStream.Read(array, 0, array.Length);

						string textFromFile = System.Text.Encoding.Default.GetString(array);

						Console.WriteLine($"Text from file: \n {textFromFile}");
					}
				}
				catch (Exception e)
				{
					ExceptionDisplay.Display(e);
				}
			}
		}

		public static void ReadProgress(string path, int percent)
		{
			using (var fileStream = File.OpenRead(path))
			{
				try
				{
					using ( var progressStream = new ProgressBarStream(fileStream, percent))
					{
						progressStream.Progress += Display_Progress;

						var array = new byte[fileStream.Length];

						var count = progressStream.Length / 100.0 * percent;

						progressStream.Read(array, 0, (int)count);

						var textFromFile = System.Text.Encoding.Default.GetString(array);

						Console.WriteLine();

						Console.WriteLine($"Read text: \n  {textFromFile}");
					}
				}
				catch (Exception e)
				{
					ExceptionDisplay.Display(e);
				}
			}
		}

		public static void Display_Progress(int percent)
		{
			ProgressBar.DisplayProgress(percent);
		}
	}
}
