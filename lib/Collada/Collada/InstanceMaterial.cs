// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

using Tao.OpenGl;
using Tao.DevIl;

using Collada.Util;

namespace Collada
{
	public partial class InstanceMaterial
	{
		COLLADA collada;
		
		public InstanceMaterial()
		{
			collada = COLLADA.LastCreatedCollada;
		}
		
		string AutoTextureFilename {
			get {
				string imageFilename = Path.GetFileNameWithoutExtension(collada.Filename) + ".png";
				string path = Path.Combine(collada.Directory, imageFilename);
				if (File.Exists(path)) {
					return path;
				} else {
					return null;
				}
			}
		}
		
		public void Use()
		{
			Material material = Material.IDs[this.Target.Remove(0,1)];
			Effect effect = Effect.IDs[material.InstanceEffect.Url.Remove(0,1)];
			EffectFxProfileAbstractProfileCOMMONTechniquePhong phong = effect.Items[0].Technique.Item as EffectFxProfileAbstractProfileCOMMONTechniquePhong;
			if (phong != null) {
				CommonColorOrTextureTypeColor color = phong.Diffuse.Item as CommonColorOrTextureTypeColor;
				CommonColorOrTextureTypeParam param = phong.Diffuse.Item as CommonColorOrTextureTypeParam;
				CommonColorOrTextureTypeTexture texture = phong.Diffuse.Item as CommonColorOrTextureTypeTexture;
				if (AutoTextureFilename != null) {
					Texture tex = Texture.Load(AutoTextureFilename);
					tex.Bind();
				} else if (color != null) {
					Gl.glDisable(Gl.GL_TEXTURE_2D);
					Gl.glColor4fv(color.ValuesAsFloats);
					Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_DIFFUSE, color.ValuesAsFloats);
				} else if (texture != null) {
					FxSampler2DCommon sampler = null;
					FxSurfaceCommon surface = null;
					foreach(object item in effect.Items[0].Items) {
						CommonNewparamType newparam = item as CommonNewparamType;
						if (newparam != null && newparam.Item is FxSampler2DCommon) {
							sampler = (FxSampler2DCommon)newparam.Item;
						}
					}
					if (sampler != null) {
						foreach(object item in effect.Items[0].Items) {
							CommonNewparamType newparam = item as CommonNewparamType;
							if (newparam != null && newparam.Item is FxSurfaceCommon &&
							    newparam.Sid == sampler.Source)
							{
								surface = (FxSurfaceCommon)newparam.Item;
							}
						}
					}
					Image image = Image.IDs[surface.InitFrom[0].Value];
					
					Texture tex = Texture.Load((string)image.Item);
					tex.Bind();
				}
				
				Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_EMISSION , ((CommonColorOrTextureTypeColor)phong.Emission.Item).ValuesAsFloats);
				Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_AMBIENT  , ((CommonColorOrTextureTypeColor)phong.Ambient.Item).ValuesAsFloats);
				Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_SPECULAR , ((CommonColorOrTextureTypeColor)phong.Specular.Item).ValuesAsFloats);
				Gl.glMaterialf (Gl.GL_FRONT_AND_BACK, Gl.GL_SHININESS, (float)((CommonFloatOrParamTypeFloat)phong.Shininess.Item).Value);
			}
		}
	}
}
