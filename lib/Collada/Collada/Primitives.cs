// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
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
	public abstract class Primitives
	{
		bool wasLoaded;
		
		protected int     pStride;
		
		protected int     positionOffset;
		protected Source  positionSource;
		protected float[] positions;
		
		protected int     normalOffset;
		protected Source  normalSource;
		protected float[] normals;
		
		protected int     texcoordOffset;
		protected Source  texcoordSource;
		protected float[] texcoords;
		
		protected int[]   vcounts;
		protected int[][] ps;
		
		protected int? displayList;
		
		protected int vertexCount;
		protected int triangleCount;
		
		[XmlIgnore]
		public int VertexCount {
			get { return vertexCount; }
		}
		
		[XmlIgnore]
		public int TriangleCount {
			get { return triangleCount; }
		}
		
		protected abstract string GetMaterial();
		
		protected abstract List<InputLocalOffset> GetInputs();
		
		protected virtual string GetVcount()
		{
			return null;
		}
		
		protected abstract List<string> GetPs();
		
		public virtual List<Triangle> GetTriangles()
		{
			return new List<Triangle>();
		}
		
		protected void LoadData()
		{
			foreach(InputLocalOffset input in GetInputs()) {
				pStride = System.Math.Max(pStride, (int)input.Offset + 1);
				if (input.Semantic == "VERTEX") {
					Vertices vertices = Vertices.IDs[input.Source.Remove(0,1)];
					foreach(InputLocal vertexInput in vertices.Input) {
						if (vertexInput.Semantic == "POSITION") {
							positionOffset = (int)input.Offset;
							positionSource = Source.IDs[vertexInput.Source.Remove(0,1)];
						}
						if (vertexInput.Semantic == "NORMAL") {
							normalOffset = (int)input.Offset;
							normalSource = Source.IDs[vertexInput.Source.Remove(0,1)];
						}
						if (vertexInput.Semantic == "TEXCOORD") {
							texcoordOffset = (int)input.Offset;
							texcoordSource = Source.IDs[vertexInput.Source.Remove(0,1)];
						}
					}
				}
				if (input.Semantic == "POSITION") {
					positionOffset = (int)input.Offset;
					positionSource = Source.IDs[input.Source.Remove(0,1)];
				}
				if (input.Semantic == "NORMAL") {
					normalOffset = (int)input.Offset;
					normalSource = Source.IDs[input.Source.Remove(0,1)];
				}
				if (input.Semantic == "TEXCOORD") {
					texcoordOffset = (int)input.Offset;
					texcoordSource = Source.IDs[input.Source.Remove(0,1)];
				}
			}
			
			if (positionSource != null) {
				positions = (positionSource.Item as FloatArray).ValuesAsFloats;
			}
			if (normalSource != null) {
				normals   = (normalSource.Item as FloatArray).ValuesAsFloats;
			}
			if (texcoordSource != null) {
				texcoords = (texcoordSource.Item as FloatArray).ValuesAsFloats;
			}
			if (GetVcount() != null) {
				vcounts = Utils.ParseIntArray(GetVcount());
			}
			List<string> psList = GetPs();
			ps = new int[psList.Count][];
			for(int i = 0; i < ps.Length; i++) {
				ps[i] = Utils.ParseIntArray(psList[i]);
			}
			
			wasLoaded = true;
		}
		
		protected abstract void MakeDisplayList();
		
		public void Render(InstanceGeometry instanceGeometry)
		{
			if (!wasLoaded) {
				using(PerformanceLog log = new PerformanceLog("Load data")) {
					LoadData();
				}
			}
			
			using(PerformanceLog log = new PerformanceLog("Switch material")) {
				if (this.GetMaterial() != null) {
					instanceGeometry.UseMaterial(this.GetMaterial());
				}
			}
			
			if (!displayList.HasValue) {
				using(PerformanceLog log = new PerformanceLog("Make display list")) {
					displayList = Gl.glGenLists(1);
					Gl.glNewList(displayList.Value, Gl.GL_COMPILE);
					{
						MakeDisplayList();
					}
					Gl.glEndList();
				}
			}
			
			using(PerformanceLog log = new PerformanceLog("Call display list")) {
				Gl.glCallList(displayList.Value);
			}
		}
		
		protected void GlTexCoord(int sourceIndex)
		{
			Gl.glTexCoord2f(texcoords[sourceIndex * 2],
			                texcoords[sourceIndex * 2 + 1]);
		}
		
		protected void GlNormal(int sourceIndex)
		{
			Gl.glNormal3f(normals[sourceIndex * 3],
			              normals[sourceIndex * 3 + 1],
			              normals[sourceIndex * 3 + 2]);
		}
		
		protected void GlVertex(int sourceIndex)
		{
			Gl.glVertex3f(positions[sourceIndex * 3],
			              positions[sourceIndex * 3 + 1],
			              positions[sourceIndex * 3 + 2]);
		}
		
		protected void EmitP(int[] pArray, int pBaseIndex)
		{
			if (texcoords != null) {
				GlTexCoord(pArray[pBaseIndex + texcoordOffset]);
			}
			if (normals != null) {
				GlNormal(pArray[pBaseIndex + normalOffset]);
			}
			GlVertex(pArray[pBaseIndex + positionOffset]);
		}
	}
}
