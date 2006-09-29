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
	public partial class Animation
	{
		public void Animate()
		{
			foreach(object item in this.Items) {
				Channel channel = item as Channel;
				if (channel != null) {
					Sampler sampler = Sampler.IDs[channel.Source.Remove(0,1)];
					float[] input = null;
					float[] output = null;
					float[] inTangent = null;
					float[] outTangent = null;
					string[] interpolation = null;
					foreach(InputLocal samplerInput in sampler.Input) {
						Source source = Source.IDs[samplerInput.Source.Remove(0,1)];
						switch(samplerInput.Semantic) {
							case "INPUT": input = ((FloatArray)source.Item).ValuesAsFloats; break;
							case "OUTPUT": output = ((FloatArray)source.Item).ValuesAsFloats; break;
							case "IN_TANGENT": inTangent = ((FloatArray)source.Item).ValuesAsFloats; break;
							case "OUT_TANGENT": outTangent = ((FloatArray)source.Item).ValuesAsFloats; break;
							case "INTERPOLATION": interpolation = ((NameArray)source.Item).Values; break;
						}
					}
					
					float time = (float)Viewer.MainForm.RunningTime.TotalSeconds;
					time = time % input[input.Length - 1];
					int index = -1;
					for(int i = 0; i < input.Length - 1; i++) {
						if (input[i] <= time && time < input[i+1]) {
							index = i;
							break;
						}
					}
					if (index != -1) {
						// Bezier interpolation. See https://collada.org/public_forum/viewtopic.php?t=559
						float s = (time - input[index]) / (input[index+1] - input[index]);
						Math.Vector S = new Math.Vector(s*s*s, s*s, s, 1);
						Math.Matrix M = new Math.Matrix(-1,  3, -3,  1,
						                                 3, -6,  3,  0,
						                                -3,  3,  0,  0,
						                                 1,  0,  0,  0);
						Math.Vector C = new Math.Vector(output[index],
						                                output[index] + outTangent[index] / 3,
						                                output[index+1] - inTangent[index+1] / 3,
						                                output[index+1]);
						double interpolatedValue = S * (M * C);
						
						string[] target = channel.Target.Split(new char[] {'/', '.'});
						string id = target[0];
						string sid = target[1];
						string property = target[2];
						if (Node.IDs.ContainsKey(id)) {
							Node node = Node.IDs[id];
							foreach(object transform in node.Items) {
								if (transform is Rotate && ((Rotate)transform).Sid == sid) {
									double[] values = ((Rotate)transform).Values;
									values[3] = interpolatedValue;
									((Rotate)transform).Text = "";
									foreach(double val in values) {
										((Rotate)transform).Text += val.ToString() + " ";
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
