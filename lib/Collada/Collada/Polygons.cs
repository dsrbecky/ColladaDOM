// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Tao.OpenGl;

using Collada.Util;

namespace Collada
{
	public partial class Polygons: Primitives
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
			List<string> result = new List<string>();
			foreach(object p in this.Items) {
				if (p is string) result.Add((string)p);
			}
			return result;
		}
		
		protected override void MakeDisplayList()
		{
			foreach(int[] pArray in ps) {
				Gl.glBegin(Gl.GL_POLYGON);
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
