namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002B1")]
internal struct WebSocketCompletionResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400072A")]
	internal readonly IntPtr websocket; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400072B")]
	internal readonly int errorCode; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400072C")]
	internal readonly uint platformErrorCode; //Field offset: 0xC

}

