namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000388")]
internal struct XStoreVideo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A15")]
	internal string uri; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A16")]
	internal uint height; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000A17")]
	internal uint width; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A18")]
	internal string caption; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A19")]
	internal string videoPurposeTag; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A1A")]
	internal XStoreImage previewImage; //Field offset: 0x20

}

