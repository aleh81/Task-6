using Task6.BLL.Interfaces;
using IConvertible = Task6.BLL.Interfaces.IConvertible;

namespace Task6.BLL.Helpers
{
	public class ProgramHelper : ProgramConverter, ICodeChecker
	{
		#region ICodeChecker

		public bool CodeCheckSyntax(string verificationString, string usedLanguage) =>
			!string.IsNullOrEmpty(verificationString) &&
			!string.IsNullOrEmpty(usedLanguage) ? true : false;

		#endregion
	}
}
