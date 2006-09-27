// <file>
//     <copyright name="David Srbeck�" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Tao.OpenGl;

namespace Collada
{
	public partial class CameraOpticsTechniqueCommonOrthographic
	{
		public void GetCameraParameters(out double xMag, out double yMag, out double zNear, out double zFar)
		{
			// Aspect ratio is defined as yfov / xfov
			double viewportAspectRatio = 1d;
			
			// Load items
			TargetableFloat itemAspectRatio = null;
			TargetableFloat itemXmag = null;
			TargetableFloat itemYmag = null;
			for(int i = 0; i < this.Items.Length; i++) {
				switch (this.ItemsElementName[i]) {
					case ItemsChoiceType.aspect_ratio: itemAspectRatio = this.Items[i] as TargetableFloat; break;
					case ItemsChoiceType.xmag: itemXmag = this.Items[i] as TargetableFloat; break;
					case ItemsChoiceType.ymag: itemYmag = this.Items[i] as TargetableFloat; break;
				}
			}
			
			// Get Xmag
			if (itemXmag != null) {
				xMag = itemXmag.Value;
			} else if (itemYmag != null && itemAspectRatio != null) {
				xMag = itemYmag.Value / itemAspectRatio.Value;
			} else if (itemYmag != null) {
				xMag = itemYmag.Value / viewportAspectRatio;
			} else {
				xMag = 1.0; // TODO: Waring: invalid collada document
			}
			
			// Get Ymag
			if (itemYmag != null) {
				yMag = itemYmag.Value;
			} else if (itemXmag != null && itemAspectRatio != null) {
				yMag = itemXmag.Value * itemAspectRatio.Value;
			} else if (itemXmag != null) {
				yMag = itemXmag.Value * viewportAspectRatio;
			} else {
				yMag = 1.0; // TODO: Waring: invalid collada document
			}
			
			// Get zNear and zFar
			zNear = this.Znear.Value;
			zFar = this.Zfar.Value;
		}
	}
}