namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000383")]
internal struct XStoreImage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F7")]
	internal string uri; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009F8")]
	internal uint height; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40009F9")]
	internal uint width; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009FA")]
	internal string caption; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009FB")]
	internal string imagePurposeTag; //Field offset: 0x18

}

