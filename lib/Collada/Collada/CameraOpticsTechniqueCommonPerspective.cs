// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Tao.OpenGl;

using Collada.Util;

namespace Collada
{
	public partial class CameraOpticsTechniqueCommonPerspective
	{
		public void GetCameraParameters(out double yFov, out double aspectRatio, out double zNear, out double zFar)
		{
			// Aspect ratio is defined as yfov / xfov
			
			// Load items
			TargetableFloat itemAspectRatio = null;
			TargetableFloat itemXfov = null;
			TargetableFloat itemYfov = null;
			for(int i = 0; i < this.Items.Length; i++) {
				switch (this.ItemsElementName[i]) {
					case ItemsChoiceType1.aspect_ratio: itemAspectRatio = this.Items[i] as TargetableFloat; break;
					case ItemsChoiceType1.xfov: itemXfov = this.Items[i] as TargetableFloat; break;
					case ItemsChoiceType1.yfov: itemYfov = this.Items[i] as TargetableFloat; break;
				}
			}
			
			// Get Y-Fov
			if (itemYfov != null) {
				yFov = itemYfov.Value;
			} else if (itemXfov != null && itemAspectRatio != null) {
				yFov = itemXfov.Value * itemAspectRatio.Value;
			} else if (itemXfov != null) {
				yFov = itemXfov.Value * GlobalSettings.ViewportAspectRatio;
			} else {
				yFov = 45d; // TODO: Waring: invalid collada document
			}
			
			// Get aspect ratio
			if (itemAspectRatio != null) {
				aspectRatio = itemAspectRatio.Value;
			} else if (itemXfov != null && itemYfov != null) {
				aspectRatio = itemYfov.Value / itemXfov.Value;
			} else {
				aspectRatio = GlobalSettings.ViewportAspectRatio;
			}
			
			// Get zNear and zFar
			zNear = this.Znear.Value;
			zFar = this.Zfar.Value;
		}
	}
}
