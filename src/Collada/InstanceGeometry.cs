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
	public partial class InstanceGeometry
	{
		public void Render()
		{
			string geometryID = this.Url.Remove(0,1);
			Geometry geometry = Geometry.IDs[geometryID];
			geometry.Render();
		}
	}
}
