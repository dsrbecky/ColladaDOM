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
	public partial class Tristrips: Primitives
	{
		protected override string GetMaterial()
		{
			return this.Material;
		}
		
		protected override List<InputLocalOffset> GetInputs()
		{
			return this.Input;
		}
		
		protected override List<string> GetPs()
		{
			return this.P;
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
			}
		}
	}
}
