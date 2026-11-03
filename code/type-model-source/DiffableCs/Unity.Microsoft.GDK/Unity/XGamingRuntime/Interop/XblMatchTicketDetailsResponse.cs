namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002F0")]
internal struct XblMatchTicketDetailsResponse
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400080F")]
	internal XblTicketStatus matchStatus; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000810")]
	internal long estimatedWaitTime; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000811")]
	internal XblPreserveSessionMode preserveSession; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000812")]
	internal XblMultiplayerSessionReference ticketSession; //Field offset: 0x14
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x4000813")]
	internal XblMultiplayerSessionReference targetSession; //Field offset: 0x104
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000814")]
	internal readonly UTF8StringPtr ticketAttributes; //Field offset: 0x1F8

}

