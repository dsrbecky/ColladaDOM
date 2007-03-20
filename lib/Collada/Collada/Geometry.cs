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
		public void Render(InstanceGeometry instanceGeometry)
		{
			if (this.Item is Mesh) {
				((Mesh)this.Item).Render(instanceGeometry);
			}
		}
	}
}
