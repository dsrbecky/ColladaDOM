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
	public partial class Light
	{
		void ResetLight(int light)
		{
			// OpenGL default values
			Gl.glLightfv(light, Gl.GL_AMBIENT,        new float[] {0.0f, 0.0f, 0.0f, 1.0f});
			Gl.glLightfv(light, Gl.GL_DIFFUSE,        new float[] {1.0f, 1.0f, 1.0f, 1.0f});
			Gl.glLightfv(light, Gl.GL_SPECULAR,       new float[] {1.0f, 1.0f, 1.0f, 1.0f});
			Gl.glLightfv(light, Gl.GL_POSITION,       new float[] {0.0f, 0.0f, 1.0f, 0.0f});
			Gl.glLightfv(light, Gl.GL_SPOT_DIRECTION, new float[] {0.0f, 0.0f, -1.0f});
			Gl.glLightf (light, Gl.GL_SPOT_EXPONENT,  0f);
			Gl.glLightf (light, Gl.GL_SPOT_CUTOFF,    180f);
			Gl.glLightf (light, Gl.GL_CONSTANT_ATTENUATION,  1f);
			Gl.glLightf (light, Gl.GL_LINEAR_ATTENUATION,    0f);
			Gl.glLightf (light, Gl.GL_QUADRATIC_ATTENUATION, 0f);
		}
		
		public void Setup(ref int lightCount)
		{
			int light = Gl.GL_LIGHT0 + lightCount++;
			ResetLight(light);
			
			LightTechniqueCommonAmbient ambient = this.TechniqueCommon.Item as LightTechniqueCommonAmbient;
			if (ambient != null) {
				float[] color = ambient.Color.ValuesAsFloats;
				Gl.glLightfv(light, Gl.GL_AMBIENT,  new float[] {color[0], color[1], color[2], 1.0f});
				Gl.glLightfv(light, Gl.GL_DIFFUSE,  new float[] {0.0f, 0.0f, 0.0f, 1.0f});
				Gl.glLightfv(light, Gl.GL_SPECULAR, new float[] {0.0f, 0.0f, 0.0f, 1.0f});
			}
			LightTechniqueCommonDirectional directional = this.TechniqueCommon.Item as LightTechniqueCommonDirectional;
			if (directional != null) {
				float[] color = directional.Color.ValuesAsFloats;
				Gl.glLightfv(light, Gl.GL_DIFFUSE, new float[] {color[0], color[1], color[2], 1.0f});
			}
			LightTechniqueCommonPoint point = this.TechniqueCommon.Item as LightTechniqueCommonPoint;
			if (point != null) {
				float[] color = point.Color.ValuesAsFloats;
				Gl.glLightfv(light, Gl.GL_DIFFUSE,  new float[] {color[0], color[1], color[2], 1.0f});
				Gl.glLightfv(light, Gl.GL_POSITION, new float[] {0.0f, 0.0f, 0.0f, 1.0f});
				Gl.glLightf (light, Gl.GL_CONSTANT_ATTENUATION,  (float)point.ConstantAttenuation.Value);
				Gl.glLightf (light, Gl.GL_LINEAR_ATTENUATION,    (float)point.LinearAttenuation.Value);
				Gl.glLightf (light, Gl.GL_QUADRATIC_ATTENUATION, (float)point.QuadraticAttenuation.Value);
			}
			LightTechniqueCommonSpot spot = this.TechniqueCommon.Item as LightTechniqueCommonSpot;
			if (spot != null) {
				float[] color = spot.Color.ValuesAsFloats;
				Gl.glLightfv(light, Gl.GL_DIFFUSE,  new float[] {color[0], color[1], color[2], 1.0f});
				Gl.glLightfv(light, Gl.GL_POSITION, new float[] {0.0f, 0.0f, 0.0f, 1.0f});
				Gl.glLightf (light, Gl.GL_SPOT_EXPONENT,         (float)spot.FalloffExponent.Value);
				Gl.glLightf (light, Gl.GL_SPOT_CUTOFF,           (float)spot.FalloffAngle.Value);
				Gl.glLightf (light, Gl.GL_CONSTANT_ATTENUATION,  (float)spot.ConstantAttenuation.Value);
				Gl.glLightf (light, Gl.GL_LINEAR_ATTENUATION,    (float)spot.LinearAttenuation.Value);
				Gl.glLightf (light, Gl.GL_QUADRATIC_ATTENUATION, (float)spot.QuadraticAttenuation.Value);
			}
			
			Gl.glEnable(light);
		}
		
		public void Render()
		{
			Gl.glDisable(Gl.GL_LIGHTING);
			Gl.glColor3f(1.0f, 1.0f, 0.0f);
			Tao.FreeGlut.Glut.glutSolidSphere(5.0, 10, 8);
			Gl.glEnable(Gl.GL_LIGHTING);
		}
	}
}
