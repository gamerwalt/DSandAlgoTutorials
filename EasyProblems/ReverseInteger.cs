using System;

namespace EasyProblems
{
    public class ReverseInteger
    {
		public int ReverseInt(int x)
		{
			long result = 0;
			var isNegative = false;
			if (x < 0)
			{
				isNegative = true;
				x *= -1;
			}

			while (x > 0)
			{
				var remainder = x % 10;
				x = x / 10;

				result = (result * 10) + remainder;
			}

			if (result > int.MaxValue)
			{
				return 0;
			}

			return isNegative ? (int)(-1 * result) : (int)result;
		}
	}
}
