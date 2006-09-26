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
	public partial class VisualScene
	{
		public void Render()
		{
			int lightCount = 0;
			foreach(Node node in this.Node) {
				node.SetupLights(ref lightCount);
			}
			foreach(Node node in this.Node) {
				node.Render();
			}
		}
	}
}
