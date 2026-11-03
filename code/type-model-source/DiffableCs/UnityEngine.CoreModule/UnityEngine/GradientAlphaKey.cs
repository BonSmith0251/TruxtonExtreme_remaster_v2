namespace UnityEngine;

[Token(Token = "0x2000150")]
[UsedByNativeCode]
public struct GradientAlphaKey
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000580")]
	public float alpha; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000581")]
	public float time; //Field offset: 0x4

	[Address(RVA = "0x12F1450", Offset = "0x12F0850", Length = "0xA")]
	[Token(Token = "0x6001011")]
	public GradientAlphaKey(float alpha, float time) { }

}

