using NUnit.Framework;
using Task6.BLL.Helpers;

namespace Task6.BLL.Tests.Helpers
{
	[TestFixture]
	class ProgramConverterTest
	{
		private ProgramConverter _programConverter;

		[SetUp]
		public void Init()
		{
			_programConverter = new ProgramConverter();
		}

		[Test]
		public void TestConvertToCSharp()
		{
			Assert.AreEqual(_programConverter.ConvertToCSharp("{some code}"),
				"Code: {some code} succesfully converted to C# code");
		}

		[Test]
		public void TestConvertToVB()
		{
			Assert.That(_programConverter.ConvertToVB("{some code}"),
				Is.EqualTo("Code: {some code} succesfully converted to Visual Basic code"));
		}
	}
}
