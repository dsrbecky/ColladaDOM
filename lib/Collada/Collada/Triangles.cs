// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Tao.OpenGl;

using Collada.Util;
using Collada.Math;

namespace Collada
{
	public partial class Triangles: Primitives
	{
		public override string GetMaterial()
		{
			return this.Material;
		}
		
		public override List<InputLocalOffset> GetInputs()
		{
			return this.Input;
		}
		
		protected override List<string> GetPs()
		{
			return new List<string>(new string[] {this.P});
		}
		
		public override List<Triangle> GetTriangles()
		{
			List<Triangle> triangles = new List<Triangle>();
			foreach (int[] pArray in ps) {
				for (int pBaseIndex = 0; pBaseIndex < pArray.Length; pBaseIndex += 3 * pStride) {
					int indexA = pArray[pBaseIndex + 0 * pStride + positionOffset];
					int indexB = pArray[pBaseIndex + 1 * pStride + positionOffset];
					int indexC = pArray[pBaseIndex + 2 * pStride + positionOffset];
					Vector a = new Vector(positions[3 * indexA], positions[3 * indexA + 1], positions[3 * indexA + 2]);
					Vector b = new Vector(positions[3 * indexB], positions[3 * indexB + 1], positions[3 * indexB + 2]);
					Vector c = new Vector(positions[3 * indexC], positions[3 * indexC + 1], positions[3 * indexC + 2]);
					triangles.Add(new Triangle(a, b, c));
				}
			}
			return triangles;
		}
		
		protected override void MakeDisplayList()
		{
			Gl.glBegin(Gl.GL_TRIANGLES);
			{
				for(int pIndex = 0; pIndex < ps[0].Length; pIndex += pStride) {
					EmitP(ps[0], pIndex);
				}
			}
			Gl.glEnd();
			vertexCount   += ps[0].Length / pStride;
			triangleCount += ps[0].Length / (3 * pStride);
		}
	}
}
