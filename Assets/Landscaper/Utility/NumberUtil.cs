using UnityEngine;

namespace Landscaper
{
	public static class NumberUtil
	{
		public static void ModWithRemainder(float value, float divisor, out int count, out float remainder)
		{
			count = Mathf.FloorToInt(value / divisor);
			remainder = value % divisor;
		}

		public static void ModWithRemainder(Vector3 value, float divisor, out int xCount, out int yCount, out int zCount, out Vector3 remainder)
		{
			ModWithRemainder(value, new Vector3(divisor, divisor, divisor), out xCount, out yCount, out zCount, out remainder);
		}

		public static void ModWithRemainder(Vector3 value, Vector3 divisor, out int xCount, out int yCount, out int zCount, out Vector3 remainder)
		{
			remainder = Vector3.zero;

			xCount = Mathf.FloorToInt(value.x / divisor.x);
			remainder.x = value.x % divisor.x;

			yCount = Mathf.FloorToInt(value.y / divisor.y);
			remainder.y = value.y % divisor.y;

			zCount = Mathf.FloorToInt(value.z / divisor.z);
			remainder.z = value.z % divisor.z;
		}
	}
}
