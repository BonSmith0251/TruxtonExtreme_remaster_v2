namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000037")]
internal struct PerLight2D
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010E")]
	internal float4x4 InvMatrix; //Field offset: 0x0
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400010F")]
	internal float4 Color; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000110")]
	internal float4 Position; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000111")]
	internal float FalloffIntensity; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000112")]
	internal float FalloffDistance; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000113")]
	internal float OuterAngle; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000114")]
	internal float InnerAngle; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000115")]
	internal float InnerRadiusMult; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000116")]
	internal float VolumeOpacity; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000117")]
	internal float ShadowIntensity; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000118")]
	internal int LightType; //Field offset: 0x7C

}

