using System;
using UnityEngine;

namespace Landscaper
{
	public struct Point : IEquatable<Point>
	{
		public int X;
		public int Y;


		public Point(int xy)
		{
			X = Y = xy;
		}

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		#region IEquatable

		public bool Equals(Point other)
		{
			return X == other.X && Y == other.Y;
		}

		#endregion

		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is Point))
				return false;

			Point other = (Point)obj;
			return Equals(other);
		}

		public override int GetHashCode()
		{
			int hash = 17;

			hash = hash * 23 + X.GetHashCode();
			hash = hash * 23 + Y.GetHashCode();

			return hash;
		}

		public override string ToString()
		{
			return "{ X: " + X + ", Y: " + Y + " }";
		}

		public Vector2 ToVector2()
		{
			return new Vector2(X, Y);
		}


		#region Statics

		public static Point Clamp(Point input, Point min, Point max)
		{
			return new Point(	x: Mathf.Clamp(input.X, min.X, max.X),
								y: Mathf.Clamp(input.Y, min.Y, max.Y));
		}

		#endregion

		#region Operator Overloads

		public static bool operator ==(Point a, Point b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(Point a, Point b)
		{
			return !a.Equals(b);
		}

		public static Point operator +(Point a, Point b)
		{
			return new Point(a.X + b.X, a.Y + b.Y);
		}

		public static Point operator -(Point a, Point b)
		{
			return new Point(a.X - b.X, a.Y - b.Y);
		}

		public static Point operator +(Point a, int b)
		{
			return new Point(a.X + b, a.Y + b);
		}

		public static Point operator -(Point a, int b)
		{
			return new Point(a.X - b, a.Y - b);
		}

		#endregion
	}

	public struct GridRange
	{
		public Point Min;
		public Point Max;

		public int SizeX { get { return Max.X - Min.X; } }
		public int SizeY { get { return Max.Y - Min.Y; } }


		public GridRange(Point min, Point max)
			: this()
		{
			Min = min;
			Max = max;
		}

		public bool Contains(Point point)
		{
			if (point.X < Min.X ||
				point.X > Max.X ||
				point.Y < Min.Y ||
				point.Y > Max.Y)
				return false;

			return true;
		}

		public bool Contains(int x, int y)
		{
			if (x < Min.X ||
				x > Max.X ||
				y < Min.Y ||
				y > Max.Y)
				return false;

			return true;
		}

		public override string ToString()
		{
			return "{ " + Min.ToString() + ", " + Max.ToString() + " }";
		}
	}
}