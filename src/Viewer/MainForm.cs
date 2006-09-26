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

using Collada;

namespace Viewer
{
	public class MainForm
	{
		string filename = @"..\..\collada\sample_data\multimtl.dae";
		
		XmlSerializer serializer;
		COLLADA collada;
		
		[STAThread]
		public static void Main(string[] args)
		{
			new MainForm().Show();
		}
		
		public void Show()
		{
			serializer = new XmlSerializer(typeof(COLLADA));
			using(FileStream file = new FileStream(filename, FileMode.Open)) {
				collada = (COLLADA)serializer.Deserialize(file);
			}
			
			Glut.glutInit();
			Glut.glutInitDisplayMode(Glut.GLUT_SINGLE | Glut.GLUT_RGB | Glut.GLUT_DEPTH);
			Glut.glutInitWindowSize(500, 500);
			Glut.glutInitWindowPosition(100, 100);
			Glut.glutCreateWindow("Collada Viewer");
			Init();
			Glut.glutDisplayFunc(new Glut.DisplayCallback(Display));
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
		}
		
		void Display()
		{
			Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
			
			collada.Render();
			
			Gl.glMatrixMode(Gl.GL_MODELVIEW);
			Gl.glRotated(15, 2, 3, 0);
			
			Gl.glFlush();
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
			float size = 200f;
			
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
