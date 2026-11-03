namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003AA")]
internal struct XUserGetTokenAndSignatureUtf16Data
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A6B")]
	internal ulong tokenSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A6C")]
	internal ulong signatureSize; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A6D")]
	internal string token; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A6E")]
	internal string signature; //Field offset: 0x18

}

