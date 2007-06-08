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
	public partial class Mesh
	{
		public void Render(InstanceGeometry instanceGeometry)
		{
			using(new PerformanceLog("Render geometry: " + instanceGeometry.Url)) {
				foreach(object item in this.Items) {
					if (item is Primitives) {
						((Primitives)item).Render(instanceGeometry);
					}
				}
			}
		}
	}
}
