namespace UnityEngine;

[NativeHeader("Runtime/Camera/SharedLightData.h")]
[Token(Token = "0x20000F7")]
public struct LightBakingOutput
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400029F")]
	public int probeOcclusionLightIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002A0")]
	public int occlusionMaskChannel; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("lightmapBakeMode.lightmapBakeType")]
	[Token(Token = "0x40002A1")]
	public LightmapBakeType lightmapBakeType; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("lightmapBakeMode.mixedLightingMode")]
	[Token(Token = "0x40002A2")]
	public MixedLightingMode mixedLightingMode; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A3")]
	public bool isBaked; //Field offset: 0x10

}

