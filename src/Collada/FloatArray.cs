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
	public partial class FloatArray
	{
		[XmlIgnore]
		public float[] Floats {
			get {
				string[] txts = this.Text.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
				float[] ret = new float[txts.Length];
				for(int i = 0; i < txts.Length; i++) {
					ret[i] = float.Parse(txts[i]);
				}
				return ret;
			}
		}
	}
}
