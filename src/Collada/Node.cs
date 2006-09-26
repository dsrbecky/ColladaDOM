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
		public void SetupLights(ref int lightCount)
		{
			foreach(InstanceWithExtra instanceLight in this.InstanceLight) {
				Light.IDs[instanceLight.Url.Remove(0,1)].Setup(ref lightCount);
			}
			foreach(Node node in this.Node1) {
				node.SetupLights(ref lightCount);
			}
		}
		
		public void Render()
		{
			foreach(InstanceGeometry geometry in this.InstanceGeometry) {
				geometry.Render();
			}
			foreach(Node node in this.Node1) {
				node.Render();
			}
		}
	}
}
