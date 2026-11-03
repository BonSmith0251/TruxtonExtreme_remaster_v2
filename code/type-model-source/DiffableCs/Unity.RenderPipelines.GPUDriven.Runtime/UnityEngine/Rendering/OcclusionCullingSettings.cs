namespace UnityEngine.Rendering;

[Token(Token = "0x2000033")]
public struct OcclusionCullingSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A4")]
	public int viewInstanceID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000A5")]
	public OcclusionTest occlusionTest; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000A6")]
	public int instanceMultiplier; //Field offset: 0x8

	[Address(RVA = "0x2CD3920", Offset = "0x2CD2D20", Length = "0xE")]
	[Token(Token = "0x600011E")]
	public OcclusionCullingSettings(int viewInstanceID, OcclusionTest occlusionTest) { }

}

