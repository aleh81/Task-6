using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.BLL.Interfaces
{
	interface ICodeChecker
	{
		bool CodeCheckSyntax(string verificationString, string usedLanguage);
	}
}
