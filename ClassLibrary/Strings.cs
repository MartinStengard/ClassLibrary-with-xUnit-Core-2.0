using System;

namespace ClassLibrary
{
	public static class Strings
	{
		public static bool StartsWithUpper(this String str)
		{
			if (String.IsNullOrWhiteSpace(str))
				return false;

			Char ch = str[0];
			return Char.IsUpper(ch);
		}
	}
}
