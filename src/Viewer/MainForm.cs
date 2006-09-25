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

namespace Viewer
{
	public class MainForm
    {
        [STAThread]
        public static void Main(string[] args)
        {
        	new MainForm().Show();
        }
        
        public void Show()
        {
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
        }
		
        void Display()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            
            Gl.glBegin(Gl.GL_POLYGON);
            {
            	Gl.glColor3f(1.0f, 0.0f, 0.0f); Gl.glVertex3d(-1.0f, -1.0f, 0.0f);
            	Gl.glColor3f(0.0f, 1.0f, 0.0f); Gl.glVertex3d(+1.0f, -1.0f, 0.0f);
            	Gl.glColor3f(0.0f, 0.0f, 1.0f); Gl.glVertex3d(+1.0f, +1.0f, 0.0f);
            	Gl.glColor3f(1.0f, 1.0f, 1.0f); Gl.glVertex3d(-1.0f, +1.0f, 0.0f);
            }
            Gl.glEnd();
            
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
            Gl.glViewport(0, 0, w, h);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            if(w <= h) {
                Gl.glOrtho(-1.5, 1.5, -1.5 * (float) h / (float) w, 1.5 * (float) h / (float) w, -10.0, 10.0);
            } else {
                Gl.glOrtho(-1.5 * (float) w / (float) h, 1.5 * (float) w / (float) h, -1.5, 1.5, -10.0, 10.0);
            }
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity ();
        }
    }
}
