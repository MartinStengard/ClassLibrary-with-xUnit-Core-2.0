using System;
using Xunit;
using ClassLibrary;

namespace ClassLibraryTest
{
	public class NumbersTest
	{
		[Fact]
		public void PassingTest()
		{
			Assert.Equal(4, Numbers.Add(2, 2));
		}

		[Fact]
		public void FailingTest()
		{
			Assert.Equal(4, Numbers.Add(2, 2));
		}

		[Theory]
		[InlineData(3)]
		[InlineData(5)]
		[InlineData(7)]
		public void OddTheory(int value)
		{
			Assert.True(Numbers.IsOdd(value));
		}
	}
}
