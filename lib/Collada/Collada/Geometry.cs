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
	public partial class Geometry
	{
		public void Preload()
		{
			if (this.Item is Mesh && !((Mesh)this.Item).FullyLoaded) {
				using(new PerformanceLog("Load geometry: " + this.Id, LogType.Loading)) {
					((Mesh)this.Item).Preload();
				}
			}
		}
		
		public void Render(InstanceGeometry instanceGeometry)
		{
			if (this.Item is Mesh) {
				((Mesh)this.Item).Render(instanceGeometry);
			}
		}
	}
}
