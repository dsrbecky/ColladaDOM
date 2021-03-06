// <file>
//     <copyright name="David Srbeck�" email="dsrbecky@gmail.com"/>
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
	public partial class Tristrips: Primitives
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
			return this.P;
		}
		
		public override List<Triangle> GetTriangles()
		{
			List<Triangle> triangles = new List<Triangle>();
			foreach (int[] pArray in ps) {
				for (int pBaseIndex = 0; pBaseIndex < pArray.Length - 2 * pStride; pBaseIndex += pStride) {
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
			foreach(int[] pArray in ps) {
				Gl.glBegin(Gl.GL_TRIANGLE_STRIP);
				{
					for(int pIndex = 0; pIndex < pArray.Length; pIndex += pStride) {
						EmitP(pArray, pIndex);
					}
				}
				Gl.glEnd();
				vertexCount   += pArray.Length / pStride;
				triangleCount += pArray.Length / pStride - 2;
			}
		}
	}
}
