namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000344")]
internal struct XblVerifyStringResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400096C")]
	internal readonly XblVerifyStringResultCode resultCode; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400096D")]
	internal readonly UTF8StringPtr firstOffendingSubstring; //Field offset: 0x8

}

