// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Tao.OpenGl;

namespace Collada
{
	public partial class Mesh
	{
		public void Render()
		{
			float[] position = (this.Source[0].Item as FloatArray).Floats;
			float[] normals  = (this.Source[1].Item as FloatArray).Floats;
			int[] vcount = (this.Items[0] as Polylist).VcountArray;
			int[] p = (this.Items[0] as Polylist).PArray;
			
			float scale = 1/200f;
			
			int pIndex = 0;
			for(int polygon = 0; polygon < vcount.Length; polygon++) {
				Gl.glBegin(Gl.GL_POLYGON);
				{
					for(int vertex = 0; vertex < vcount[polygon]; vertex++) {
						Gl.glColor3f(1.0f - 0.2f * vertex, 1.0f - 0.2f * vertex, 1.0f - 0.2f * vertex);
						int posIndex = p[pIndex++] * 3;
						Gl.glVertex3d(position[posIndex] * scale,
						              position[posIndex+1] * scale,
						              position[posIndex+2] * scale);
						int nomIndex = p[pIndex++] * 3;
						Gl.glNormal3d(normals[nomIndex],
						              normals[nomIndex+1],
						              normals[nomIndex+2]);
					}
				} 
				Gl.glEnd();
			}
		}
	}
}
