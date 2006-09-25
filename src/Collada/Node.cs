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
		public void Render()
		{
			foreach(InstanceGeometry geometry in this.InstanceGeometry) {
				geometry.Render();
			}
		}
	}
}
