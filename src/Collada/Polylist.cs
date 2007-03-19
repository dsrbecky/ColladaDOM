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
		
		int? displayList = null;
		
		public void Render(InstanceGeometry instanceGeometry)
		{
			using(PerformanceLog log2 = new PerformanceLog("Switch material")) {
				if (this.Material != null) {
					instanceGeometry.UseMaterial(this.Material);
				}
			}
			
			if (displayList.HasValue) {
				using(PerformanceLog log2 = new PerformanceLog("Call display list")) {
					Gl.glCallList(displayList.Value);
				}
				return;
			}
			
			ulong  pStride = 0;
			ulong  positionOffset = 0;
			Source positionSource = null;
			ulong  normalOffset = 0;
			Source normalSource = null;
			ulong  texcoordOffset = 0;
			Source texcoordSource = null;
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
						if (vertexInput.Semantic == "TEXCOORD") {
							texcoordOffset = input.Offset;
							texcoordSource = Source.IDs[vertexInput.Source.Remove(0,1)];
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
				if (input.Semantic == "TEXCOORD") {
					texcoordOffset = input.Offset;
					texcoordSource = Source.IDs[input.Source.Remove(0,1)];
				}
			}
			float[] positions = null;
			float[] normals = null;
			float[] texcoords = null;
			ulong[] vcounts = null;
			ulong[] p = null;
			using(PerformanceLog log = new PerformanceLog("Load data")) {
				if (positionSource != null) {
					positions = (positionSource.Item as FloatArray).ValuesAsFloats;
				}
				if (normalSource != null) {
					normals   = (normalSource.Item as FloatArray).ValuesAsFloats;
				}
				if (texcoordSource != null) {
					texcoords = (texcoordSource.Item as FloatArray).ValuesAsFloats;
				}
				vcounts = this.VcountArray;
				p = this.PArray;
			}
			
			using(PerformanceLog log = new PerformanceLog("Render")) {
				displayList = Gl.glGenLists(1);
				Gl.glNewList(displayList.Value, Gl.GL_COMPILE_AND_EXECUTE);
				{
					ulong pIndex = 0;
					foreach(ulong vcount in vcounts) {
						Gl.glBegin(Gl.GL_POLYGON);
						{
							for(ulong vertex = 0; vertex < vcount; vertex++) {
								if (texcoords != null) {
									ulong texCoordIndex = p[pIndex + texcoordOffset] * 2;
									Gl.glTexCoord2f(texcoords[texCoordIndex],
									                texcoords[texCoordIndex+1]);
								}
								if (normals != null) {
									ulong nomIndex = p[pIndex + normalOffset] * 3;
									Gl.glNormal3f(normals[nomIndex],
									              normals[nomIndex+1],
									              normals[nomIndex+2]);
								}
								ulong posIndex = p[pIndex + positionOffset] * 3;
								Gl.glVertex3f(positions[posIndex],
								              positions[posIndex+1],
								              positions[posIndex+2]);
								pIndex += pStride;
							}
						}
						Gl.glEnd();
					}
				}
				Gl.glEndList();
			}
		}
	}
}
