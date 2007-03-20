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
	public static class GlobalSettings
	{
		static TimeSpan runningTime = TimeSpan.Zero;
		static double viewportAspectRatio = 1.0;
		static Collada.Math.Matrix globalRotation = Collada.Math.Matrix.Identity;
		static double globalScale = 1.0;
		
		public static TimeSpan RunningTime {
			get { return runningTime; }
			set { runningTime = value; }
		}
		
		public static double ViewportAspectRatio {
			get { return viewportAspectRatio; }
			set { viewportAspectRatio = value; }
		}
		
		public static Collada.Math.Matrix GlobalRotation {
			get { return globalRotation; }
			set { globalRotation = value; }
		}
		
		public static double GlobalScale {
			get { return globalScale; }
			set { globalScale = value; }
		}
	}
}
