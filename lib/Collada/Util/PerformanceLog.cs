// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace Collada.Util
{
	public class PerformanceLog: IDisposable
	{
		public static readonly PerformanceLog Root;
		static PerformanceLog current;
		
		string description;
		LogType logType;
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
		
		public LogType LogType {
			get {
				return logType;
			}
		}
		
		static PerformanceLog()
		{
			current = null;
			Root = new PerformanceLog("Root");
			current = Root;
		}
		
		public PerformanceLog(string description): this(description, LogType.Default)
		{
			
		}
		
		public PerformanceLog(string description, LogType logType)
		{
			this.description = description;
			this.logType = logType;
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
			if (this.LogType == LogType.Loading) {
				string msg = String.Format("PerfLog: {0} ({1:f1} ms)", description, this.Duration.TotalMilliseconds);
				System.Console.WriteLine(msg);
				System.Diagnostics.Debug.WriteLine(msg);
			}
		}
		
		public static PerformanceLog Begin(string description)
		{
			return new PerformanceLog(description);
		}
		
		public static void End()
		{
			current.Stop();
		}
		
		static string Format(int level, string description, TimeSpan time, TimeSpan parentTime)
		{
			double fraction = time.TotalMilliseconds / parentTime.TotalMilliseconds;
			string markers = "#%*=>";
			char marker = markers.ToCharArray()[level % markers.Length];
			return String.Format("{0}{1,-20} - {2,-14} {3,-4} {4}\r\n",
			                     new String(' ', level * 2),
			                     description,
			                     time.TotalMilliseconds + " ms",
			                     String.Format("{0:f0}%", fraction * 100),
			                     new String(marker, (int)(fraction * 50)));
		}
		
		public static void WriteLogFile()
		{
			WriteLogFile("PerformanceLog.txt");
		}
		
		public static void WriteLogFile(string filename)
		{
			string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			string logFilename = Path.Combine(path, filename);
			PerformanceLog.Root.Stop();
			StreamWriter file = new StreamWriter(logFilename);
			file.Write(PerformanceLog.Root.ToString());
			file.Close();
		}
		
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			ToString(stringBuilder);
			return stringBuilder.ToString();
		}
		
		void ToString(StringBuilder stringBuilder)
		{
			stringBuilder.Append(Format(level, description, Duration, parent != null? parent.Duration: Duration));
			
			TimeSpan otherTime = this.Duration;
			foreach(PerformanceLog child in childs) {
				child.ToString(stringBuilder);
				otherTime -= child.Duration;
			}
			
			if (childs.Count > 0) {
				stringBuilder.Append(Format(level + 1,"Other", otherTime, Duration));
			}
		}
	}
}
