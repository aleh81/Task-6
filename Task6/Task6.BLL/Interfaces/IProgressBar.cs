using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.BLL.Interfaces
{
	public interface IProgressBar
	{
		void DisplayProgress(int progress, int total);
	}
}
