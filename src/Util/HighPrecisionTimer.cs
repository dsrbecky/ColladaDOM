// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Runtime.InteropServices;

namespace Viewer
{
	public static class HighPrecisionTimer
	{
		[DllImport("kernel32.dll")]
		static extern int QueryPerformanceFrequency(out long frequency);
		
		[DllImport("kernel32.dll")]
		static extern int QueryPerformanceCounter(out long count);
		
		static DateTime startTime;
		static long startTicks;
		
		static HighPrecisionTimer()
		{
			startTime = DateTime.Now;
			startTicks = Ticks;
		}
		
		static long Ticks {
			get {
				long frequency;
				long count;
				QueryPerformanceFrequency(out frequency);
				QueryPerformanceCounter(out count);
				return (count * TimeSpan.TicksPerSecond) / frequency;
			}
		}
		
		public static DateTime Now {
			get {
				return startTime.AddTicks(Ticks - startTicks);
			}
		}
	}
}
