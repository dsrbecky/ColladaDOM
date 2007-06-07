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
	public partial class Polylist: Primitives
	{
		protected override string GetMaterial()
		{
			return this.Material;
		}
		
		protected override List<InputLocalOffset> GetInputs()
		{
			return this.Input;
		}
		
		protected override string GetVcount()
		{
			return this.Vcount;
		}
		
		protected override List<string> GetPs()
		{
			return new List<string>(new string[] {this.P});
		}
		
		protected override void MakeDisplayList()
		{
			int pIndex = 0;
			foreach(int vcount in vcounts) {
				Gl.glBegin(Gl.GL_POLYGON);
				{
					for(int vertex = 0; vertex < vcount; vertex++) {
						EmitP(ps[0], pIndex);
						pIndex += pStride;
					}
				}
				Gl.glEnd();
				vertexCount   += vcount;
				triangleCount += vcount - 2;
			}
		}
	}
}
