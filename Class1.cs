using Microsoft.VisualBasic.TestTools.UnitTesting;
using ConsoleApp1;
using System;

[TestClass]
public class ConsoleApp1Tests
{
	[TestMethod]
	public void ConsoleApp1Class1Tests()
	{
		var solution1 = new Solution0210();

		Assert.IsNotNull(solution1);
	}
}
