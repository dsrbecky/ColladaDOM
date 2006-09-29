// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;

namespace Math
{
	/// <summary>
	/// Represents 4x4 mathematical matrix. Immutable.
	/// </summary>
	public class Matrix
	{
		double m11, m12, m13, m14;
		double m21, m22, m23, m24;
		double m31, m32, m33, m34;
		double m41, m42, m43, m44;
		
		public Matrix(double m11, double m12, double m13, double m14,
		              double m21, double m22, double m23, double m24,
		              double m31, double m32, double m33, double m34,
		              double m41, double m42, double m43, double m44)
		{
			this.m11 = m11; this.m12 = m12; this.m13 = m13; this.m14 = m14;
			this.m21 = m21; this.m22 = m22; this.m23 = m23; this.m24 = m24;
			this.m31 = m31; this.m32 = m32; this.m33 = m33; this.m34 = m34;
			this.m41 = m41; this.m42 = m42; this.m43 = m43; this.m44 = m44;
		}
		
		
		/// <summary>
		/// Creates a matrix from an array of elements in column-major order
		/// </summary>
		public Matrix(double[] elements)
		{
			m11 = elements[0]; m12 = elements[4]; m13 = elements[8];  m14 = elements[12];
			m21 = elements[1]; m22 = elements[5]; m23 = elements[9];  m24 = elements[13];
			m31 = elements[2]; m32 = elements[6]; m33 = elements[10]; m34 = elements[14];
			m41 = elements[3]; m42 = elements[7]; m43 = elements[11]; m44 = elements[15];
		}
		
		public Vector Multiply(Vector vector)
		{
			return new Vector(m11 * vector.X + m12 * vector.Y + m13 * vector.Z + m14 * vector.W,
			                  m21 * vector.X + m22 * vector.Y + m23 * vector.Z + m24 * vector.W,
			                  m31 * vector.X + m32 * vector.Y + m33 * vector.Z + m34 * vector.W,
			                  m41 * vector.X + m42 * vector.Y + m43 * vector.Z + m44 * vector.W);
		}
		
		public static Vector operator *(Matrix matrix, Vector vector) 
		{
			return matrix.Multiply(vector);
		}
	}
}
