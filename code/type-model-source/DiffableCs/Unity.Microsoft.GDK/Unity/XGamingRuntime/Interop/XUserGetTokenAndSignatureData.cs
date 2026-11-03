namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003A8")]
internal struct XUserGetTokenAndSignatureData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A65")]
	internal ulong tokenSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A66")]
	internal ulong signatureSize; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A67")]
	internal string token; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A68")]
	internal string signature; //Field offset: 0x18

}

