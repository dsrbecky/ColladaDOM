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
		public static ulong[] ParseIntArray(string text)
		{
			string[] txts = text.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
			ulong[] ret = new ulong[txts.Length];
			for(int i = 0; i < txts.Length; i++) {
				ret[i] = ulong.Parse(txts[i]);
			}
			return ret;
		}
	}
}
