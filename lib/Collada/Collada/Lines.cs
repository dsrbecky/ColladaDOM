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
	public partial class Lines: Primitives
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
		
		protected override void MakeDisplayList()
		{
			Gl.glBegin(Gl.GL_LINES);
			{
				for(int pIndex = 0; pIndex < ps[0].Length; pIndex += pStride) {
					EmitP(ps[0], pIndex);
				}
			}
			Gl.glEnd();
			vertexCount += ps[0].Length / pStride;
		}
	}
}
