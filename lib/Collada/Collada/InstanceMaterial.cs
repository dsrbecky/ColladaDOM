// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Tao.OpenGl;
using Tao.DevIl;

using Collada.Util;

namespace Collada
{
	public partial class InstanceMaterial
	{
		public static Dictionary<string, int> textures = new Dictionary<string, int>();
		
		public void Use()
		{
			Material material = Material.IDs[this.Target.Remove(0,1)];
			Effect effect = Effect.IDs[material.InstanceEffect.Url.Remove(0,1)];
			EffectFxProfileAbstractProfileCOMMONTechniquePhong phong = effect.Items[0].Technique.Item as EffectFxProfileAbstractProfileCOMMONTechniquePhong;
			if (phong != null) {
				CommonColorOrTextureTypeColor color = phong.Diffuse.Item as CommonColorOrTextureTypeColor;
				CommonColorOrTextureTypeParam param = phong.Diffuse.Item as CommonColorOrTextureTypeParam;
				CommonColorOrTextureTypeTexture texture = phong.Diffuse.Item as CommonColorOrTextureTypeTexture;
				if (color != null) {
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
					
					Gl.glEnable(Gl.GL_TEXTURE_2D);
					
					if (textures.ContainsKey((string)image.Item)) {
						Gl.glBindTexture(Gl.GL_TEXTURE_2D, textures[(string)image.Item]);
					} else {
						using(PerformanceLog log2 = new PerformanceLog("Load texture")) {
							// Make texture
							int[] texNames = new int[1];
							Gl.glGenTextures(texNames.Length, texNames);
							Gl.glBindTexture(Gl.GL_TEXTURE_2D, texNames[0]);
							textures[(string)image.Item] = texNames[0];
							
							// Load image
							Il.ilBindImage(1);
							Il.ilLoadImage(@"..\sample_data\" + (string)image.Item);
							Ilu.iluFlipImage();
							Ilut.ilutGLBuildMipmaps();
						}
					}
				}
				
				Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_EMISSION , ((CommonColorOrTextureTypeColor)phong.Emission.Item).ValuesAsFloats);
				Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_AMBIENT  , ((CommonColorOrTextureTypeColor)phong.Ambient.Item).ValuesAsFloats);
				Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_SPECULAR , ((CommonColorOrTextureTypeColor)phong.Specular.Item).ValuesAsFloats);
				Gl.glMaterialf (Gl.GL_FRONT_AND_BACK, Gl.GL_SHININESS, (float)((CommonFloatOrParamTypeFloat)phong.Shininess.Item).Value);
			}
		}
	}
}
