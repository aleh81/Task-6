namespace Task6.BLL.Interfaces
{
	interface ICodeChecker
	{
		bool CodeCheckSyntax(string verificationString, string usedLanguage);
	}
}
