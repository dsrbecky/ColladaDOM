// <file>
//     <copyright name="David Srbeck�" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.IO;

using Collada;
using Tao.OpenGl;
using Tao.DevIl;

namespace Collada.Util
{
	public class Texture
	{
		public static string[] TexturePaths = new string[]{@""};
		
		static Dictionary<String, Texture> textureCache = new Dictionary<String, Texture>();
		
		int textureName;
		int height;
		int width;
		
		public int Height {
			get { return height; }
		}
		
		public int Width {
			get { return width; }
		}
		
		public static Texture Load(string name)
		{
			if (textureCache.ContainsKey(name)) {
				return textureCache[name];
			} else {
				using(new PerformanceLog("Load texture: " + name, LogType.Loading)) {
					// Make texture
					int[] texNames = new int[1];
					Gl.glGenTextures(texNames.Length, texNames);
					Gl.glBindTexture(Gl.GL_TEXTURE_2D, texNames[0]);
					Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
					Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
					
					string texturePath = "";
					foreach(string t in TexturePaths) {
						texturePath = Path.Combine(t, name);
						if (File.Exists(texturePath)) break;
					}
					
					if (!File.Exists(texturePath)) {
						System.Console.WriteLine("Can not find texture {0}", name);
						return null;
					}
					
					// Load image
					Il.ilBindImage(1);
					Il.ilLoadImage(texturePath);
					//Ilu.iluFlipImage();
					Ilut.ilutGLBuildMipmaps();
					
					int height = Il.ilGetInteger(Il.IL_IMAGE_HEIGHT);
					int width  = Il.ilGetInteger(Il.IL_IMAGE_WIDTH);
					
					Texture texture = new Texture(texNames[0], height, width);
					textureCache[name] = texture;
					return texture;
				}
			}
		}
		
		Texture(int textureName, int height, int width)
		{
			this.textureName = textureName;
			this.height = height;
			this.width = width;
		}
		
		public void Bind()
		{
			Gl.glEnable(Gl.GL_TEXTURE_2D);
			Gl.glTexEnvf(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_MODULATE);
			Gl.glBindTexture(Gl.GL_TEXTURE_2D, textureName);
		}
	}
}
