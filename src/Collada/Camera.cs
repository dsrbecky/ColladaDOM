// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Tao.OpenGl;

namespace Collada
{
	public partial class Camera
	{
		public void Setup()
		{
			// Set camera optics
			Gl.glMatrixMode(Gl.GL_PROJECTION);
			Gl.glLoadIdentity();
			
			CameraOpticsTechniqueCommonPerspective perspective = this.Optics.TechniqueCommon.Item as CameraOpticsTechniqueCommonPerspective;
			if (perspective != null) {
				double yFov, aspectRatio, zNear, zFar;
				perspective.GetCameraParameters(out yFov, out aspectRatio, out zNear, out zFar);
				Glu.gluPerspective(yFov, 1 / aspectRatio, zNear, zFar);
			}
			
			CameraOpticsTechniqueCommonOrthographic orthographic = this.Optics.TechniqueCommon.Item as CameraOpticsTechniqueCommonOrthographic;
			if (orthographic != null) {
				double xMag, yMag, zNear, zFar;
				orthographic.GetCameraParameters(out xMag, out yMag, out zNear, out zFar);
				Gl.glOrtho(-xMag, xMag, -yMag, yMag, zNear, zFar);
			}
			
			// Set camera location and orientation
			double[] elements = new double[16];
			Gl.glGetDoublev(Gl.GL_MODELVIEW_MATRIX, elements);
			Math.Matrix modelView = new Math.Matrix(elements);
			
			Math.Vector cameraPosition = modelView.Multiply(Math.Vector.Origin);
			Math.Vector targetPosition = modelView.Multiply(new Math.Vector(0, 0, -1, 1));
			Math.Vector upDirection = modelView.Multiply(new Math.Vector(0, 1, 0, 0));
			
			Gl.glMatrixMode(Gl.GL_MODELVIEW);
			Gl.glLoadIdentity();
			Glu.gluLookAt(cameraPosition.X, cameraPosition.Y, cameraPosition.Z,
			              targetPosition.X, targetPosition.Y, targetPosition.Z,
			              upDirection.X, upDirection.Y, upDirection.Z);
		}
	}
}
