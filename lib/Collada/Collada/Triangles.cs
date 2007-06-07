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
	public partial class Triangles: Primitives
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
			return new List<string>(new string[] {this.P});
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
		}
	}
}
