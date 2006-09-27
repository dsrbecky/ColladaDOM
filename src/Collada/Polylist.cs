// <file>
//     <copyright name="David Srbeck�" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Tao.OpenGl;

namespace Collada
{
	public partial class Polylist
	{
		/// <summary>The vcount element contains a list of integers describing the number of sides for each polygon 
		///described by the polylist element. The vcount element may occur once.
		///</summary>
		[XmlIgnore]
		public ulong[] VcountArray {
			get {
				string[] txts = this.Vcount.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
				ulong[] ret = new ulong[txts.Length];
				for(int i = 0; i < txts.Length; i++) {
					ret[i] = ulong.Parse(txts[i]);
				}
				return ret;
			}
		}
		
		/// <summary>The p element may occur once.
		///</summary>
		[XmlIgnore]
		public ulong[] PArray {
			get {
				string[] txts = this.P.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
				ulong[] ret = new ulong[txts.Length];
				for(int i = 0; i < txts.Length; i++) {
					ret[i] = ulong.Parse(txts[i]);
				}
				return ret;
			}
		}
		
		public void Render(InstanceGeometry instanceGeometry)
		{
			if (this.Material != null) {
				instanceGeometry.UseMaterial(this.Material);
			}
			
			ulong  pStride = 0;
			ulong  positionOffset = 0;
			Source positionSource = null;
			ulong  normalOffset = 0;
			Source normalSource = null;
			foreach(InputLocalOffset input in this.Input) {
				pStride = System.Math.Max(pStride, input.Offset + 1);
				if (input.Semantic == "VERTEX") {
					Vertices vertices = Vertices.IDs[input.Source.Remove(0,1)];
					foreach(InputLocal vertexInput in vertices.Input) {
						if (vertexInput.Semantic == "POSITION") {
							positionOffset = input.Offset;
							positionSource = Source.IDs[vertexInput.Source.Remove(0,1)];
						}
						if (vertexInput.Semantic == "NORMAL") {
							normalOffset = input.Offset;
							normalSource = Source.IDs[vertexInput.Source.Remove(0,1)];
						}
					}
				}
				if (input.Semantic == "POSITION") {
					positionOffset = input.Offset;
					positionSource = Source.IDs[input.Source.Remove(0,1)];
				}
				if (input.Semantic == "NORMAL") {
					normalOffset = input.Offset;
					normalSource = Source.IDs[input.Source.Remove(0,1)];
				}
			}
			float[] positions = (positionSource.Item as FloatArray).ValuesAsFloats;
			float[] normals   = (normalSource.Item as FloatArray).ValuesAsFloats;
			
			
			ulong[] vcounts = this.VcountArray;
			ulong[] p = this.PArray;
			
			ulong pIndex = 0;
			foreach(ulong vcount in vcounts) {
				Gl.glBegin(Gl.GL_POLYGON);
				{
					for(ulong vertex = 0; vertex < vcount; vertex++) {
						ulong nomIndex = p[pIndex + normalOffset] * 3;
						Gl.glNormal3d(normals[nomIndex],
						              normals[nomIndex+1],
						              normals[nomIndex+2]);
						ulong posIndex = p[pIndex + positionOffset] * 3;
						Gl.glVertex3d(positions[posIndex],
						              positions[posIndex+1],
						              positions[posIndex+2]);
						pIndex += pStride;
					}
				}
				Gl.glEnd();
			}
		}
	}
}
