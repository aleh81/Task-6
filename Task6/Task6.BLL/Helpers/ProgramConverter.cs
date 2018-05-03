using System;
using IConvertible = Task6.BLL.Interfaces.IConvertible;
namespace Task6.BLL.Helpers
{
	public class ProgramConverter: IConvertible
	{
		#region IConvertible members

		public string ConvertToCSharp(string code) =>
			string.IsNullOrEmpty(code) ? throw new ArgumentException()
				: $"Code: {code} succesfully converted to C# code";

		public string ConvertToVB(string code) =>
			string.IsNullOrEmpty(code) ? throw new ArgumentException()
				: $"Code: {code} succesfully converted to Visual Basic code";

		#endregion
	}
}
