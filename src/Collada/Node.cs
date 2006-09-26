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
	public partial class Node
	{
		void Transform()
		{
			foreach(object item in this.Items) {
				Lookat lookat = item as Lookat;
				if (lookat != null) {
					double[] direction = lookat.Values;
					Glu.gluLookAt(direction[0], direction[1], direction[2],  // eye
					              direction[3], direction[4], direction[5],  // target
					              direction[6], direction[7], direction[8]); // up
				}
				Matrix matrix = item as Matrix;
				if (matrix != null) {
					Gl.glMultTransposeMatrixd(matrix.Values);
				}
				Rotate rotate = item as Rotate;
				if (rotate != null) {
					double[] rotation = rotate.Values;
					Gl.glRotated(rotation[3], rotation[0], rotation[1], rotation[2]);
				}
				TargetableFloat3 scale = item as TargetableFloat3;
				if (scale != null) {
					double[] scaling = scale.Values;
					Gl.glScaled(scaling[0], scaling[1], scaling[2]);
				}
				Skew skew = item as Skew;
				if (skew != null) {
					double[] skewing = skew.Values;
					
					// TODO: implement
				}
				TargetableFloat3 translate = item as TargetableFloat3;
				if (translate != null) {
					double[] translation = translate.Values;
					Gl.glTranslated(translation[0], translation[1], translation[2]);
				}
			}
		}
		
		public void SetupLights(ref int lightCount)
		{
			Gl.glPushMatrix();
			{
				Transform();
				foreach(InstanceWithExtra instanceLight in this.InstanceLight) {
					Light.IDs[instanceLight.Url.Remove(0,1)].Setup(ref lightCount);
				}
				foreach(Node node in this.Node1) {
					node.SetupLights(ref lightCount);
				}
			}
			Gl.glPopMatrix();
		}
		
		public void Render()
		{
			Gl.glPushMatrix();
			{
				Transform();
				foreach(InstanceGeometry geometry in this.InstanceGeometry) {
					geometry.Render();
				}
				foreach(Node node in this.Node1) {
					node.Render();
				}
			}
			Gl.glPopMatrix();
		}
	}
}
