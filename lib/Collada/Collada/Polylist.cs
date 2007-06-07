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
			ulong pIndex = 0;
			foreach(ulong vcount in vcounts) {
				Gl.glBegin(Gl.GL_POLYGON);
				{
					for(ulong vertex = 0; vertex < vcount; vertex++) {
						if (texcoords != null) {
							GlTexCoord(ps[0][pIndex + texcoordOffset]);
						}
						if (normals != null) {
							GlNormal(ps[0][pIndex + normalOffset]);
						}
						GlVertex(ps[0][pIndex + positionOffset]);
						pIndex += pStride;
					}
				}
				Gl.glEnd();
			}
		}
	}
}
