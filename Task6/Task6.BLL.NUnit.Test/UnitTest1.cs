using System;
using NUnit.Framework;
using Task6.BLL.N;

namespace Task6.BLL.NUnit.Test
{
	[TestFixture]
	public class UnitTest1
	{
		[Test]
		public void TestMethod1()
		{
			Assert.AreEqual(10, 10);
		}

		[Test]
		public void TestMove()
		{
			Assert.That(Class1.Mult(9), Is.EqualTo(81)); 
		}

		[Test]
		public void TestMove2()
		{
			Assert.That(Class1.Mult(7), Is.EqualTo(49));
		}


		[Test]
		public void TestMove3() => Assert.AreEqual(16, Class1.Mult(4));
	}
}

