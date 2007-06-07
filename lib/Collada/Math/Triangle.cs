// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;

namespace Collada.Math
{
	public class Triangle
	{
		Vector a;
		Vector b;
		Vector c;
		
		public Vector A {
			get { return a; }
		}
		
		public Vector B {
			get { return b; }
		}
		
		public Vector C {
			get { return c; }
		}
		
		public Triangle(Vector a, Vector b, Vector c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}
	}
}
