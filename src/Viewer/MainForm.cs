// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.DevIl;

using Collada;

namespace Viewer
{
	public class MainForm
	{
		string filename = @"..\sample_data\seymourplane.dae";
		
		long framesRendered = 0;
		
		XmlSerializer serializer;
		COLLADA collada;
		
		static DateTime startTime = DateTime.Now;
		
		public static TimeSpan RunningTime {
			get {
				return DateTime.Now - startTime;
			}
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			new MainForm().Show();
		}
		
		~MainForm()
		{
			PerformanceLog.Root.Stop();
			StreamWriter file = new StreamWriter("PerformanceLog.txt");
			file.Write(PerformanceLog.Root.ToString());
			file.Close();
		}
		
		public void Show()
		{
			serializer = new XmlSerializer(typeof(COLLADA));
			using(FileStream file = new FileStream(filename, FileMode.Open)) {
				collada = (COLLADA)serializer.Deserialize(file);
			}
			
			Glut.glutInit();
			Glut.glutInitDisplayMode(Glut.GLUT_DOUBLE | Glut.GLUT_RGB | Glut.GLUT_DEPTH);
			Glut.glutInitWindowSize(500, 500);
			Glut.glutInitWindowPosition(100, 100);
			Glut.glutCreateWindow("Collada Viewer");
			Init();
			Glut.glutDisplayFunc(new Glut.DisplayCallback(Display));
			Glut.glutIdleFunc(new Glut.IdleCallback(Idle));
			Glut.glutKeyboardFunc(new Glut.KeyboardCallback(Keyboard));
			Glut.glutReshapeFunc(new Glut.ReshapeCallback(Reshape));
			Glut.glutMainLoop();
		}
		
		void Init()
		{
			Gl.glClearColor(0.449f, 0.449f, 0.449f, 0.0f);
			Gl.glShadeModel(Gl.GL_SMOOTH);
			
			Gl.glEnable(Gl.GL_DEPTH_TEST);
			Gl.glEnable(Gl.GL_LIGHTING);
			
			Il.ilInit();
			Ilut.ilutRenderer(Ilut.ILUT_OPENGL);
		}
		
		void Display()
		{
			using(PerformanceLog log = new PerformanceLog("Frame " + (framesRendered++))) {
				using(PerformanceLog log2 = new PerformanceLog("Clear")) {
					Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
				}
				
				Gl.glMatrixMode(Gl.GL_MODELVIEW);
				Gl.glLoadIdentity();
	//			double angle = (RunningTime.TotalSeconds * 360d) / 4d;
	//			Gl.glRotated(angle * 0.7, 0, 1.0, 0);
	//			Gl.glRotated(angle * 0.3, 0, 1.0, 0.2);
				
				using(PerformanceLog log2 = new PerformanceLog("Render")) {
					collada.Render();
				}
				
				using(PerformanceLog log2 = new PerformanceLog("Swap")) {
					Glut.glutSwapBuffers();
				}
				
				log.Stop();
				Glut.glutSetWindowTitle(String.Format("Collada Viewer - {0:f1} FPS", 1 / log.Duration.TotalSeconds));
			}
		}
		
		void Idle()
		{
			Glut.glutPostRedisplay();
		}
		
		void Keyboard(byte key, int x, int y)
		{
			switch(key) {
				case 27:
					Environment.Exit(0);
					break;
			}
		}

		void Reshape(int w, int h)
		{
			float size = 500f;
			
			Gl.glViewport(0, 0, w, h);
			Gl.glMatrixMode(Gl.GL_PROJECTION);
			Gl.glLoadIdentity();
			if(w <= h) {
				Gl.glOrtho(-size, size, -size * (float) h / (float) w, size * (float) h / (float) w, -10.0 * size, 10.0 * size);
			} else {
				Gl.glOrtho(-size * (float) w / (float) h, size * (float) w / (float) h, -size, size, -10.0 * size, 10.0 * size);
			}
			Gl.glMatrixMode(Gl.GL_MODELVIEW);
			Gl.glLoadIdentity ();
		}
	}
}
