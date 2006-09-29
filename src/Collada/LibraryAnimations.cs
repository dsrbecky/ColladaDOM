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
	public partial class LibraryAnimations
	{
		public void Animate()
		{
			foreach(Animation animation in this.Animation) {
				animation.Animate();
			}
		}
	}
}
