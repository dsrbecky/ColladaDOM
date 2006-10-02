// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;

namespace Viewer
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
		
		public override string ToString()
		{
			string text = String.Empty;
			text = new String(' ', level * 2) + description + " - " + Duration.TotalMilliseconds.ToString() + " ms\r\n";
			foreach(PerformanceLog child in childs) {
				text += child.ToString();
			}
			return text;
		}
	}
}
