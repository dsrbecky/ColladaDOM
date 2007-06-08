// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

using Tao.OpenGl;

using Collada.Util;

namespace Collada
{
	public partial class COLLADA
	{
		static XmlSerializer serializer;
		
		static XmlSerializer Serializer {
			get {
				if (serializer == null) {
					using(new PerformanceLog("Creating serializer", LogType.Loading)) {
						serializer = new XmlSerializer(typeof(COLLADA));
					}
				}
				return serializer;
			}
		}
		
		public static COLLADA Load(string filename)
		{
			using(new PerformanceLog("Loading xml file " + filename, LogType.Loading)) {
				FileStream file = new FileStream(filename, FileMode.Open);
				COLLADA colladaDocument = (COLLADA)Serializer.Deserialize(file);
				file.Close();
				return colladaDocument;
			}
		}
		
		public List<T> GetLibrariesOfType<T>()
		{
			List<T> libraries = new List<T>();
			foreach(object item in this.Items) {
				if (item is T) {
					libraries.Add((T)item);
				}
			}
			return libraries;
		}
		
		[XmlIgnore]
		public List<LibraryAnimationClips> LibraryAnimationClips {
			get { return GetLibrariesOfType<LibraryAnimationClips>(); }
		}
		
		[XmlIgnore]
		public List<LibraryAnimations> LibraryAnimations {
			get { return GetLibrariesOfType<LibraryAnimations>(); }
		}
		
		[XmlIgnore]
		public List<LibraryCameras> LibraryCameras {
			get { return GetLibrariesOfType<LibraryCameras>(); }
		}
		
		[XmlIgnore]
		public List<LibraryControllers> LibraryControllers {
			get { return GetLibrariesOfType<LibraryControllers>(); }
		}
		
		[XmlIgnore]
		public List<LibraryEffects> LibraryEffects {
			get { return GetLibrariesOfType<LibraryEffects>(); }
		}
		
		[XmlIgnore]
		public List<LibraryForceFields> LibraryForceFields {
			get { return GetLibrariesOfType<LibraryForceFields>(); }
		}
		
		[XmlIgnore]
		public List<LibraryGeometries> LibraryGeometries {
			get { return GetLibrariesOfType<LibraryGeometries>(); }
		}
		
		[XmlIgnore]
		public List<LibraryImages> LibraryImages {
			get { return GetLibrariesOfType<LibraryImages>(); }
		}
		
		[XmlIgnore]
		public List<LibraryLights> LibraryLights {
			get { return GetLibrariesOfType<LibraryLights>(); }
		}
		
		[XmlIgnore]
		public List<LibraryMaterials> LibraryMaterials {
			get { return GetLibrariesOfType<LibraryMaterials>(); }
		}
		
		[XmlIgnore]
		public List<LibraryNodes> LibraryNodes {
			get { return GetLibrariesOfType<LibraryNodes>(); }
		}
		
		[XmlIgnore]
		public List<LibraryPhysicsMaterials> LibraryPhysicsMaterials {
			get { return GetLibrariesOfType<LibraryPhysicsMaterials>(); }
		}
		
		[XmlIgnore]
		public List<LibraryPhysicsModels> LibraryPhysicsModels {
			get { return GetLibrariesOfType<LibraryPhysicsModels>(); }
		}
		
		[XmlIgnore]
		public List<LibraryPhysicsScenes> LibraryPhysicsScenes {
			get { return GetLibrariesOfType<LibraryPhysicsScenes>(); }
		}
		
		[XmlIgnore]
		public List<LibraryVisualScenes> LibraryVisualScenes {
			get { return GetLibrariesOfType<LibraryVisualScenes>(); }
		}
		
		public void Render()
		{
			using(new PerformanceLog("Animate")) {
				foreach(LibraryAnimations libAnim in this.LibraryAnimations) {
					libAnim.Animate();
				}
			}
			
			string sceneID = this.Scene.InstanceVisualScene.Url.Remove(0,1);
			VisualScene scene = VisualScene.IDs[sceneID];
			scene.Render();
		}
	}
}
