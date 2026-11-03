namespace UnityEngine.Rendering;

[Token(Token = "0x20003D1")]
public struct LightShadowCasterCullingInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C69")]
	public RangeInt splitRange; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C6A")]
	public BatchCullingProjectionType projectionType; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000C6B")]
	public ushort splitExclusionMask; //Field offset: 0xC

}

