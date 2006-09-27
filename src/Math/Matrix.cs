// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;

namespace Math
{
	/// <summary>
	/// Represents 4x4 mathematical matrix stored in column-major order 
	/// (same as OpenGL). Immutable.
	/// </summary>
	public class Matrix
	{
		double[] m;
		
		public double[] Elements {
			get {
				return m;
			}
		}
		
		public Matrix(double[] elements)
		{
			this.m = elements;
		}
		
		public Vector Multiply(Vector vector)
		{
			return new Vector(m[0] * vector.X + m[4] * vector.Y + m[8 ] * vector.Z + m[12] * vector.W,
			                  m[1] * vector.X + m[5] * vector.Y + m[9 ] * vector.Z + m[13] * vector.W,
			                  m[2] * vector.X + m[6] * vector.Y + m[10] * vector.Z + m[14] * vector.W,
			                  m[3] * vector.X + m[7] * vector.Y + m[11] * vector.Z + m[15] * vector.W);
		}
	}
}
