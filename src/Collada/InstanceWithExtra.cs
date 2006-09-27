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
	public partial class InstanceWithExtra
	{
		List<Node> nodePath;
		
		[XmlIgnore]
		public List<Node> NodePath {
			get {
				return nodePath;
			}
			set {
				nodePath = value;
			}
		}
	}
}
