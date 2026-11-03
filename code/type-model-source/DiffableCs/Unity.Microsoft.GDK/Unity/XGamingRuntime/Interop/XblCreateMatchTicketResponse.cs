namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002EE")]
internal struct XblCreateMatchTicketResponse
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400080A")]
	internal Byte[] matchTicketId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400080B")]
	internal long estimatedWaitTime; //Field offset: 0x8

}

