namespace UnityEngine.Rendering;

[Token(Token = "0x20000CA")]
internal struct BottleneckHistogram
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000291")]
	internal float PresentLimited; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000292")]
	internal float CPU; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000293")]
	internal float GPU; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000294")]
	internal float Balanced; //Field offset: 0xC

}

