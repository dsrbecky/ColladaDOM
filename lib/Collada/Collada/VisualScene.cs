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
	public partial class VisualScene
	{
		public void Render()
		{
			Gl.glMatrixMode(Gl.GL_MODELVIEW);
			Gl.glLoadIdentity();
			
			// Adjust scene
			Gl.glLoadMatrixd(GlobalSettings.GlobalRotation.Elements);
			Gl.glScaled(GlobalSettings.GlobalScale, GlobalSettings.GlobalScale, GlobalSettings.GlobalScale);
			
			// Setup camera
			using(new PerformanceLog("Setup camera")) {
				List<InstanceWithExtra> cameras = new List<InstanceWithExtra>();
				List<Node> nodePath = new List<Node>();
				foreach(Node node in this.Node) {
					node.GetCameras(cameras, nodePath);
				}
				if (cameras.Count > 0) {
					Camera camera = Camera.IDs[cameras[0].Url.Remove(0,1)];
					foreach(Node node in cameras[0].NodePath) {
						node.Transform();
					}
					camera.Setup();
				}
			}
			
			// Setup lights
			using(new PerformanceLog("Setup lights")) {
				int lightCount = 0;
				foreach(Node node in this.Node) {
					node.SetupLights(ref lightCount);
				}
			}
			
			// Render
			using(new PerformanceLog("Render")) {
				foreach(Node node in this.Node) {
					node.Render();
				}
			}
		}
	}
}
