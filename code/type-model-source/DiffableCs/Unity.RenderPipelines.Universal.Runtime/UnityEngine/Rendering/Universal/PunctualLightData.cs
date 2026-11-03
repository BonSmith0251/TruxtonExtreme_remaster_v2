namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001F4")]
public struct PunctualLightData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AC2")]
	public Vector3 wsPos; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000AC3")]
	public float radius; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AC4")]
	public Vector4 color; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AC5")]
	public Vector4 attenuation; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000AC6")]
	public Vector3 spotDirection; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000AC7")]
	public int flags; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AC8")]
	public Vector4 occlusionProbeInfo; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000AC9")]
	public uint layerMask; //Field offset: 0x50

}

