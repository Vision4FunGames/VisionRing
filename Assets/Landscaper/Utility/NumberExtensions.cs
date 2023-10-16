using UnityEngine;

namespace Landscaper
{
	/// <summary>
	/// A collection of extensions for various number-related tasks
	/// </summary>
	public static class NumberExtensions
	{
		#region Random Number Generator

		/// <summary>
		/// Gets the next random float
		/// </summary>
		/// <param name="randomStream">The random stream to use</param>
		/// <param name="min">Minimum (inclusive) value</param>
		/// <param name="max">Maximum (inclusive) value</param>
		/// <returns></returns>
		public static float Next(this System.Random randomStream, float min, float max)
		{
			float range = max - min;
			return min + (range * (float)randomStream.NextDouble());
		}

		/// <summary>
		/// Gets a random unit vector
		/// </summary>
		/// <param name="randomStream">The random stream to use</param>
		/// <returns></returns>
		public static Vector3 NextUnitVector(this System.Random randomStream)
		{
			Vector3 vector = new Vector3(randomStream.Next(0.0f, 1.0f),
											randomStream.Next(0.0f, 1.0f),
											randomStream.Next(0.0f, 1.0f));

			return vector.normalized;
		}

		/// <summary>
		/// Gets a random unit vector, ignoring the Y component
		/// </summary>
		/// <param name="randomStream">The random stream to use</param>
		/// <returns></returns>
		public static Vector3 NextUnitVector2D(this System.Random randomStream)
		{
			Vector3 vector = new Vector3(randomStream.Next(-1.0f, 1.0f),
											0,
											randomStream.Next(-1.0f, 1.0f));

			return vector.normalized;
		}

		#endregion
	}
}
