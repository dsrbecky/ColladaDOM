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
	public partial class InstanceGeometry
	{
		public InstanceMaterial FindMaterial(string symbol)
		{
			if (this.BindMaterial != null) {
				foreach(InstanceMaterial material in this.BindMaterial.technique_common) {
					if (material.Symbol == symbol) {
						return material;
					}
				}
			}
			return null;
		}
		
		public void UseMaterial(string symbol)
		{
			Material material = Material.IDs[FindMaterial(symbol).Target.Remove(0,1)];
			Effect effect = Effect.IDs[material.InstanceEffect.Url.Remove(0,1)];
			EffectFxProfileAbstractProfileCOMMONTechniquePhong phong = effect.Items[0].Technique.Item as EffectFxProfileAbstractProfileCOMMONTechniquePhong;
			if (phong != null) {
				Gl.glColor4fv(((CommonColorOrTextureTypeColor)phong.Diffuse.Item).ValuesAsFloats);
				Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_EMISSION , ((CommonColorOrTextureTypeColor)phong.Emission.Item).ValuesAsFloats);
				Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_AMBIENT  , ((CommonColorOrTextureTypeColor)phong.Ambient.Item).ValuesAsFloats);
				Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_DIFFUSE  , ((CommonColorOrTextureTypeColor)phong.Diffuse.Item).ValuesAsFloats);
				Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_SPECULAR , ((CommonColorOrTextureTypeColor)phong.Specular.Item).ValuesAsFloats);
				Gl.glMaterialf (Gl.GL_FRONT_AND_BACK, Gl.GL_SHININESS, (float)((CommonFloatOrParamTypeFloat)phong.Shininess.Item).Value);
			}
		}
		
		public void Render()
		{
			string geometryID = this.Url.Remove(0,1);
			Geometry geometry = Geometry.IDs[geometryID];
			geometry.Render(this);
		}
	}
}
