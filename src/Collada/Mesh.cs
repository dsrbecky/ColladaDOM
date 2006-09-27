// <file>
//     <copyright name="David Srbeck�" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Tao.OpenGl;

namespace Collada
{
	public partial class Mesh
	{
		public void Render(InstanceGeometry instanceGeometry)
		{
			foreach(object item in this.Items) {
				if (item is Polylist) {
					((Polylist)item).Render(instanceGeometry);
				}
			}
		}
	}
}