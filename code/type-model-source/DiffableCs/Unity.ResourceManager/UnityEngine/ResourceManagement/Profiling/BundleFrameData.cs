namespace UnityEngine.ResourceManagement.Profiling;

[Token(Token = "0x2000075")]
internal struct BundleFrameData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013A")]
	public int BundleCode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400013B")]
	public int ReferenceCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400013C")]
	public float PercentComplete; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400013D")]
	public ContentStatus Status; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400013E")]
	public BundleSource Source; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400013F")]
	public BundleOptions LoadingOptions; //Field offset: 0x14

}

