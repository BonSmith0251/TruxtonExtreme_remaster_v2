namespace UnityEngine;

[Obsolete("This property has been deprecated. Use LightType.Spot, LightType.Pyramid, or LightType.Box instead.")]
[Token(Token = "0x2000102")]
public enum LightShape : int
{
	Cone = 0,
	Pyramid = 1,
	Box = 2,
}

