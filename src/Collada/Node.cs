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
		public void Transform()
		{
			for(int i = 0; i < this.Items.Length; i++) {
				object item = this.Items[i];
				switch(this.ItemsElementName[i]) {
					case ItemsChoiceType2.lookat:
						double[] direction = ((Lookat)item).Values;
						Glu.gluLookAt(direction[0], direction[1], direction[2],  // eye
						              direction[3], direction[4], direction[5],  // target
						              direction[6], direction[7], direction[8]); // up
						break;
					case ItemsChoiceType2.matrix:
						Gl.glMultTransposeMatrixd(((Matrix)item).Values);
						break;
					case ItemsChoiceType2.rotate:
						double[] rotation = ((Rotate)item).Values;
						Gl.glRotated(rotation[3], rotation[0], rotation[1], rotation[2]);
						break;
					case ItemsChoiceType2.scale:
						double[] scaling = ((TargetableFloat3)item).Values;
						Gl.glScaled(scaling[0], scaling[1], scaling[2]);
						break;
					case ItemsChoiceType2.skew:
						double[] skewing = ((Skew)item).Values;
						// TODO: implement
						break;
					case ItemsChoiceType2.translate:
						double[] translation = ((TargetableFloat3)item).Values;
						Gl.glTranslated(translation[0], translation[1], translation[2]);
						break;
				}
			}
		}
		
		public void GetCameras(List<InstanceWithExtra> cameras, List<Node> nodePath)
		{
			nodePath.Add(this);
			foreach(InstanceWithExtra instanceCamera in this.InstanceCamera) {
				instanceCamera.NodePath = new List<Node>(nodePath);
				cameras.Add(instanceCamera);
			}
			foreach(Node node in this.Node1) {
				node.GetCameras(cameras, nodePath);
			}
			nodePath.RemoveAt(nodePath.Count - 1);
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
				foreach(InstanceWithExtra instanceLight in this.InstanceLight) {
					Light.IDs[instanceLight.Url.Remove(0,1)].Render();
				}
				foreach(Node node in this.Node1) {
					node.Render();
				}
			}
			Gl.glPopMatrix();
		}
	}
}
