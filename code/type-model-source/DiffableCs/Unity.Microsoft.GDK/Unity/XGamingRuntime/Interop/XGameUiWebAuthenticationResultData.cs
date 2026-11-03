namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000366")]
internal struct XGameUiWebAuthenticationResultData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009B3")]
	internal uint responseStatus; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009B4")]
	internal ulong responseCompletionUriSize; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009B5")]
	internal string responseCompletionUri; //Field offset: 0x10

}

