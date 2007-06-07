// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Tao.OpenGl;
using Tao.DevIl;

using Collada.Util;

namespace Collada
{
	public partial class InstanceGeometry
	{
		public InstanceMaterial GetMaterial(string symbol)
		{
			if (this.BindMaterial != null) {
				foreach(InstanceMaterial material in this.BindMaterial.technique_common) {
					if (material.Symbol == symbol) {
						return material;
					}
				}
			}
			return null;
		}
		
		[XmlIgnore]
		public Geometry Geometry {
			get {
				return Geometry.IDs[this.Url.Remove(0,1)];
			}
		}
		
		public void Render()
		{
			this.Geometry.Render(this);
		}
	}
}
