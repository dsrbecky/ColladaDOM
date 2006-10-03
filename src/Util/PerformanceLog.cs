// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;

namespace Collada
{
	public class PerformanceLog: IDisposable
	{
		public static readonly PerformanceLog Root;
		static PerformanceLog current;
		
		string description;
		int level;
		DateTime startTime;
		DateTime endTime;
		PerformanceLog parent;
		List<PerformanceLog> childs = new List<PerformanceLog>();
		
		public DateTime StartTime {
			get {
				return startTime;
			}
		}
		
		public DateTime EndTime {
			get {
				return endTime;
			}
		}
		
		public TimeSpan Duration {
			get {
				return EndTime - StartTime;
			}
		}
		
		static PerformanceLog()
		{
			current = null;
			Root = new PerformanceLog("Root");
			current = Root;
		}
		
		public PerformanceLog(string description)
		{
			this.description = description;
			this.startTime = HighPrecisionTimer.Now;
			this.parent = current;
			current = this;
			if (parent != null) {
				parent.childs.Add(this);
				this.level = parent.level + 1;
			} else {
				this.level = 0;
			}
		}
		
		public void Dispose()
		{
			Stop();
		}
		
		public void Stop()
		{
			endTime = HighPrecisionTimer.Now;
			current = parent;
		}
		
		static string Format(int level, string description, TimeSpan time, TimeSpan parentTime)
		{
			double fraction = time.TotalMilliseconds / parentTime.TotalMilliseconds;
			string markers = "#%*=>";
			char marker = markers.ToCharArray()[level % markers.Length];
			return String.Format("{0}{1,-14} - {2,-14} {3,-4} {4}\r\n",
			                     new String(' ', level * 2),
			                     description,
			                     time.TotalMilliseconds + " ms",
			                     String.Format("{0:f0}%", fraction * 100),
			                     new String(marker, (int)(fraction * 50)));
		}
		
		public override string ToString()
		{
			string text = Format(level, description, Duration, parent != null? parent.Duration: Duration);
			
			TimeSpan otherTime = this.Duration;
			foreach(PerformanceLog child in childs) {
				text += child.ToString();
				otherTime -= child.Duration;
			}
			
			if (childs.Count > 0) {
				text += Format(level + 1,"Other", otherTime, Duration);
			}
			
			return text;
		}
	}
}
