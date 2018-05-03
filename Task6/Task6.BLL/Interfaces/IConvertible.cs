namespace Task6.BLL.Interfaces
{
	public interface IConvertible
	{
		string ConvertToCSharp(string code);

		string ConvertToVB(string code);
	}
}
 