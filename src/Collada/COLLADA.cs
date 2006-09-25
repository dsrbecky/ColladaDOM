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
	public partial class COLLADA
	{
		public void Render()
		{
			string sceneID = this.Scene.InstanceVisualScene.Url.Remove(0,1);
			VisualScene scene = VisualScene.IDs[sceneID];
			scene.Render();
		}
	}
}
