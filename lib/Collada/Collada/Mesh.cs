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
		bool fullyLoaded;
		
		public bool FullyLoaded {
			get { return fullyLoaded; }
		}
		
		
		public IEnumerable<Primitives> Primitives {
			get {
				if (this.Items != null) {
					foreach(object item in this.Items) {
						if (item is Primitives) {
							yield return (Primitives)item;
						}
					}
				}
			}
		}
		
		public void Preload()
		{
			if (fullyLoaded) return;
			
			foreach(Primitives primitive in this.Primitives) {
				primitive.LoadData();
				primitive.LoadDisplayList();
			}
			
			fullyLoaded = true;
		}
		
		public void Render(InstanceGeometry instanceGeometry)
		{
			using(new PerformanceLog("Render geometry: " + instanceGeometry.Url)) {
				foreach(Primitives primitive in this.Primitives) {
					primitive.Render(instanceGeometry);
				}
			}
		}
	}
}
