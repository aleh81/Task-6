using System;
using IConvertible = Task6.BLL.N.Interfaces.IConvertible;

namespace Task6.BLL.N.Helpers
{
	public class ProgramHelper: IConvertible
	{
		public string ConvertToCSharp(string code) =>
			$"Code: {code} succesfully converted to C# code";

		public string ConvertToVB(string code) =>
			$"Code: {code} succesfully converted to C# code";
	}
}
