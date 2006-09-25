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
	public partial class Polylist
	{
		/// <summary>The vcount element contains a list of integers describing the number of sides for each polygon 
		///described by the polylist element. The vcount element may occur once.
		///</summary>
		[XmlIgnore]
		public int[] VcountArray {
			get {
				string[] txts = this.Vcount.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
				int[] ret = new int[txts.Length];
				for(int i = 0; i < txts.Length; i++) {
					ret[i] = int.Parse(txts[i]);
				}
				return ret;
			}
		}
		
		/// <summary>The p element may occur once.
		///</summary>
		[XmlIgnore]
		public int[] PArray {
			get {
				string[] txts = this.P.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
				int[] ret = new int[txts.Length];
				for(int i = 0; i < txts.Length; i++) {
					ret[i] = int.Parse(txts[i]);
				}
				return ret;
			}
		}
	}
}
