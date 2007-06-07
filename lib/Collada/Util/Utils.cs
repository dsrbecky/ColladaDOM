// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections;
using System.Collections.Generic;

namespace Collada.Util
{
	public static class Utils
	{
		public static int[] ParseIntArray(string text)
		{
			string[] txts = text.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
			int[] ret = new int[txts.Length];
			for(int i = 0; i < txts.Length; i++) {
				ret[i] = int.Parse(txts[i]);
			}
			return ret;
		}
	}
}
