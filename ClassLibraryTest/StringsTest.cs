using System;
using Xunit;
using ClassLibrary;

namespace ClassLibraryTest
{
	public class StringsTest
	{
		[Fact]
		public void StartsWithUpperTest()
		{
			// Tests that we expect to return true.
			string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
			foreach (var word in words)
			{
				bool result = word.StartsWithUpper();
				Assert.True(result, String.Format("Expected for '{0}': true; Actual: {1}", word, result));
			}
		}

		[Fact]
		public void StartsWithUpperFailsTest()
		{
			// Tests that we expect to return false.
			string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство", "1234", ".", ";", " " };
			foreach (var word in words)
			{
				bool result = word.StartsWithUpper();
				Assert.False(result, String.Format("Expected for '{0}': false; Actual: {1}", word, result));
			}
		}

		[Fact]
		public void StartsWithUpperNullOrEmptyTest()
		{
			// Tests that we expect to return false.
			string[] words = { string.Empty, null };
			foreach (var word in words)
			{
				bool result = Strings.StartsWithUpper(word);
				Assert.False(result, String.Format("Expected for '{0}': false; Actual: {1}", word == null ? "<null>" : word, result));
			}
		}
	}
}
