using System;

namespace ClassLibrary
{
	public static class Numbers
	{
		public static int Add(int x, int y)
		{
			return x + y;
		}

		public static bool IsOdd(int value)
		{
			return value % 2 == 1;
		}
	}
}
