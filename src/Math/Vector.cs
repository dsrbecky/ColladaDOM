// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;

namespace Math
{
	/// <summary>
	/// 4 element mathematical vector.
	/// </summary>
	public struct Vector
	{
		public static Vector Origin = new Vector(0.0, 0.0, 0.0, 1.0);
		
		double x, y, z, w;
		
		public double X {
			get {
				return x;
			}
		}
		
		public double Y {
			get {
				return y;
			}
		}
		
		public double Z {
			get {
				return z;
			}
		}
		
		public double W {
			get {
				return w;
			}
		}
		
		public Vector(double x, double y, double z, double w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}
	}
}
