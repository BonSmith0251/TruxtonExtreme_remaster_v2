namespace UnityEngine.Rendering;

[Token(Token = "0x20001BC")]
public static class ColorSpaceUtils
{
	[Token(Token = "0x400089D")]
	public static readonly float3x3 Rec709ToRec2020Mat; //Field offset: 0x0
	[Token(Token = "0x400089E")]
	public static readonly float3x3 Rec709ToP3D65Mat; //Field offset: 0x24
	[Token(Token = "0x400089F")]
	public static readonly float3x3 Rec2020ToRec709Mat; //Field offset: 0x48
	[Token(Token = "0x40008A0")]
	public static readonly float3x3 Rec2020ToP3D65Mat; //Field offset: 0x6C
	[Token(Token = "0x40008A1")]
	public static readonly float3x3 P3D65ToRec2020Mat; //Field offset: 0x90

	[Address(RVA = "0x2C44A80", Offset = "0x2C43E80", Length = "0x12F")]
	[Token(Token = "0x6000D88")]
	private static ColorSpaceUtils() { }

}

