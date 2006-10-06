// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.IO;
using System.Reflection;
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
		long framesRendered = 0;
		
		XmlSerializer serializer;
		COLLADA collada;
		
		static DateTime startTime = DateTime.Now;
		
		public static double globalScale = 1.0;
		public static Math.Matrix globalRotation = Math.Matrix.Identity;
		public static double viewportAspectRatio = 1d;
		
		public static TimeSpan RunningTime {
			get {
				return DateTime.Now - startTime;
			}
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			string filename;
			if (args.Length >= 1) {
				filename = args[0];
			} else {
				OpenFileDialog dlg = new OpenFileDialog();
				dlg.Filter = "Collada | *.dae";
				if (dlg.ShowDialog() == DialogResult.OK) {
					filename = dlg.FileName;
				} else {
					return;
				}
			}
			new MainForm().Show(filename);
		}
		
		~MainForm()
		{
			string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			string logFilename = Path.Combine(path, "PerformanceLog.txt");
			PerformanceLog.Root.Stop();
			StreamWriter file = new StreamWriter(logFilename);
			file.Write(PerformanceLog.Root.ToString());
			file.Close();
		}
		
		public void Show(string filename)
		{
			serializer = new XmlSerializer(typeof(COLLADA));
			using(FileStream file = new FileStream(filename, FileMode.Open)) {
				collada = (COLLADA)serializer.Deserialize(file);
			}
			
			Glut.glutInit();
			Glut.glutInitDisplayMode(Glut.GLUT_DOUBLE | Glut.GLUT_RGB | Glut.GLUT_DEPTH);
			Glut.glutInitWindowSize(600, 450);
			Glut.glutInitWindowPosition(100, 100);
			Glut.glutCreateWindow("Collada Viewer");
			Init();
			Glut.glutDisplayFunc(new Glut.DisplayCallback(Display));
			Glut.glutIdleFunc(new Glut.IdleCallback(Idle));
			Glut.glutKeyboardFunc(new Glut.KeyboardCallback(Keyboard));
			Glut.glutReshapeFunc(new Glut.ReshapeCallback(Reshape));
			Glut.glutMotionFunc(Motion);
			Glut.glutMouseFunc(Mouse);
			Glut.glutMouseWheelFunc(MouseWheel);
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
		
		int lastX, lastY;
		int rotateX, rotateY;
		
		void Motion(int x, int y)
		{
			rotateX += x - lastX;
			rotateY += y - lastY;
			
			// Load
			Gl.glMatrixMode(Gl.GL_MODELVIEW);
			Gl.glLoadIdentity();
			
			// Modify
			Gl.glRotated(rotateY * -0.5, 1, 0, 0);
			Gl.glRotated(rotateX * -0.5, 0, 1, 0);
			
			// Save
			double[] elements = new double[16];
			Gl.glGetDoublev(Gl.GL_MODELVIEW_MATRIX, elements);
			globalRotation = new Math.Matrix(elements);
			
			lastX = x;
			lastY = y;
		}
		
		void Mouse(int button, int state, int x, int y)
		{
			if (state == Glut.GLUT_DOWN) {
				switch (button) {
					case Glut.GLUT_LEFT_BUTTON:
						break;
					case Glut.GLUT_MIDDLE_BUTTON:
						break;
					case Glut.GLUT_RIGHT_BUTTON:
						break;
				}
			} else {
			}
			lastX = x;
			lastY = y;
		}
		
		void MouseWheel(int wheel, int direction, int x, int y)
		{
			if (direction > 0) {
				globalScale /= 1.2;
			} else {
				globalScale *= 1.2;
			}
		}

		void Reshape(int w, int h)
		{
			float size = 2000f;
			
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
			
			viewportAspectRatio = (double)h / (double)w;
		}
	}
}
