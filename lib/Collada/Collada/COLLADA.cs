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
	public partial class COLLADA
	{
		[XmlIgnore]
		public LibraryAnimations LibraryAnimations {
			get {
				foreach(object item in this.Items) {
					if (item is LibraryAnimations) {
						return (LibraryAnimations)item;
					}
				}
				return null;
			}
		}
		
		public void Render()
		{
			using(PerformanceLog log2 = new PerformanceLog("Animate")) {
				if (this.LibraryAnimations != null) {
					this.LibraryAnimations.Animate();
				}
			}
			
			string sceneID = this.Scene.InstanceVisualScene.Url.Remove(0,1);
			VisualScene scene = VisualScene.IDs[sceneID];
			scene.Render();
		}
	}
}
